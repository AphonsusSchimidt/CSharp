using QuanLyHocSinhTHPT.Controller;
using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.View.VGiaoVien
{
    public partial class frmGaioVien : DevExpress.XtraEditors.XtraForm
    {
        int CurCl = 0, CurR = 0;
        private string _Query = "select * from GiaoVien";
        string IDmember;
        public frmGaioVien()
        {
            InitializeComponent();
            DataTable dt = sqlHelper.Query(_Query);
            Hienthi(dt);
        }
        public int GetTongSobanGhi(string s)
        {
            DataTable dt = sqlHelper.Query(s);
            return dt.Rows.Count;
        }
        
        public void Hienthi(List<GiaoVien> lst)
        {
            dtgrv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrv.DataSource = lst;
            dtgrv.Refresh();
        }
        public void Hienthi(DataTable dt)
        {
            
            dtgrv.DataSource = dt;
            dtgrv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaGV"].ColumnName = "Mã Giáo Viên";
            dt.Columns["HoTen"].ColumnName = "Họ Tên";
            dt.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
            dt.Columns["GioiTinh"].ColumnName = "Giới Tính (Nữ ✓/nam)";
            dt.Columns["Sdt"].ColumnName = "Số Điện Thoại";
            dt.Columns["QueQuan"].ColumnName = "Quê quán";
            foreach (DataGridViewColumn col in dtgrv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            try { dtgrv.CurrentCell = dtgrv[CurCl, CurR]; } catch { }
            lblTongSL.Text = GetTongSobanGhi("select * from GiaoVien").ToString();
            dtgrv.Refresh();
        }
       
    
        private void dtgrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgrv.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgrv.CurrentCell.ColumnIndex;
            CurR = dtgrv.CurrentCell.RowIndex;
           
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(IDmember==null)
            {
                MessageBox.Show("No Select!!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            VGiaoVien.frmThaoTacGV frm = new frmThaoTacGV(IDmember);
            frm.ShowDialog();
            DataTable dt = sqlHelper.Query(_Query);
            Hienthi(dt);
        }

        private void sobanGhi_TextChanged(object sender, EventArgs e)
        {

            int sobanghi;
            if (sobanGhi.Text.Trim() == "")
            {
                sobanghi = 10;
                _Query = string.Format("select TOP {0} * from GiaoVien ", sobanghi);
                DataTable tb = sqlHelper.Query(_Query);
                Hienthi(tb);
                return;
            }
            if (!int.TryParse(sobanGhi.Text.Trim(), out sobanghi))
            {
                MessageBox.Show("Sai Định Dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            _Query = string.Format("select TOP {0} * from GiaoVien ", sobanghi);
            DataTable dt = sqlHelper.Query(_Query);
            Hienthi(dt);  

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IDmember == null)
            {
                MessageBox.Show("No Select!!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmXoaGV frmXoa = new frmXoaGV(IDmember);
            frmXoa.ShowDialog();
            DataTable dt = sqlHelper.Query(_Query);
            Hienthi(dt);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VGiaoVien.frmThaoTacGV frm = new frmThaoTacGV(null);
            frm.ShowDialog();
            DataTable dt = sqlHelper.Query(_Query);
            Hienthi(dt);
        }

       
    }
}
