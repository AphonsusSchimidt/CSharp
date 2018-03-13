using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using myLibrary1;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Client
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        Socket Client;
        IPEndPoint ipe;
        Thread KetNoi;
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rtbChat.Text != "")
            {
              
                DataST dt = new DataST();
                string str = string.Format("{0}\n",rtbChat.Text);
                dt.Name= txtName.Text;
                dt.ColorName = Color.Red;
                dt.FontName = new Font("Arial", 9, FontStyle.Bold);
                /////
                dt.TextChat = str;
                dt.ColorTextChat = rtbChat.ForeColor;
                dt.FontTextChat = rtbChat.Font;
                MemoryStream mmstr = new MemoryStream();
                BinaryFormatter bfomat = new BinaryFormatter();
                bfomat.Serialize(mmstr, dt);
                byte[] temp = new byte[1024];
                temp = mmstr.ToArray();
                Client.Send(temp);
                rtbChat.Text = "";
            }
            else
            {
                MessageBox.Show("Nội dung Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if(txtIP.Text!="")
            {
                txtName.Enabled = true;
                KetNoi = new Thread(new ThreadStart(KetNoiServer));
                KetNoi.IsBackground = true;
                KetNoi.Start();
            }
            else
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
        public void KetNoiServer()
        {
            ipe = new IPEndPoint(IPAddress.Parse(txtIP.Text), 1809);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            Client.Connect(ipe);
            Thread LangNgheServer = new Thread(LangNgheSV);
            LangNgheServer.Start(Client);
        }
        public void LangNgheSV(object obj)
        {
            Socket skClientSV = (Socket)obj;
            while (true)
            {
                byte[] bff = new byte[1024];
                int revc = Client.Receive(bff);
                MaHoa(bff);
            }
        }
        public void MaHoa(byte[] buff )
        {
            myLibrary1.DataST dtst = new DataST();
            myLibrary1.DataST dtName = new DataST();
            MemoryStream mstream = new MemoryStream(buff);
            BinaryFormatter fomat = new BinaryFormatter();
            dtst = (DataST)fomat.Deserialize(mstream);
            dtName = (DataST)fomat.Deserialize(mstream);
            ///Name
            rtbChatContain.SelectionFont = dtName.FontName;
            rtbChatContain.SelectionColor = dtName.ColorName;
            rtbChatContain.AppendText(dtName.Name + ": ");
            ///
            ///Text
            rtbChatContain.SelectionFont = dtst.FontTextChat;
            rtbChatContain.SelectionColor = dtst.ColorTextChat;
            rtbChatContain.AppendText(dtst.TextChat);
            rtbChatContain.ScrollToCaret();
        }

        private void lLblFont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(fontDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                rtbChat.Font = fontDialog1.Font;
            }
        }

        private void llblColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtbChat.ForeColor = colorDialog1.Color;
            }
        }
    }
}
