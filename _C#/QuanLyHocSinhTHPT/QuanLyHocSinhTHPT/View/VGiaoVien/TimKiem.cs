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
    public partial class TimKiem : DevExpress.XtraEditors.XtraForm
    {
        DataGridView dt;
        public TimKiem(DataGridView _dt)
        {
            InitializeComponent();
            dt = _dt;
            cbtype.SelectedIndex = 1;
           
        }
        public DataTable KqTK(DataGridView dt)
        {
            DataTable tb = new DataTable();
            Controller.HocSinhController hs = new Controller.HocSinhController();
            tb = hs.Timkiem(cbtype.SelectedIndex, txtInPutTk.Text.Trim());
            if (tb.Rows.Count > 0)
            {
                dt.DataSource = tb;
                dt.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tb.Columns["MaHS"].ColumnName = "Mã Học Sinh";
                tb.Columns["HoTen"].ColumnName = "Họ Tên";
                tb.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
                tb.Columns["GioiTinh"].ColumnName = "Giới Tính (Nữ ✓/nam)";
                tb.Columns["TenBo"].ColumnName = "Tên Bố";
                tb.Columns["TenMe"].ColumnName = "Tên Mẹ";
                tb.Columns["MaLop"].ColumnName = "Mã Lớp";
                foreach (DataGridViewColumn col in dt.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }
            }
            return tb;
        }

        private void btnSubmitTk_Click(object sender, EventArgs e)
        {
            KqTK(dt);
        }
    }
}
