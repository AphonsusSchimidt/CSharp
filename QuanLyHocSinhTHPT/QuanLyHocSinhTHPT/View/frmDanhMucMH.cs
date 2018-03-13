using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;
using QuanLyHocSinhTHPT.Controller;
using System.Globalization;

namespace QuanLyHocSinhTHPT.View
{
    public partial class frmDanhMucMH : Form
    {
        public DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode { get; set; }
        public frmDanhMucMH()
        {
            InitializeComponent();
            Hienthi();
            grbTimKiem.Visible = false;
            cbbType.SelectedIndex = 0;
        }
        public void Hienthi()
        {
            DataTable dt = sqlHelper.Query("select * from MonHoc");
            MonHoc mh = new MonHoc();
            dtgrv.DataSource = dt;
            dtgrv.Refresh();
        }
        List<MonHoc> lstMonHoc = new List<MonHoc>();
        string  IDmember;
       
        MonHocController Mhc = new MonHocController();
        InputHelper iph = new InputHelper();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtTenMonHoc.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtHeSo.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

           
            if (Mhc.ThemMH(txtMaMon.Text, txtTenMonHoc.Text, float.Parse(txtHeSo.Text)))
            {
                MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Hienthi();
            dtgrv.Refresh();
        }

        private void frmDanhMucMH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            float heso = float.Parse(txtHeSo.Text,CultureInfo.InvariantCulture.NumberFormat);

            //string query = string.Format("update MonHoc set MaMon='{0}',TenMon=N'{1}',HeSo='{2}' where MaMon='{3}'",
            //    txtMaMon.Text, txtTenMonHoc.Text, heso, IDmember);
            string str = string.Format("update MonHoc set MaMon={0},TenMon=N'{1}',HeSo={2} where MaMon='{3}'",
              txtMaMon.Text, txtTenMonHoc.Text, txtHeSo.Text, IDmember);
            sqlHelper.NonQuery(str);
         
            //if (sqlHelper.NonQuery(query))
            //    if (Mhc.SuaMH(txtMaMon.Text, txtTenMonHoc.Text, heso, IDmember)==true)
            //{
            //    MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}else
            //{
            //    MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            Hienthi();
            dtgrv.Refresh();
        }

        private void dtgrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Text = ""; txtTenMonHoc.Text = ""; txtHeSo.Text = "";
            IDmember = dtgrv.CurrentRow.Cells[0].Value.ToString();
            txtMaMon.Text = dtgrv.CurrentRow.Cells[0].Value.ToString();
            txtTenMonHoc.Text = dtgrv.CurrentRow.Cells[1].Value.ToString();
            txtHeSo.Text = dtgrv.CurrentRow.Cells[2].Value.ToString();  
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want delete data?", "Note", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Mhc.XoaMH(IDmember);              
                Hienthi();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           
            grbTimKiem.Visible = true;
            if (txtTimKiem.Text == "") { return; }
            string timkiem = "";
            if (txtTimKiem.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (cbbType.SelectedIndex == 1)
            {
                
                timkiem = string.Format("select *from MonHoc where tenMon=N'{0}'", txtTimKiem.Text.Trim());
                cbbType.SelectedIndex =1;
            }
            else if (cbbType.SelectedIndex == 2)
            {
                timkiem = string.Format("select *from MonHoc where heSo={0}", txtTimKiem.Text);
                cbbType.SelectedIndex = 2;
            }
            else
            {
                timkiem = string.Format("select *from MonHoc where maMon='{0}'", txtTimKiem.Text);
            }
            DataTable tk = sqlHelper.Query(timkiem);
            dtgrv.DataSource = tk;
            dtgrv.Refresh();

        }

        private void btnTimKiemGr_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
