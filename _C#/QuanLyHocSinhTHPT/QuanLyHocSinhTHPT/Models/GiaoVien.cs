using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    public class GiaoVien
    {
        [DisplayName("Mã Giáo Viên")]
        public string MaGV { get; set; }
        [DisplayName("Họ Tên")]
        public string HoTen { get; set; }
        [DisplayName("Ngày Sinh")]
        public string NgaySinh { get; set; }
        [DisplayName("Giới Tính")]
        public string GioiTinh { get; set; }
        [DisplayName("Số dt")]
        public string Sdt { get; set; }
        [DisplayName("Quê quán")]
        public string QueQuan { get; set; }
      public  GiaoVien(string _MaGV, string _HoTen, string _NgaySinh, string _GioiTinh, string _Sdt, string _QueQuan)
        {
            this.MaGV = _MaGV;
            this.HoTen = _HoTen;
            this.NgaySinh = _NgaySinh;
            this.GioiTinh = _GioiTinh;
            this.Sdt = _Sdt;
            this.QueQuan = _QueQuan;
        }
        public GiaoVien()
        {
            this.MaGV = "";
            this.HoTen = "";
            this.NgaySinh = "1989-1-1";
            this.GioiTinh = "Nam";
            this.Sdt = "";
            this.QueQuan = "";
        }
    }
}
