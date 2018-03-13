using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoTool
{
    public partial class Form1 : Form
    {
        Gecko.GeckoWebBrowser web;
        public Form1()
        {
            InitializeComponent();
        }

        public void Xuly()
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            web = new Gecko.GeckoWebBrowser();
            // web.Navigate("https://onlinevideoconverter.com/video-converter");
            WebBrowser web2 = new WebBrowser();
            web2.Navigate("https://onlinevideoconverter.com/video-converter");
            string a = cbAudioFm.SelectedItem.ToString().Substring(1);
            web.DocumentCompleted += new EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(LayThongTin);   
           
        }
        void LayThongTin(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            try
            {
                web.DocumentCompleted -= LayThongTin;
                var _input_Url = web.Document.GetElementsByName("texturl")[0];
                _input_Url.SetAttribute("value", txtUrl.Text);
                var _input_Fomat = web.Document.GetElementById("select_main");
                _input_Fomat.SetAttribute("data-value", cbAudioFm.SelectedIndex.ToString());
                var _btn_start = (Gecko.DOM.GeckoButtonElement)web.Document.GetElementById("convert1");
                _btn_start.Click();
                web.DocumentCompleted += new EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(ThanhCong);
            }
            catch
            {

            }
        }
        void ThanhCong(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            MessageBox.Show("Thành công");
        }
    }
}
