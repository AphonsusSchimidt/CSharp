using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgoDinhPhuc_15150178
{
    class SinhVien
    {
        [DisplayName("Mã Sinh Viên")]
        public string MaSV { get; set; }
        [DisplayName("Họ Tên")]
        public string HoTen { get; set; }
        [DisplayName("Ngày Sinh")]
        public DateTime NgaySinh { get; set; }
        [DisplayName("Giới Tính")]
        public bool GioiTinh { get; set; }
        [DisplayName("Mã Lớp")]
        public string MaLop { get; set; }
        [DisplayName("Điểm tổng kết")]
        public double DiemTongKet { get; set; }
        public SinhVien()
        {
           this.MaSV = "";
            this.HoTen = "";
            this.NgaySinh = DateTime.Now;
            this.GioiTinh = true;
            this.MaLop = "";
            this.DiemTongKet = 0;
        }
        public SinhVien(string _MaSV, string _HoTen, DateTime _NgaySinh, bool _GioiTinh, string _MaLop,double _DiemTongKet)
        {
            this.MaSV = _MaSV;
            this.HoTen = _HoTen;
            this.NgaySinh = _NgaySinh;
            this.GioiTinh = _GioiTinh;
            this.MaLop = _MaLop;
            this.DiemTongKet = _DiemTongKet;
        }
       
    }
}
