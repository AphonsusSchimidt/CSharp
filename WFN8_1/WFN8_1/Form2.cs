using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFN8_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                textBox1.Text = path;
                richTextBox1.Text = "";
                StreamReader sr = new StreamReader(path);
                while(!sr.EndOfStream)
                {
                    string l = sr.ReadLine();
                    richTextBox1.Text += l + "\n";
                }
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Notice!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StreamWriter sw = new StreamWriter(textBox1.Text, false);
                foreach (string s in richTextBox1.Lines)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
                MessageBox.Show("Saved.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName, false);
                foreach (string s in richTextBox1.Lines)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
                MessageBox.Show("Saved.");
            }
        }
    }
}
