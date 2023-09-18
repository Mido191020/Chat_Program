using System;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;

namespace Chat_Program
{
    public partial class Form1 : Form
    {
        private Socket sck;
        private EndPoint epLocal, epRemote;
        private string connectionString = "Server=DESKTOP-ONEPOGB;Database=client logs;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            textlocolIp.Text = GetLocalIP();
            textFriendsIP.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "192.168.1.3";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    listMessage.Items.Add("Friend: " + receivedMessage);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void CheckDatabaseConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string testQuery = "SELECT 1";
                    using (SqlCommand command = new SqlCommand(testQuery, connection))
                    {
                        int result = (int)command.ExecuteScalar();
                        if (result == 1)
                        {
                            MessageBox.Show("Database connection is working.");
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Database connection error: " + exp.ToString());
            }
        }

        private void StoreMessageData(string senderIP, string receiverIP, string messageText)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string insertQuery = "INSERT INTO clientlogs (SenderIP, ReceiverIP, MessageText, MessageDateTime, IPAddress, LogDateTime) VALUES (@SenderIP, @ReceiverIP, @MessageText, @MessageDateTime, @IPAddress, @LogDateTime)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@SenderIP", senderIP);
                        cmd.Parameters.AddWithValue("@ReceiverIP", receiverIP);
                        cmd.Parameters.AddWithValue("@MessageText", messageText);
                        cmd.Parameters.AddWithValue("@MessageDateTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IPAddress", textlocolIp.Text); // You may need to replace this with the correct IP
                        cmd.Parameters.AddWithValue("@LogDateTime", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Database error: " + exp.ToString());
            }
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            CheckDatabaseConnection();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from clientlogs", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listMessage.Items.Add(dr["SenderIP"].ToString() + " " + dr["ReceiverIP"].ToString() + " " + dr["MessageText"].ToString() + " " + dr["MessageDateTime"].ToString() + " " + dr["IPAddress"].ToString() + " " + dr["LogDateTime"].ToString());
            }
            con.Close();

            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textlocolIp.Text), Convert.ToInt32(textlocolport.Text));
                sck.Bind(epLocal);
                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIP.Text), Convert.ToInt32(textfriendsPort.Text));
                sck.Connect(epRemote);
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                Startbutton.Text = "Connected";
                Startbutton.Enabled = false;
                sendbutton2.Enabled = true;
                textmessage.Focus();

                // Store the local IP address in the database
                string ipAddress = textlocolIp.Text; // You may need to replace this with the correct IP
                StoreMessageData(ipAddress, "", ""); // Sender and receiver IPs are empty initially
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void textlocolport_TextChanged(object sender, EventArgs e)
        {
        }

        private void listMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textmessage.Text);
                sck.Send(msg);
                listMessage.Items.Add("Me: " + textmessage.Text);

                // Store the message data in the database
                string senderIP = textlocolIp.Text; // You may need to replace this with the correct IP
                string receiverIP = textFriendsIP.Text; // You may need to replace this with the correct IP
                string messageText = textmessage.Text;
                StoreMessageData(senderIP, receiverIP, messageText);

                textmessage.Clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
