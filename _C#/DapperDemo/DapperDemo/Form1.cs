using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //var
        private List<HocSinh> listHS = DapperService.getAllData();

        private int CurCl = 0, CurR = 0;
        private string _Query = "select * from HocSinh";
        private string IDmember;
        private string MaHS = "";
        private string HoTen = "";
        private string QueQuan = "";
        private bool GioiTinh = false;
        private DateTime NgaySinh = DateTime.Now;
        private string TenBo = "";
        private string TenMe = "";
        private string MaLop = "";

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listHS;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CurCl = dataGridView1.CurrentCell.ColumnIndex;
            CurR = dataGridView1.CurrentCell.RowIndex;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            frmHocSinh frmThem = new frmHocSinh("", "", "", true, dt, "", "", "", 1);
            frmThem.ShowDialog();
        }

        private void btnUpadte_Click(object sender, EventArgs e)
        {
            if (IDmember == null)
            {
                MessageBox.Show("No Select!!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int i = CurR;
                MaHS = listHS[i].MaHS;
                HoTen = listHS[i].HoTen;
                QueQuan = listHS[i].QueQuan;
                if (listHS[i].GioiTinh == "Nữ")
                    GioiTinh = true;
                else
                    GioiTinh = false;
                NgaySinh = DateTime.Parse(listHS[i].NgaySinh);
                TenBo = listHS[i].TenMe;
                TenMe = listHS[i].TenBo;
                MaLop = listHS[i].MaLop;
                frmHocSinh frmThem = new frmHocSinh(MaHS, HoTen, QueQuan, GioiTinh, NgaySinh, TenBo, TenMe, MaLop, 2);
                frmThem.ShowDialog();
            }
        }
    }
}