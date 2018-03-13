using Gecko;
using Gecko.DOM;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RegTinChi
{
    public partial class frmMain : Form
    {
        public string URL_LOGIN = "https://m.facebook.com/login/?next=https://m.facebook.com/messages/";
        public frmMain()
        {
            InitializeComponent();
            ThuVien.XoaCookie();
            //view morre --https://developer.mozilla.org/en-US/docs/Mozilla/Preferences
            GeckoPreferences.User["intl.accept_languages"] = "vi";
            GeckoPreferences.User["accept-language"] = "vi,en-US;q=0.8,en;q=0.6";
            GeckoPreferences.User["general.useragent.override"] = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36";
            web1.Navigate("https://m.facebook.com/");
        }
     
        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsename.Text = "sea.kbz";
            txtPass.Text = "sea.kBz.18..09";
            web1.Navigate(URL_LOGIN);
            web1.DocumentCompleted += new EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(web_DienMatKhau); 
            }
      
        void web_DienMatKhau(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
         
            btnLogin.Enabled = true;
            try
            {
                
                web1.DocumentCompleted -= web_DienMatKhau;

                var _input_Email = web1.Document.GetElementsByName("email")[0];
                _input_Email.SetAttribute("value", txtUsename.Text);

                var _input_Pass = web1.Document.GetElementsByName("pass")[0];
                _input_Pass.SetAttribute("value", txtPass.Text);

                var _btn_login = (Gecko.DOM.GeckoButtonElement)web1.Document.GetElementsByName("login")[0];
                _btn_login.Click();

                web1.DocumentCompleted += new EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(web_DangNhapThanhCong);
             
            }
            catch
            {

            }
        }
        void web_DangNhapThanhCong(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
          
            if (e.Uri.ToString().IndexOf("https://m.facebook.com/messages/") == 0)
            {
                web1.Show();
                web1.DocumentCompleted -= web_DangNhapThanhCong;
                btnLogin.Enabled = false;
                txtUsename.Enabled = false;
                txtPass.Enabled = false;
                btnLogin.Text = "Đã đăng nhập";
                 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
 
        private void btnDk_Click(object sender, EventArgs e)
        {
             
           
        }

        private void btnDk_Click_1(object sender, EventArgs e)
        {  web1.Navigate("http://seakbz.tk/giphy.gif");
          //  web1.Navigate("http://220.231.117.235/ListPoint/listpoint_Brc1.asp",GeckoLoadFlags.);

            GeckoHtmlElement CSS = web1.Document.GetElementsByTagName("TABLE")[0];
            CSS.SetAttribute("style", "background: red;");
            if (web1.Url.ToString() == "http://220.231.117.235/dkmh/error.asp")
            {
                txtUsename.Text = "15150136";
                txtPass.Text = "25081995a7";
                web1.Navigate(URL_LOGIN);
                web1.DocumentCompleted += new EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(web_DienMatKhau);

            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            txtUsename.Enabled = true;
            txtPass.Enabled = true;
         
          web1.Navigate("https://m.facebook.com/");
            btnLogin.Text = "Login";
        }

        private void dm_Click(object sender, EventArgs e)
        {
            var _input_Chui = web1.Document.GetElementById("composerInput");
            _input_Chui.SetAttribute("placeholder", txtdm.Text);


            var _btn_dm = (Gecko.DOM.GeckoButtonElement)web1.Document.GetElementsByName("Send")[0];
            _btn_dm.Click();
        }

   

    }
}
