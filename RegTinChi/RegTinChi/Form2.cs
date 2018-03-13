using Gecko;
using Gecko.DOM;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RegTinChi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ThuVien.XoaCookie();
            //view morre --https://developer.mozilla.org/en-US/docs/Mozilla/Preferences
            GeckoPreferences.User["intl.accept_languages"] = "vi";
            GeckoPreferences.User["accept-language"] = "vi,en-US;q=0.8,en;q=0.6";
            GeckoPreferences.User["general.useragent.override"] = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36";
            btnDk.Visible = false;
        }
        public string URL_LOGIN = "http://220.231.117.235/dkmh/login.asp";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //txtUsename.Text = "15150136";
            //txtPass.Text = "25081995a7";
            web1.Navigate(URL_LOGIN);
            web1.DocumentCompleted += new EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(web_DienMatKhau); 
            }
        string cookiesText = "";
        void web_DienMatKhau(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
           
            btnLogin.Enabled = true;
            try
            {
                web1.DocumentCompleted -= web_DienMatKhau;

                var _input_Email = web1.Document.GetElementsByName("txtLoginId")[0];
                _input_Email.SetAttribute("value", txtUsename.Text);

                var _input_Pass = web1.Document.GetElementsByName("txtPassword")[0];
                _input_Pass.SetAttribute("value", txtPass.Text);

                GeckoInputElement enter = (GeckoInputElement)web1.Document.GetElementsByTagName("INPUT")
    .First(inp => ((GeckoInputElement)inp).Value == "Đăng nhập");
                enter.Click();
                web1.DocumentCompleted += new EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(web_DangNhapThanhCong);
               
                var uri = new Uri(URL_LOGIN);
                //often cookies are stored on domain level, so ".google.com", not "www.google.com" (leading dot is important)
                string host = uri.Host.Replace("www", "");
                var cookies = CookieManager.GetCookiesFromHost(host);


                while (cookies.MoveNext())
                {
                    var c = cookies.Current;
                    cookiesText += c.Name + "=" + c.Value + ";";
                } 
            }
            catch (Exception)
            {
                web1.Navigate(URL_LOGIN);
            }
        }
        void web_DangNhapThanhCong(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            if (e.Uri.ToString().IndexOf("http://220.231.117.235/dkmh/default.asp") == 0)
            {
                web1.DocumentCompleted -= web_DangNhapThanhCong;
                btnLogin.Enabled = false;
                txtUsename.Enabled = false;
                txtPass.Enabled = false;
                btnLogin.Text = "Đã đăng nhập";
                btnDk.Visible = true;    
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
 
        private void btnDk_Click(object sender, EventArgs e)
        {
              //web1.Navigate("http://seakbz.tk/giphy.gif");
            web1.Navigate("http://220.231.117.235/ListPoint/listpoint_Brc1.asp");

            GeckoHtmlElement CSS = web1.Document.GetElementsByTagName("TABLE")[0];
            CSS.SetAttribute("style", "background: red;");
            //if(web1.Url.ToString()== "http://220.231.117.235/dkmh/error.asp")
            //{
            //    txtUsename.Text = "15150136";
            //    txtPass.Text = "25081995a7";
            //    web1.Navigate(URL_LOGIN);
            //    web1.DocumentCompleted += new EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(web_DienMatKhau);

            //}
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
    }
}
