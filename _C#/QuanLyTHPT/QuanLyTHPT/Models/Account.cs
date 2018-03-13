using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    class Account
    {
        public string TaiKhoan {get;set;}
        public string Matkhau { get; set; }
        public Account (string Tk, string mk)
        {
            this.TaiKhoan = Tk;
            this.Matkhau = mk;
        }
        public Account()
        {
            this.TaiKhoan = "";
            this.Matkhau = "";
        }

    }
}
