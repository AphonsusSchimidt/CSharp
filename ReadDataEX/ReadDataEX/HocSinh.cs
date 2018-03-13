using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDataEX
{


    class HocSinh : ClassBase
    {
        [DisplayName("Họ Tên")]
        public string FullName { get; set; }
        [DisplayName("Năm Sinh")]
        public string YearOfBirth { get; set; }
        [DisplayName("Quê Quán")]
        public string HomeTown { get; set; }
        [DisplayName("Địa Chỉ")]
        public string Adress { get; set; }
        [DisplayName("Họ Tên Bố")]
        public string NameFather { get; set; }
        [DisplayName("Họ Tên Mẹ")]
        public string NameMother { get; set; }
    }
}
