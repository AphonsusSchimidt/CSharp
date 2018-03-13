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
    public partial class frmHocSinh : Form
    {
        private int _type;

        public frmHocSinh(string MaHS, string HoTen,
            string QueQuan, bool GioiTinh, DateTime NgaySinh,
            string TenBo, string TenMe, string MaLop, int type
           )
        {
            InitializeComponent();
            txtMaHS.Text = MaHS;
            txtHoTen.Text = HoTen;
            txtQueQuan.Text = QueQuan;
            ckGender.Checked = GioiTinh;
            dtNgaySinh.Value = NgaySinh;
            txtTenBo.Text = TenBo;
            txtTenMe.Text = TenMe;
            txtLop.Text = MaLop;
            _type = type;
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            switch (_type)
            {
                case 1:
                    break;

                case 2:
                    {
                        txtMaHS.Enabled = false;
                    }
                    break;

                case 3:
                    break;
            }
        }
    }
}