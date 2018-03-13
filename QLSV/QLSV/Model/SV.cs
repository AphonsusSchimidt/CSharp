using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.Helper;
namespace QLSV.Model
{
    class SV
    {
        public int MaSV { get; set; }
        public string Hoten { get; set; }
        public DateTime NgaySinh { get; set; }

        public SV(InputType IT)
        {
            if (IT == InputType.Them)
                Console.WriteLine("Nhập Để Thêm");
            else if (IT == InputType.Sua)
            {
                Console.WriteLine("Nhập Để Sửa");
            }
            else Console.WriteLine("Nhập Để Xóa");

            MaSV = InputHepler.InPutINT("Nhập Vào Mã SV: ", "Cần Nhập Lớn hơn 0");
            if (IT == InputType.Them || IT == InputType.Sua)
            {
                Hoten = InputHepler.InPutStr("Nhập Vào Họ Tên: ", "Họ tên dài tối đa 20 và lớn hơn 5", 5, 20);
                NgaySinh = InputHepler.InPutDT("Nhập Vào Ngày Sinh", "cần Là SV", new DateTime(1999, 1, 1), new DateTime(1994, 12, 31));

            }
        }
        public void HienThi()
        {
            Console.WriteLine();
            Console.WriteLine("Mã SV: " + MaSV);
            Console.WriteLine("Tên: " + Hoten);
            Console.WriteLine("Ngày Sinh:"+ NgaySinh.ToShortDateString());
        }
    }
}
