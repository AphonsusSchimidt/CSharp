using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gecko;
using Gecko.DOM;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using System.Collections;
using System.Linq;
using System.IO;
using System.Net;


namespace FbTools
{
    public partial class frmLogin2 : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        public string URL_LOGIN = "https://m.facebook.com/login/?next=https://m.facebook.com/messages/";

        public frmLogin2()
        {
            InitializeComponent();
            ThuVien.XoaCookie();
            //view morre --https://developer.mozilla.org/en-US/docs/Mozilla/Preferences
            GeckoPreferences.User["intl.accept_languages"] = "vi";
            GeckoPreferences.User["accept-language"] = "vi,en-US;q=0.8,en;q=0.6";
            GeckoPreferences.User["general.useragent.override"] = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36";
            //GeckoPreferences.User["browser.cache.disk.enable"] = false;
            //GeckoPreferences.User["browser.cache.memory.enable"] = false;
            //GeckoPreferences.User["network.http.use-cache"] = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = false;
            web.Navigate(URL_LOGIN);
            web.DocumentCompleted += new EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(web_DienMatKhau);
        }

        /// <summary>
        /// Thao tác điền tài khoản và mật khẩu vào chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void web_DienMatKhau(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            btnDangNhap.Enabled = true;

            try
            {
                web.DocumentCompleted -= web_DienMatKhau;

                var _input_Email = web.Document.GetElementsByName("email")[0];
                _input_Email.SetAttribute("value", txtUser.Text);

                var _input_Pass = web.Document.GetElementsByName("pass")[0];
                _input_Pass.SetAttribute("value", txtPass.Text);

                var _btn_login = (Gecko.DOM.GeckoButtonElement)web.Document.GetElementsByName("login")[0];
                _btn_login.Click();

                web.DocumentCompleted += new EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(web_DangNhapThanhCong);

            }
            catch (Exception)
            {

                web.Navigate("https://m.facebook.com/messages/");
            }


        }

        /// <summary>
        /// Sự kiện khi đăng nhập và chuyển đến trang danh sách tin nhắn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void web_DangNhapThanhCong(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            if (e.Uri.ToString().IndexOf("https://m.facebook.com/messages") == 0)
            {
                web.DocumentCompleted -= web_DangNhapThanhCong;
                tm_XoaNoiDung.Start();
                btnDangNhap.Enabled = false;
                txtUser.Enabled = false;
                txtPass.Enabled = false;
                btnDangNhap.Text = "Đã đăng nhập";
                groupDanhSach.Enabled = true;
            }
        }





        private void frmLogin2_Load(object sender, EventArgs e)
        {
            web.Navigate("about:blank");
            web2.Navigate("about:blank");
            var td = DateTime.Today.AddDays(1);
            txtTuLuc.Value = new DateTime(td.Year, td.Month, td.Day, 0, 0, 0);
            //td = td.AddYears(-1);
            txtDenLuc.Value = new DateTime(td.Year, td.Month, 1, 0, 0, 0);
        }



        private void tm_XoaNoiDung_Tick(object sender, EventArgs e)
        {
            //xóa header
            GeckoHtmlElement nodeHeader = (Gecko.GeckoHtmlElement)web.Document.SelectSingle("//div[@id='header']");
            if (nodeHeader != null) nodeHeader.ParentNode.RemoveChild(nodeHeader);
            //ẩn button soạn tin nhắn và khung tìm kiếm
            GeckoHtmlElement nodeButton = (Gecko.GeckoHtmlElement)web.Document.SelectFirst("//a[@data-sigil='touchable dialog-link']");
            if (nodeButton != null) nodeButton.ParentElement.ParentElement.SetAttribute("style", "display:none;");
            //ẩn các link folder tin nhắn
            GeckoHtmlElement nodeLink = (Gecko.GeckoHtmlElement)web.Document.SelectFirst("//div[@id='threadlist_rows']");
            if (nodeLink != null) ((Gecko.GeckoHtmlElement)nodeLink.NextSibling).SetAttribute("style", "display:none;");
            //ẩn button share 
            GeckoHtmlElement nodeButton2 = (Gecko.GeckoHtmlElement)web.Document.SelectFirst("//select[@class='selectBtn touchable']");
            if (nodeButton2 != null) nodeButton2.ParentElement.SetAttribute("style", "display:none;");
            //ẩn khung nhập nội dung form
            GeckoHtmlElement nodeForm = (Gecko.GeckoHtmlElement)web.Document.SelectFirst("//textarea");
            if (nodeForm != null) nodeForm.ParentElement.ParentElement.SetAttribute("style", "display:none;");
            //vô hiệu hóa link vào profile trong hộp chat
            GeckoElementCollection arrA = web.Document.GetElementsByTagName("a");
            foreach (GeckoElement a in arrA) if (a.GetAttribute("class") == "actor-link") a.SetAttribute("href", "#");

        }

        private void TrangThaiDangTai(bool st)
        {
            btnTinNhanDen.Enabled = st;
            btnDangCho.Enabled = st;
            btnDaLoc.Enabled = st;
            btnLuuTru.Enabled = st;
            btnSpam.Enabled = st;
            //txtTuLuc.Enabled = st;
            //txtDenLuc.Enabled = st;
            //chkTaiTextDuyNhat.Enabled = st;
            //chkImgOffline.Enabled = st;
            //btnKetXuat.Enabled = st;
        }

        private void btnLoadTinNhan_Click(object sender, EventArgs e)
        {
            if (btnLoadTinNhan.Text == "Tải tin nhắn")
            {
                if (txtTuLuc.Checked && txtDenLuc.Checked && txtDenLuc.Value >= txtTuLuc.Value)
                {
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Khoảng thời gian không hợp lệ!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TrangThaiDangTai(false);

                tabMain.SelectedIndex = 1;

                btnLoadTinNhan.Text = "Dừng hoạt động";
                web2.Document.Body.InnerHtml = "";
                GeckoHtmlElement divRoot = web2.Document.CreateHtmlElement("div");
                web2.Document.Body.AppendChild(divRoot);
                string style = "<style type='text/css'>";
                style += ".msg{padding:5px;font-size:15px;color:#34495e;}";
                style += ".user{border-top:1px solid #e5e5e5;margin-top:10px;padding-bottom:10px;padding-top:10px;font-size:16px;color:#2980b9;}";
                style += ".time{margin-left:10px;font-style:italic;font-size:13px;color:#666;}";
                style += ".time2{font-style:italic;font-size:15px;color:#999;margin-right:5px;float:left;}";
                style += "</style>";
                web2.Document.Head.InnerHtml = style;

                if (txtTuLuc.Checked)
                {
                    double tuluc = (txtTuLuc.Value.AddHours(-7) - new DateTime(1970, 1, 1)).TotalMilliseconds;
                    web.Navigate(web.Url.ToString() + "&last_message_timestamp=" + tuluc.ToString());
                    web.DocumentCompleted += new EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(web_BatDauLoadTinNhan);
                }
                else
                {
                    BatDauLoadTinNhan();
                }
            }
            else
            {
                btnLoadTinNhan.Text = "Tải tin nhắn";
                isDangXuLyTinNhan = false;
                divLoadMore = null;
                TrangThaiDangTai(true);
                tm_XuLyTinNhan.Stop();
            }


        }

        void web_BatDauLoadTinNhan(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            web.DocumentCompleted -= web_BatDauLoadTinNhan;
            BatDauLoadTinNhan();
        }



        private bool isDangXuLyTinNhan;
        GeckoAnchorElement divLoadMore;
        private void BatDauLoadTinNhan()
        {
            //web.Reload();
            divLoadMore = (GeckoAnchorElement)web.Document.SelectFirst("//a[@class='touchable primary']");
            tm_XuLyTinNhan.Start();
            while (divLoadMore != null)
            {
                Application.DoEvents();
                isDangXuLyTinNhan = true;
                divLoadMore.Click();
                divLoadMore = (GeckoAnchorElement)web.Document.SelectFirst("//a[@class='touchable primary']");
                while (isDangXuLyTinNhan)
                {
                    Application.DoEvents();
                }
            }


            btnLoadTinNhan.Text = "Tải tin nhắn";
            isDangXuLyTinNhan = false;
            divLoadMore = null;
            TrangThaiDangTai(true);
            tm_XuLyTinNhan.Stop();

            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Đã load hết nội dung tin nhắn!");
        }



        private void tm_XuLyTinNhan_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();

            try
            {
                GeckoHtmlElement nodeRoot = (Gecko.GeckoHtmlElement)web.Document.SelectFirst("//div[@class='voice acw abt'][last()]");
                if (nodeRoot == null)
                {
                    isDangXuLyTinNhan = false;
                    return;
                }

                GeckoHtmlElement divMsg = web2.Document.CreateHtmlElement("div");

                string html = "";

                var user = nodeRoot.GetElementsByTagName("strong").Where(n => n.GetAttribute("class") == "actor").FirstOrDefault();
                if (user != null)
                {
                    html += "<div class='user'><b>" + user.TextContent + "</b>";
                    var timeSpan = nodeRoot.GetElementsByTagName("abbr").FirstOrDefault();
                    if (timeSpan != null) html += "<span class='time'>(" + timeSpan.TextContent + ")</span>";
                    html += "</div>";

                }

                var mess = nodeRoot.GetElementsByTagName("div").Where(n => n.GetAttribute("data-sigil") == "message-text");

                bool isTiepTuc = true;

                foreach (GeckoHtmlElement m in mess)
                {
                    Application.DoEvents();
                    isTiepTuc = true;
                    if (chkImgOffline.Checked)
                    {
                        var arrImg = m.GetElementsByTagName("img");
                        foreach (GeckoImageElement _img in arrImg)
                        {
                            string strBase64 = ImageToBase64(_img);
                            if (strBase64 != "") _img.SetAttribute("src", "data:image/png;base64," + strBase64);
                        }

                    }

                    Regex r = new Regex("timestamp&quot;:(.*?),", RegexOptions.Multiline);
                    Match mt = r.Match(m.OuterHtml);
                    string _str_time = "";
                    if (mt.Success)
                    {
                        DateTime tSS = SecondToDateTime(mt.Groups[1].Value.ToString());
                        _str_time = tSS.ToString("HH:mm");
                        if (txtDenLuc.Checked && tSS < txtDenLuc.Value)
                        {
                            isTiepTuc = false;
                        }
                    }

                    if (chkTaiTextDuyNhat.Checked)
                    {
                        if (m.TextContent.Trim() != "")
                        {
                            html += "<div class='msg'><span class='time2'>" + _str_time + "</span>" + m.TextContent + "</div>";
                        }
                    }
                    else
                    {
                        html += "<div class='msg'><span class='time2'>" + _str_time + "</span>" + m.InnerHtml + "</div>";
                    }


                }

                divMsg.InnerHtml = "<div>" + html + "</div>";

                web2.Document.Body.InsertBefore(divMsg, web2.Document.Body.ChildNodes[0]);


                nodeRoot.ParentNode.RemoveChild(nodeRoot);

                if (!isTiepTuc)
                {
                    btnLoadTinNhan.Text = "Tải tin nhắn";
                    isDangXuLyTinNhan = false;
                    divLoadMore = null;
                    TrangThaiDangTai(true);
                    tm_XuLyTinNhan.Stop();
                }
            }
            catch (Exception)
            {

              
            }





        }

        public DateTime SecondToDateTime(string strSeconds)
        {
            try
            {
                double _timespan = 0;
                double.TryParse(strSeconds, out _timespan);
                return new DateTime(1970, 1, 1, 0, 0, 0).Add(TimeSpan.FromMilliseconds(_timespan)).AddHours(7);
            }
            catch (Exception)
            {
                return new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            }
        }

        public string ImageToBase64(GeckoImageElement _img)
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    byte[] data = web.DownloadData(_img.GetAttribute("src"));
                    string base64String = Convert.ToBase64String(data);
                    return base64String;
                }
            }
            catch (Exception)
            {
                try
                {
                    Rectangle rect = _img.GetBoundingClientRect();
                    using (Bitmap image = Gecko.Utils.WindowsImageCreator.GetBitmap(web, (uint)rect.X, (uint)rect.Y, (uint)_img.ClientWidth, (uint)_img.ClientHeight))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            image.Save(ms, image.RawFormat);
                            byte[] imageBytes = ms.ToArray();
                            string base64String = Convert.ToBase64String(imageBytes);
                            return base64String;
                        }
                    }
                }
                catch (Exception)
                {
                    return "";
                }
            }

        }

        private void btnTinNhanDen_Click(object sender, EventArgs e)
        {
            web.Navigate("https://m.facebook.com/messages/");
        }

        private void btnDangCho_Click(object sender, EventArgs e)
        {
            web.Navigate("https://m.facebook.com/messages/?folder=pending");
        }

        private void btnDaLoc_Click(object sender, EventArgs e)
        {
            web.Navigate("https://m.facebook.com/messages/?folder=other");
        }

        private void btnLuuTru_Click(object sender, EventArgs e)
        {
            web.Navigate("https://m.facebook.com/messages/?folder=archived");
        }

        private void btnSpam_Click(object sender, EventArgs e)
        {
            web.Navigate("https://m.facebook.com/messages/?folder=spam");
        }

        private void btnKetXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "HTML File|*.html";
            save.Title = "Lưu file nội dung chat";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                web2.SaveDocument(save.FileName);
                if (ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Đã lưu file, bạn có muốn mở file đó không?", "Chú ý!"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(save.FileName);
                }
            }

        }

        private void btnDongChuongTrinh_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin2_FormClosing(object sender, FormClosingEventArgs e)
        {
            isDangXuLyTinNhan = false;
            divLoadMore = null;
            tm_XoaNoiDung.Stop();
            tm_XuLyTinNhan.Stop();
            Application.Exit();
        }

        private void linkWeb_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(linkWeb.Text);
        }

        private void linkFb_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(linkFb.Text);
        }



    }
}