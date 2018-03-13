using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BaiTap_SV
{
    public class SV
    {
        public string MaSV { get; set; }
        public int ID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string MaLop { get; set; }
        public SV()
        {
            MaSV = "";
            ID = 0;
            HoTen = "";
            NgaySinh = DateTime.Now;
            GioiTinh = 1;
            MaLop = "";
        }
        public SV(string _MaSV, int _ID, string _HoTen, DateTime _NgaySinh, int _GioiTinh, string _MaLop)
        {
            MaSV = _MaSV;
            ID = _ID;
            HoTen = _HoTen;
            NgaySinh = _NgaySinh;
            GioiTinh = _GioiTinh;
            MaLop = _MaLop;
        }
        public void Nhap()
        {
            Console.Write("Nhap Vao MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap Vao ID: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Nhap Vao HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Vao ngaySinh: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap Vao GioiTinh: ");
            GioiTinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap Vao maLop: ");
            MaLop = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("MaSV: {0} ", MaSV);
            Console.WriteLine("ID: {0} ", ID);
            Console.WriteLine("HoTen: {0} ", HoTen);
            Console.WriteLine("ngaySinh: {0} ", NgaySinh);
            string _GT = "";
            if (GioiTinh == 1)
            {
                _GT = "Nam";
            }
            if (GioiTinh == 0)
            {
                _GT = "Nữ";
            }
            if (GioiTinh == 2)
            {
                _GT = "Không Xác Định";
            }
            Console.WriteLine("GioiTinh: {0} ", _GT);
            Console.WriteLine("maLop: {0} ", MaLop);
        }
        public void Sort_By_ID(List<SV> lstSV)
        {
            lstSV.Sort();
        }
       
    }
}

