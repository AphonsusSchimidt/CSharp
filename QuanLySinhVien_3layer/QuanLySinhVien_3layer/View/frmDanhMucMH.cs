using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien_3layer.Helper;
using QuanLySinhVien_3layer.Models;

namespace QuanLySinhVien_3layer.View
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
            dtgrv.DataSource = dt;
            dtgrv.Refresh();
        }
        List<MonHoc> lstMonHoc = new List<MonHoc>();
        int IDmember;




        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtTenMonHoc.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtHeSo.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            string str = string.Format("INSERT INTO MonHoc values ('{0}',N'{1}', {2})", txtMaMon.Text, txtTenMonHoc.Text, txtHeSo.Text);
            MonHoc monhoc = new MonHoc(txtMaMon.Text, txtTenMonHoc.Text, double.Parse(txtHeSo.Text));
            sqlHelper.NonQuery(str);
            Hienthi();
            dtgrv.Refresh();
        }

        private void frmDanhMucMH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string str = string.Format("update MonHoc set maMon={0},tenMon=N'{1}',heSo={2} where maMon={3}",
                txtMaMon.Text, txtTenMonHoc.Text, txtHeSo.Text, IDmember);
            sqlHelper.NonQuery(str);
            Hienthi();
            dtgrv.Refresh();
        }

        private void dtgrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Text = ""; txtTenMonHoc.Text = ""; txtHeSo.Text = "";
            IDmember = int.Parse(dtgrv.CurrentRow.Cells[0].Value.ToString());
            txtMaMon.Text = dtgrv.CurrentRow.Cells[0].Value.ToString();
            txtTenMonHoc.Text = dtgrv.CurrentRow.Cells[1].Value.ToString();
            txtHeSo.Text = dtgrv.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want delete data?", "Note", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string str = string.Format("delete from MonHoc  Where maMon ={0}", IDmember);
                sqlHelper.NonQuery(str);
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
        // dtgrv.Refresh();
    }
}
