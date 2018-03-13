using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegTinChi
{
    public partial class web3 : Form
    {
        public web3()
        {
            InitializeComponent();
        }

        private void web12_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void web3_Load(object sender, EventArgs e)
        {
           // web12.Document.Cookie = "ASPSESSIONIDCSSACCSB=AMKDDHADOJPGIENEOBOMKHIC";
            web12.Navigate("http://220.231.117.235/ListPoint/listpoint_Brc1.asp");
        }
    }
}
