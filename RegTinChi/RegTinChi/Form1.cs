using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
namespace RegTinChi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLoad_Click(object sender, EventArgs e)
        {
            HtmlWeb _htmlweb = new HtmlWeb();
            _htmlweb.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36";
            string _url = TxtLink.Text;

            HtmlAgilityPack.HtmlDocument _htmlRead = _htmlweb.Load(_url);
            richTextBox1.Text = _htmlRead.DocumentNode.InnerHtml;


            //--------------------------
           



        }
    }
}
