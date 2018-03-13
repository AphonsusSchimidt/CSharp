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
namespace Server
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        // Tạo tiểu trình

        Thread XuLyClient;



        Socket server;
        IPEndPoint ipe;
        List<Socket> lstClient = new List<Socket>();
        string myIP = "";
        public void GetIP()
        {
            //lấy ip trong máy
            IPHostEntry iph = Dns.GetHostEntry(Dns.GetHostName());
            foreach( IPAddress diachiIP in iph.AddressList)
            {
                if(diachiIP.AddressFamily.ToString()=="InterNetwork")
                {
                    myIP = diachiIP.ToString();
                }
            }
            ipe = new IPEndPoint(IPAddress.Parse(myIP), 1809);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        }
        private void btnNghe_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetIP();
            XuLyClient = new Thread(new ThreadStart(NgheSK));
            XuLyClient.IsBackground = true;
            XuLyClient.Start();
        }
        public void NgheSK()
        {
            server.Bind(ipe);
            server.Listen(4);
            while(true){
                Socket skapp = server.Accept();
                lstClient.Add(skapp);

                // Tạo ra 1 thread Luôn luôn lắng nghe dữ liệu mới

                Thread clientProcess = new Thread(threadClient);
                clientProcess.IsBackground = true;
                clientProcess.Start(skapp);
                rtbMain.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                rtbMain.SelectionColor = Color.Blue;
                rtbMain.AppendText("Chấp Nhận Kết Nối Từ "+ skapp.RemoteEndPoint.ToString()+ "\n");
                rtbMain.ScrollToCaret();


            }
            
        }
        public void threadClient(object obj)
        {
            Socket skClient = (Socket)obj;
            while(true)
            {
                byte[] bff = new byte[1024];
                int revc = skClient.Receive(bff);
                foreach(Socket sk in lstClient)
                {
                    //mỗi lần nhận dữ liệu thì gửi qua cho ng dùng
                    sk.Send(bff, bff.Length, SocketFlags.None);
                }
            }
        }

        private void rtbMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
