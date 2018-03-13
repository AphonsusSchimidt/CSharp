using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownlByLinkGgDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Link = "";
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (Link != "")
            {
                System.Diagnostics.Process.Start(Link);
                txtInPut.Text = "";
                btnDownload.Visible = false;
                lblThongbao.Text = "";
            }
        }

        private void btnGetLink_Click(object sender, EventArgs e)
        {

            if (txtInPut.Text != "")
            {
                string str = txtInPut.Text;
                string[] arr = str.Split('/');
                if (arr.Length < 5)
                {
                    MessageBox.Show("Error Link", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string txtcode = arr[arr.Length - 2];
                Link = string.Format("https://docs.google.com/uc?export=download&id=" + txtcode);
                lblThongbao.Text = "Getlink Success !! Clik Download Now ";
                btnDownload.Visible = true;
            }
            else
            {
                MessageBox.Show("Plese Enter link in text box!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Link == "")
            {
                btnDownload.Visible = false;
            }
        }

        private void bntIDM_Click(object sender, EventArgs e)
        {

            var process = new System.Diagnostics.Process
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "C:\\Program Files (x86)\\Internet Download Manager\\IDMan.exe",
                    Domain = "https://seakbz.design/"
                }
            };
            process.Start();
            process.WaitForExit();
        }

        //connect IDM
        //public void connectIDM()
        //{
        //    string pathIDM = "c:\\Program Files\\Internet Download Manager\\IDMan.exe";
        //    string prm = "";
        //    string folder = "D:\\Phúc Binz";
        //    foreach (BaiHat current in album.BaiHat)
        //    {
        //        bool isSendingLink = true;
        //        prm = " /a /d ";
        //        prm += "\"" + current.LinkMp3 + "\" ";
        //        prm += "/p \"" + folder + "\"";
        //        System.Diagnostics.Process.Start(pathIDM, prm);
        //        Thread.Sleep(500); //đợi 1 lúc để gửi link sang idm
        //        isSendingLink = false; //đánh giấu thread đã chạy xong

        //        while (!isSendingLink) //đợi đến khi thread chạy xong
        //        {
        //            Application.DoEvents();
        //        }
        //    }
        //    System.Diagnostics.Process.Start(pathIDM, " /s"); //gọi lệnh download các url trong hàng chờ
        //}
    }
}
