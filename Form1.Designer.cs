namespace Chat_Program
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxclient1 = new System.Windows.Forms.GroupBox();
            this.IPlabel = new System.Windows.Forms.Label();
            this.Portlabel2 = new System.Windows.Forms.Label();
            this.textlocolport = new System.Windows.Forms.TextBox();
            this.textlocolIp = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.client2groupBox = new System.Windows.Forms.GroupBox();
            this.Port2label = new System.Windows.Forms.Label();
            this.ip2label = new System.Windows.Forms.Label();
            this.textfriendsPort = new System.Windows.Forms.TextBox();
            this.textFriendsIP = new System.Windows.Forms.TextBox();
            this.textmessage = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.Startbutton = new System.Windows.Forms.Button();
            this.sendbutton2 = new System.Windows.Forms.Button();
            this.groupBoxclient1.SuspendLayout();
            this.client2groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxclient1
            // 
            this.groupBoxclient1.Controls.Add(this.IPlabel);
            this.groupBoxclient1.Controls.Add(this.Portlabel2);
            this.groupBoxclient1.Controls.Add(this.textlocolport);
            this.groupBoxclient1.Controls.Add(this.textlocolIp);
            this.groupBoxclient1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxclient1.Name = "groupBoxclient1";
            this.groupBoxclient1.Size = new System.Drawing.Size(304, 96);
            this.groupBoxclient1.TabIndex = 0;
            this.groupBoxclient1.TabStop = false;
            this.groupBoxclient1.Text = "client1";
            // 
            // IPlabel
            // 
            this.IPlabel.AutoSize = true;
            this.IPlabel.Location = new System.Drawing.Point(7, 18);
            this.IPlabel.Name = "IPlabel";
            this.IPlabel.Size = new System.Drawing.Size(19, 16);
            this.IPlabel.TabIndex = 5;
            this.IPlabel.Text = "IP";
            // 
            // Portlabel2
            // 
            this.Portlabel2.AutoSize = true;
            this.Portlabel2.Location = new System.Drawing.Point(7, 52);
            this.Portlabel2.Name = "Portlabel2";
            this.Portlabel2.Size = new System.Drawing.Size(31, 16);
            this.Portlabel2.TabIndex = 6;
            this.Portlabel2.Text = "Port";
            // 
            // textlocolport
            // 
            this.textlocolport.Location = new System.Drawing.Point(110, 49);
            this.textlocolport.Name = "textlocolport";
            this.textlocolport.Size = new System.Drawing.Size(188, 22);
            this.textlocolport.TabIndex = 3;
            this.textlocolport.TextChanged += new System.EventHandler(this.textlocolport_TextChanged);
            // 
            // textlocolIp
            // 
            this.textlocolIp.Location = new System.Drawing.Point(110, 10);
            this.textlocolIp.Name = "textlocolIp";
            this.textlocolIp.Size = new System.Drawing.Size(188, 22);
            this.textlocolIp.TabIndex = 2;
            // 
            // client2groupBox
            // 
            this.client2groupBox.Controls.Add(this.Port2label);
            this.client2groupBox.Controls.Add(this.ip2label);
            this.client2groupBox.Controls.Add(this.textfriendsPort);
            this.client2groupBox.Controls.Add(this.textFriendsIP);
            this.client2groupBox.Location = new System.Drawing.Point(337, 12);
            this.client2groupBox.Name = "client2groupBox";
            this.client2groupBox.Size = new System.Drawing.Size(302, 96);
            this.client2groupBox.TabIndex = 1;
            this.client2groupBox.TabStop = false;
            this.client2groupBox.Text = "client2";
            // 
            // Port2label
            // 
            this.Port2label.AutoSize = true;
            this.Port2label.Location = new System.Drawing.Point(23, 52);
            this.Port2label.Name = "Port2label";
            this.Port2label.Size = new System.Drawing.Size(31, 16);
            this.Port2label.TabIndex = 7;
            this.Port2label.Text = "Port";
            // 
            // ip2label
            // 
            this.ip2label.AutoSize = true;
            this.ip2label.Location = new System.Drawing.Point(23, 24);
            this.ip2label.Name = "ip2label";
            this.ip2label.Size = new System.Drawing.Size(19, 16);
            this.ip2label.TabIndex = 6;
            this.ip2label.Text = "IP";
            // 
            // textfriendsPort
            // 
            this.textfriendsPort.Location = new System.Drawing.Point(110, 52);
            this.textfriendsPort.Name = "textfriendsPort";
            this.textfriendsPort.Size = new System.Drawing.Size(186, 22);
            this.textfriendsPort.TabIndex = 4;
            // 
            // textFriendsIP
            // 
            this.textFriendsIP.Location = new System.Drawing.Point(110, 10);
            this.textFriendsIP.Name = "textFriendsIP";
            this.textFriendsIP.Size = new System.Drawing.Size(186, 22);
            this.textFriendsIP.TabIndex = 3;
            // 
            // textmessage
            // 
            this.textmessage.Location = new System.Drawing.Point(22, 354);
            this.textmessage.Multiline = true;
            this.textmessage.Name = "textmessage";
            this.textmessage.Size = new System.Drawing.Size(496, 60);
            this.textmessage.TabIndex = 3;
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 16;
            this.listMessage.Location = new System.Drawing.Point(12, 133);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(517, 164);
            this.listMessage.TabIndex = 4;
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(660, 22);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(116, 75);
            this.Startbutton.TabIndex = 5;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // sendbutton2
            // 
            this.sendbutton2.Location = new System.Drawing.Point(560, 354);
            this.sendbutton2.Name = "sendbutton2";
            this.sendbutton2.Size = new System.Drawing.Size(130, 60);
            this.sendbutton2.TabIndex = 6;
            this.sendbutton2.Text = "send";
            this.sendbutton2.UseVisualStyleBackColor = true;
            this.sendbutton2.Click += new System.EventHandler(this.sendbutton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendbutton2);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.textmessage);
            this.Controls.Add(this.client2groupBox);
            this.Controls.Add(this.groupBoxclient1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxclient1.ResumeLayout(false);
            this.groupBoxclient1.PerformLayout();
            this.client2groupBox.ResumeLayout(false);
            this.client2groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxclient1;
        private System.Windows.Forms.TextBox textlocolport;
        private System.Windows.Forms.TextBox textlocolIp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox client2groupBox;
        private System.Windows.Forms.TextBox textfriendsPort;
        private System.Windows.Forms.TextBox textFriendsIP;
        private System.Windows.Forms.TextBox textmessage;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Label IPlabel;
        private System.Windows.Forms.Label Portlabel2;
        private System.Windows.Forms.Label Port2label;
        private System.Windows.Forms.Label ip2label;
        private System.Windows.Forms.Button sendbutton2;
    }
}

