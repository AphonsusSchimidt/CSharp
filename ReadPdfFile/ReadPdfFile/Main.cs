using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace ReadPdfFile
{
    public partial class frmMain : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();        

        public frmMain()
        {
            InitializeComponent();

            btnBrowse.Click += btnBrowse_Click;
            Load += frmMain_Load;
        }

        void frmMain_Load(object sender, EventArgs e)
        {
            this.openFile.RestoreDirectory = true;
            this.openFile.FileName = string.Empty;
            this.openFile.Filter = "Pdf Files (.pdf)|*.pdf|All Files (*.*)|*.*";
            this.openFile.FilterIndex = 1;
            this.openFile.Multiselect = false;
        }

        void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFile.FileName;
                rtbcontent.Clear();

                using (PdfReader reader = new PdfReader(openFile.FileName))
                {
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        LocationTextExtractionStrategy strategy = new LocationTextExtractionStrategy();
                        string line = PdfTextExtractor.GetTextFromPage(reader, i);
                        line = Encoding.UTF8.GetString(
                            Encoding.Convert(
                            Encoding.Default, 
                            Encoding.UTF8, 
                            Encoding.Default.GetBytes(line)));
                        rtbcontent.Text += line;
                    }

                    List<string> ls = new List<string>();
                    ls = Regex.Split(rtbcontent.Text, "\n").ToList();
                }
            }
        }
    }
}
