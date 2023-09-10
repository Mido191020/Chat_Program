using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // for IPAddress
using System.Net.Sockets; // for TcpListener, TcpClient


namespace Chat_Program
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;

        public Form1()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            textlocolIp.Text = GetLocalIP();
            textFriendsIP.Text = GetLocalIP();
        }
        private String GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
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
                if(size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    listMessage.Items.Add("Friend: " +receivedMessage);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal=new  IPEndPoint (IPAddress.Parse(textlocolIp.Text), Convert.ToInt32(textlocolport.Text)); 
                sck.Bind(epLocal);
                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIP.Text), Convert.ToInt32(textfriendsPort.Text));
                sck.Connect(epRemote);
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
               Startbutton.Text = "Connected";
                Startbutton.Enabled = false;
                sendbutton2.Enabled = true;
                textmessage.Focus();
            }

            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void textlocolport_TextChanged(object sender, EventArgs e)
        {

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
                textmessage.Clear();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
