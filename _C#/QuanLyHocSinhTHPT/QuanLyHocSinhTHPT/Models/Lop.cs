using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
  public  class Lop
    {
        [DisplayName("Mã Lớp")]
        public string Malop { get; set; }
        [DisplayName("Mã Lớp")]
        public string ViTri { get; set; }
        [DisplayName("Vị Trí")]
        public string SiSo { get; set; }

        [DisplayName("Mã GV")]
        public string MaGV { get; set; }
       
        public Lop(string _Malop, string _ViTri, string _SiSo,string _MaGV)
        {
            this.Malop = _Malop;
            this.ViTri = _ViTri;
            this.SiSo = _SiSo;
            this.MaGV = _MaGV;
        }
        public Lop()
        {
            this.Malop = "";
            this.ViTri = "";
            this.SiSo = "";
            this.MaGV = "";
        }
    }
}
