using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
  public  class Hoc
    {
        [DisplayName("Mã Môn Học")]
        public string MaMH { get; set; }
        [DisplayName("Mã SV")]
        public string MaHS { get; set; }
        [DisplayName("Diểm tổng kết")]
        public string DiemTongKet { get; set; }
        public Hoc(string _MaMH, string _MaHS, string _DiemTongKet)
        {
            this.MaMH = _MaMH;
            this.MaHS = _MaHS;
            this.DiemTongKet = _DiemTongKet;
        }
        public Hoc()
        {
            this.MaMH = "";
            this.MaHS = "";
            this.DiemTongKet = "";
        }
    }
}
