using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    public class MonHoc
    {
        [DisplayName("Mã Môn Học")]
        public string MaMon { get; set; }
        [DisplayName("Tên")]
        public string TenMon { get; set; }
        [DisplayName("Hệ Số")]
        public string HeSo {
            get;
            set;
        }
       
        public MonHoc(string _MaMon, string _TenMon, string _HeSo)
        {
            this.MaMon = _MaMon;
            this.TenMon = _TenMon;
            this.HeSo = _HeSo;
        }
        public MonHoc()
        {
            this.MaMon = "";
            this.TenMon = "";
            this.HeSo = "";
        }
    }
}
