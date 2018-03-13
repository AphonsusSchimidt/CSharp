using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFN8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abc_MouseHover(object sender, EventArgs e)
        {
            abc.Text = "Chuoi di den";
        }

        private void abc_MouseLeave(object sender, EventArgs e)
        {
            abc.Text = "Chuoi roi di";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void abc_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            int so = int.Parse(txt);
            MessageBox.Show((so * so).ToString());
            label1.Text = string.Format("Ket qua cua {0} la {1}", so, so * so);
        }

    }
}
