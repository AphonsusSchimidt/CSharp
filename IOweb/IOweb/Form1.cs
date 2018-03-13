using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace IOweb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = ("(PDF File)|*.pdf");
            of.ShowDialog();
            txtLink.Text = of.FileName;
            if(of.FileName!="")
            {
                List<string> type = new List<string>() ;
                type.Add("S");
                type.Add("S");
                type.Add("S");
                type.Add("I");
                type.Add("S");
                object obj = new object();
                List<HS> listHs = ReadPdf.GetDataByPdf(of.FileName,type, "Candidate name", "Place of entry", "Result", "Overall Score", "CEFR Level");
                dtgr1.DataSource = null;          
                dtgr1.DataSource = listHs;
                dtgr1.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("No file select", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
