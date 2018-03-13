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
    public partial class frmXoaGV : DevExpress.XtraEditors.XtraForm
    {
        Controller.GiaoVienController cgv;
        GiaoVien gv;
        public frmXoaGV(string MaGV)
        {
            InitializeComponent();
            cgv = new Controller.GiaoVienController();
            gv = new GiaoVien();
            gv = cgv.GetData(MaGV);
            txtHoTen.Text = gv.HoTen;
            txtMaGV.Text = gv.MaGV;
            //Xử lý mã gV thay
            DataTable mhs = sqlHelper.Query("SELECT MaGV FROM GiaoVien");
            List<DataRow> list1 = mhs.AsEnumerable().ToList();
            for (int i = 0; i < list1.Count; i++)
            {
                ComboboxItem item1 = new ComboboxItem();
                item1.Text = list1[i].ItemArray[0].ToString();
                item1.Value = list1[i].ItemArray[0].ToString();
                cbbMaGVThay.Items.Add(item1);
            }
        }

        private void btnchapNhan_Click(object sender, EventArgs e)
        {
            cgv = new Controller.GiaoVienController();
            if(cbbMaGVThay.Text.Trim()!="")
            {
                if(cgv.XoaGV(gv.MaGV, cbbMaGVThay.Text.Trim()))
                {
                    MessageBox.Show("Xóa Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }else
                {
                    MessageBox.Show("Xóa Lỗi, KT lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }else
            {
                MessageBox.Show("Vui lòng chọn Giáo Viên thay thế", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
