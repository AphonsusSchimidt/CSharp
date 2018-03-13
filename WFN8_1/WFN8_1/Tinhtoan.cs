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
    public partial class Tinhtoan : Form
    {
        public Tinhtoan()
        {
            InitializeComponent();
        }
        private bool CheckNumberTextbox(TextBox tb,out int so)
        {
            so = 0;
            bool ok = int.TryParse(tb.Text, out so);
            if (ok)
                return true;
            else
            {
                MessageBox.Show("Cần phải nhập số!");
                tb.Focus();
                return false;
            }
        }
        private void Tinh(object sender, EventArgs e)
        {
            int sh1, sh2;
            if (!CheckNumberTextbox(textBox1, out sh1)) return;
            else if (!CheckNumberTextbox(textBox2, out sh2)) return;
            else
            {
                Button bt = (Button)sender;
                string pheptinh = bt.Text;
                switch (pheptinh)
                {
                    case "+": textBox3.Text = (sh1 + sh2).ToString(); break;
                    case "-": textBox3.Text = (sh1 - sh2).ToString(); break;
                    case "x": textBox3.Text = (sh1 * sh2).ToString(); break;
                    case "/":
                        if (sh2 == 0)
                        {
                            MessageBox.Show("Lỗi phép chia cho số 0");
                            textBox2.Focus();
                        }
                        else
                            textBox3.Text = (sh1 / (sh2 * 1.0)).ToString(); break;
                }
            }
        }
    }
}
