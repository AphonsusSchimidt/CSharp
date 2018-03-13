using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien_3layer.Models;
using QuanLySinhVien_3layer.Helper;

namespace QuanLySinhVien_3layer.View
{
    public partial class frmMain : Form
    {
        Account nd = new Account();
        public frmMain()
        {
            InitializeComponent();
            disableAll();
            lblNguoidung.Text = "Bạn chưa login";
        }
        private void disableAll()
        {
            mnuHT_QuanLyNguoiDung.Enabled = false;
            mnuHT_NhatKyLoi.Enabled = false;
            mnuHT_KhoiPhucDuLieu.Enabled = false;
            mnuHT_NhatKyLoi.Enabled = false;
            mnuHT_HoatDong.Enabled = false;
            mnuHT_KetXuatDuLieu.Enabled = false;
            mnuHT_ChangePass.Enabled = false;
            mnuHT_Backup.Enabled = false;
            mnuBaoCao.Enabled = false;
            mnuKB.Enabled = false;

        }
        private void mnHT_Login_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            nd = SingletonData.Getlates().nguoidung;
            if(nd!=null)
            {
                mnHT_Login.Enabled = false;
                mnuKB.Enabled = true;
                lblNguoidung.Text = nd.TaiKhoan;
            }
        }

        private void mnuKB_MonHoc_Click(object sender, EventArgs e)
        {
            frmDanhMucMH frmdm = new frmDanhMucMH();
            this.Hide();
            frmdm.ShowDialog();
            this.Show();
        }

        private void mnuHT_Click(object sender, EventArgs e)
        {

        }
    }
}
