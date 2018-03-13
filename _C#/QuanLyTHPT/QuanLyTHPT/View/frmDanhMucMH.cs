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
            Hienthi(_Query);
            grbTimKiem.Visible = false;
            cbbType.SelectedIndex = 0;
        }
        int CurCl = 0, CurR = 0;
        private string _Query = "select * from MonHoc";
        public void Hienthi(string _Query)
        {
            DataTable dt = sqlHelper.Query(_Query);
            dtgrv.DataSource = dt;
            dtgrv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaMon"].ColumnName = "Mã Môn Học";
            dt.Columns["TenMon"].ColumnName = "Tên Môn Học";
            dt.Columns["HeSo"].ColumnName = "Hệ Số";
            foreach (DataGridViewColumn col in dtgrv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dtgrv.CurrentCell = dtgrv[CurCl, CurR];

            dtgrv.Refresh();
        }

        string IDmember;

        MonHocController Mhc;
        InputHelper iph = new InputHelper();
        private void btnThem_Click(object sender, EventArgs e)
        {
            Mhc = new MonHocController();

            if (!Mhc.CheckErr(txtMaMon.Text.Trim(), txtTenMonHoc.Text.Trim(), txtHeSo.Text.Trim()))
            {
                return;
            }
            if (Mhc.ThemMH(txtMaMon.Text, txtTenMonHoc.Text, txtHeSo.Text))
            {
                MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Hienthi(_Query);
            dtgrv.Refresh();
        }

        private void frmDanhMucMH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Mhc = new MonHocController();
            if (!Mhc.CheckErr(txtMaMon.Text.Trim(), txtTenMonHoc.Text.Trim(), txtHeSo.Text.Trim()))
            {
                return;
            }
            if (Mhc.SuaMH(txtMaMon.Text, txtTenMonHoc.Text, txtHeSo.Text, IDmember))
            {
                MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Hienthi(_Query);
            dtgrv.Refresh();
        }

        private void dtgrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Text = ""; txtTenMonHoc.Text = ""; txtHeSo.Text = "";
            IDmember = dtgrv.CurrentRow.Cells[0].Value.ToString();
            //myvalue =dgvList.Rows[rowindex].Cells[columnindex].Value.ToString();
            CurCl = dtgrv.CurrentCell.ColumnIndex;
            CurR = dtgrv.CurrentCell.RowIndex;
            txtMaMon.Text = dtgrv.CurrentRow.Cells[0].Value.ToString();
            txtTenMonHoc.Text = dtgrv.CurrentRow.Cells[1].Value.ToString();
            txtHeSo.Text = dtgrv.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Mhc = new MonHocController();
            string s = string.Format("Do you want delete data? with Mã Môn là: {0}", IDmember);

            if (IDmember == null)
            {
                MessageBox.Show("No Select!!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show(s, "Xóa Dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Mhc.XoaMH(IDmember))
                    {
                        MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Hienthi(_Query);
                }
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
                cbbType.SelectedIndex = 1;
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
            _Query = timkiem;
            Hienthi(_Query);
            dtgrv.Refresh();
            try { dtgrv.CurrentCell = dtgrv[CurCl, CurR]; }
            catch { }


        }

        private void btnTimKiemGr_Click(object sender, EventArgs e)
        {

        }

       

        private void rsData_Click_1(object sender, EventArgs e)
        {
            _Query = "select * from MonHoc";
            txtMaMon.Text = "";
            txtTenMonHoc.Text = "";
            txtHeSo.Text = "";
            txtTimKiem.Text = "";
            grbTimKiem.Visible = false;
            Hienthi(_Query);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
