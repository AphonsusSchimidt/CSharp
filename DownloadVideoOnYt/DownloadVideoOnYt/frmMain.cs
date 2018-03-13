using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.Text.RegularExpressions;

namespace DownloadVideoOnYt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLuuTru.Text = Application.StartupPath;
        }



        private void btnView_Click(object sender, EventArgs e)
        {
            //lockForm(true);
            YoutubeHelper yt = new YoutubeHelper();
            CheckForIllegalCrossThreadCalls = false;

            lblDangTai.Text = "Đang load thông tin video ...";
            prc.Style = ProgressBarStyle.Continuous;

            try
            {
                yt.KhoiTao(txtURL.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }

            lblTenVideo.Text = "Video: " + yt.TieuDe;
            lblMoTa.Text = "Mô tả: " + yt.MoTa;
            hinhanh.Image = new Bitmap(new System.IO.MemoryStream(new WebClient().DownloadData(yt.HinhAnh)));
            cmbLinkVideo.Items.Clear();
            foreach (var item in yt.ListUrlVideo)
            {
                cmbLinkVideo.Items.Add(item);
            }
        }



        private void btnChonThuMuc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtLuuTru.Text = f.SelectedPath;
            }
        }


        private void btnTaiVe_Click(object sender, EventArgs e)
        {
            if (cmbLinkVideo.SelectedIndex == -1) return;
            LinkYoutube obj = (LinkYoutube)cmbLinkVideo.SelectedItem;

            SaveFileDialog f = new SaveFileDialog();
            f.Filter = obj.DinhDang + "|*." + obj.getExt();
            f.InitialDirectory = txtLuuTru.Text;
            f.Title = "Luu file video";
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var _client = new WebClient())
                {
                    _client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    _client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    lockForm(true);

                    _client.DownloadFileAsync(new Uri(obj.URL), f.FileName);

                    while (_client.IsBusy)
                    {
                        Application.DoEvents();
                    }

                }
            }

        }


        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lblDangTai.Text = "Đang tải " + ToFileSize(e.BytesReceived) + " / " + ToFileSize(e.TotalBytesToReceive);
            prc.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            lockForm(false);
            MessageBox.Show("Tải thành công!");
        }

        private void lockForm(bool st)
        {
            txtURL.Enabled = !st;
            btnView.Enabled = !st;
            btnChonThuMuc.Enabled = !st;
            cmbLinkVideo.Enabled = !st;
            btnTaiVe.Enabled = !st;
            prc.Visible = st;
            lblDangTai.Visible = st;
        }

        public static string ToFileSize(long source)
        {
            const int byteConversion = 1024;
            double bytes = Convert.ToDouble(source);

            if (bytes >= Math.Pow(byteConversion, 3)) //GB Range
            {
                return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 3), 2), " GB");
            }
            else if (bytes >= Math.Pow(byteConversion, 2)) //MB Range
            {
                return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 2), 2), " MB");
            }
            else if (bytes >= byteConversion) //KB Range
            {
                return string.Concat(Math.Round(bytes / byteConversion, 2), " KB");
            }
            else //Bytes
            {
                return string.Concat(bytes, " Bytes");
            }
        }


    }
}
