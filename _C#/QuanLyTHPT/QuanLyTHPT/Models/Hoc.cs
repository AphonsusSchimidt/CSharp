using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    class Hoc
    {
        [DisplayName("Mã Môn Học")]
        string MaMH { get; set; }
        [DisplayName("Mã SV")]
        string MaSV { get; set; }
        [DisplayName("Diểm tổng kết")]
        string DiemTongKet { get; set; }
        public Hoc(string _MaMH, string _MaSV, string _DiemTongKet)
        {
            this.MaMH = _MaMH;
            this.MaSV = _MaSV;
            this.DiemTongKet = _DiemTongKet;
        }
    }
}
