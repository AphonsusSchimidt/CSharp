using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Notpate
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(Text File)|*.txt";
            ofd.ShowDialog();
            if (ofd.FileName == "")
            {
                MessageBox.Show("No file select", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StreamReader srd = new StreamReader(ofd.FileName);
                while (!srd.EndOfStream)
                {
                    string l = srd.ReadLine();
                    rtbView.Text += l + "\n";
                }
                srd.Close();
            }
            
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuWordWrap_Click(object sender, EventArgs e)
        {
            mnuWordWrap.Checked = true;
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            rtbView.Text = "";
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(Text File)|*.txt";
            sfd.ShowDialog();
            if(sfd.FileName=="")
            {
                MessageBox.Show("Don't Save", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





    }
}
