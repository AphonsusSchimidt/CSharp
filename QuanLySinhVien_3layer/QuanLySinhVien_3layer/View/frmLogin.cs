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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
         private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select TaiKhoan from Account where TaiKhoan='{0}' and MatKhau='{1}'", txtUseName.Text, txtPassWord.Text);
            DataTable dt = sqlHelper.Query(sql);

            if (dt.Rows.Count == 1)
            {
                SingletonData.Getlates().nguoidung = new Account() { TaiKhoan = txtUseName.Text };
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();
            }
            else
            {
                SingletonData.Getlates().nguoidung = null;
                MessageBox.Show("Đăng nhập thất bại. Xem lại tài khoản hoặc mật khẩu!");
            }

        }
    }
}
