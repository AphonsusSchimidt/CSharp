using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    class HocSinh
    {
        [DisplayName("Mã học sinh")]
        string MaHS { get; set; }
        [DisplayName("Họ Tên")]
        string HoTen { get; set; }
        [DisplayName("Quê quán")]
        string QueQuan { get; set; }
        [DisplayName("Giới tính")]
        int GioiTinh { get; set; }
        [DisplayName("Ngày Sinh")]
        string NgaySinh { get; set; }
        [DisplayName("Tên Bố")]
        string TenBo { get; set; }
        [DisplayName("Tên Mẹ")]
        string TenMe { get; set; }
        [DisplayName("Mã Lớp")]
        string MaLop { get; set; }
        public HocSinh(string _MaHS,string _HoTen, string _QueQuan, int _GioiTinh, string _NgaySinh, string _TenBo, string _TenMe, string _MaLop)
        {
            this.MaHS = _MaHS;
            this.HoTen = _HoTen;
            this.QueQuan = _QueQuan;
            this.GioiTinh = _GioiTinh;
            this.NgaySinh = _NgaySinh;
            this.TenBo = _TenBo;
            this.TenMe = _TenMe;
            this.MaLop = _MaLop;
        }
    }
}
