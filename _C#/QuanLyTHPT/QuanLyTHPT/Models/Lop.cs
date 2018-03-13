using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    class Lop
    {
        [DisplayName("Mã Lớp")]
        string Malop { get; set; }
        [DisplayName("Mã Lớp")]
        string ViTri { get; set; }
        [DisplayName("Vị Trí")]
        int SiSo { get; set; }
        public Lop(string _Malop, string _ViTri,int _SiSo)
        {
            this.Malop = _Malop;
            this.ViTri = _ViTri;
            this.SiSo = SiSo;
        }
    }
}
