using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    class GiaoVien
    {
        string MaGV { get; set; }
        string HoTen { get; set; }
        string NgaySinh { get; set; }
        int GioiTinh { get; set; }
        string Sdt { get; set; }
        string QueQuan { get; set; }
      public  GiaoVien(string _MaGV, string _HoTen, string _NgaySinh, int _GioiTinh, string _Sdt, string _QueQuan)
        {
            this.MaGV = _MaGV;
            this.HoTen = _HoTen;
            this.NgaySinh = _NgaySinh;
            this.GioiTinh = _GioiTinh;
            this.Sdt = _Sdt;
            this.QueQuan = _QueQuan;
        }
    }
}
