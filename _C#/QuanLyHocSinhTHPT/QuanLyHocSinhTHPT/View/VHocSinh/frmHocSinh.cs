using QuanLyHocSinhTHPT.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.View.VHocSinh
{
    public partial class frmHocSinh : DevExpress.XtraEditors.XtraForm
    {
        Models.HocSinhController hocsinhController;
        int  S,page=1,count=15;
        int record=15,all;
        public int GetTongSobanGhi()
        {
            hocsinhController = new Models.HocSinhController();
            return hocsinhController.Get(0, 1000).Count;
        }
        List<Models.HocSinh> hocsinhs;
        public void HienThi()
        {
           
            DataTable tb = new DataTable();
            tb = sqlHelper.Query("select top 15 * from HocSinh"); ;
            Controller.HocSinhController hs = new Controller.HocSinhController();
           // tb = hs.Timkiem(cbtype.SelectedIndex, txtInPutTk.Text.Trim());
            if (tb.Rows.Count > 0)
            {
                dtgrv.DataSource = tb;
                dtgrv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tb.Columns["MaHS"].ColumnName = "Mã Học Sinh";
                tb.Columns["HoTen"].ColumnName = "Họ Tên";
                tb.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
                tb.Columns["GioiTinh"].ColumnName = "Giới Tính (Nữ ✓/nam)";
                tb.Columns["TenBo"].ColumnName = "Tên Bố";
                tb.Columns["TenMe"].ColumnName = "Tên Mẹ";
                tb.Columns["MaLop"].ColumnName = "Mã Lớp";
                foreach (DataGridViewColumn col in dtgrv.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }
            }
           // return tb;
        }
        public void Hienthi(int start)
        {
            hocsinhController = new Models.HocSinhController();
            hocsinhs = new List<Models.HocSinh>();
            hocsinhs.Clear();
            hocsinhs = hocsinhController.Get(start, record);
            dtgrv.DataSource = hocsinhs;
            dtgrv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dtgrv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            try { dtgrv.CurrentCell = dtgrv[CurCl, CurR]; } catch { }
            string txtThongTin= string.Format("{0}/{1}", count, GetTongSobanGhi());
            lblSoBanGhi.Caption = txtThongTin;
            lblpage.Caption = string.Format("Trang Số: {0}", page);
            dtgrv.Refresh();
        }
        int CurCl = 0, CurR = 0;
        string IDmember;
        public frmHocSinh()
        {
            InitializeComponent();
            all = GetTongSobanGhi();
            HienThi();
        }

        private void dtgrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgrv.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgrv.CurrentCell.ColumnIndex;
            CurR = dtgrv.CurrentCell.RowIndex;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IDmember == null)
            {
                MessageBox.Show("No Select!!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmThaoTacHS frm = new frmThaoTacHS(IDmember);
            frm.ShowDialog();
            Hienthi(S);
          
        }

      

        Search searchForm = new Search();
        private void btnTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VHocSinh.TimKiem tk = new VHocSinh.TimKiem(dtgrv);
            tk.ShowDialog();
           // searchForm.Show();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            GetData(searchForm.Text, searchForm.Type);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Controller.HocSinhController hs = new Controller.HocSinhController();
            hs.Xoa(IDmember);
            Hienthi(S);
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            searchForm.btnClick.Click += BtnClick_Click;
            searchForm.TypeSearch = new List<string>()
            {
                "Type 1",
                "Type 2",
                "Type 3",
                "Type 4",
                "Type 5"
            };
           // GetData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThaoTacHS frm = new frmThaoTacHS(null);
            frm.ShowDialog();
            Hienthi(S);
        }

        private void btnEnd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dtgrv.Refresh();
            page = all / 15;
            S = all;
            count = all;
            Hienthi(all/15*15);

           

        }
        private void btnStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            count = 15;
            dtgrv.Refresh();
            S = 0;
            page = 1;
            Hienthi(S);     
        }
        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dtgrv.Refresh();
            if (count > 15)
            {
                if (page == (all / 15))
                count -= all % 15;
                else count -= 15;
            }
            if (page >0&&S>=15)
            {
                S -= 15;
                page--;
            }
         Hienthi(S);
        }
        private void btnNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dtgrv.Refresh();
            if(page < (all / 15))
            {
                S += 15;
                page++;
                if(page== (all / 15))
                {
                    count= all;
                }
                else
                {
                    count += 15;
                }
               
            }
            Hienthi(S);
        }

        public void GetData(string key = "", string type = "")
        {
            Models.HocSinhController hocsinhController = new Models.HocSinhController();
            List<Models.HocSinh> hocsinhs = hocsinhController.Get(0, 10);
            dtgrv.DataSource = hocsinhs;
        }
    }
}
