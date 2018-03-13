using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace BaiTap_SV
{
    public class businiss
    {
        public static void GhiFile(string pad, List<SV> Sv)
        {
            StreamWriter stw = new StreamWriter(pad);
            foreach (SV sinhvien in Sv)
            {
                stw.WriteLine("{0}", sinhvien.MaSV);
                stw.WriteLine("{0}", sinhvien.ID);
                stw.WriteLine("{0}", sinhvien.HoTen);
                stw.WriteLine("{0}", sinhvien.NgaySinh);
                stw.WriteLine("{0}", sinhvien.GioiTinh);
                stw.WriteLine("{0}", sinhvien.MaLop);
            }
            stw.Close();
        }
        public static  List<SV> docFile(string pad)
        {
            List<SV> lst = new List<SV>(); 
            StreamReader stw = new StreamReader(pad);
            while(!stw.EndOfStream)
            {
                   SV sinhvien= new SV();
                sinhvien.MaSV = stw.ReadLine();
                sinhvien.ID = int.Parse(stw.ReadLine());
                sinhvien.HoTen = stw.ReadLine();
                sinhvien.NgaySinh = DateTime.Parse(stw.ReadLine());
                sinhvien.GioiTinh = int.Parse(stw.ReadLine());
                sinhvien.MaLop = stw.ReadLine();
                lst.Add(sinhvien);
            }
            stw.Close();
            return lst;
        }
        public static List<SV> addInList()
        {
            Console.Write("Nhap Vao So luong Sv: ");
            int n = int.Parse(Console.ReadLine());

            List<SV> LstSV = new List<SV>();
            for (int i = 0; i < n; i++)
            {
                SV SinhVien1 = new SV();
                SinhVien1.Nhap();
                LstSV.Add(SinhVien1);
            }
            return LstSV;
            
        }
        public static void ShowInList(List<SV> lst)
        {
            foreach (SV Sinhvien in lst)
            {
                Console.WriteLine("MaSV: {0} ", Sinhvien.MaSV);
                Console.WriteLine("ID: {0} ", Sinhvien.ID);
                Console.WriteLine("HoTen: {0} ", Sinhvien.HoTen);
                Console.WriteLine("ngaySinh: {0} ", Sinhvien.NgaySinh);
                string _GT = "";
                if (Sinhvien.GioiTinh == 1)
                {
                    _GT = "Nam";
                }
                if (Sinhvien.GioiTinh == 0)
                {
                    _GT = "Nữ";
                }
                if (Sinhvien.GioiTinh == 2)
                {
                    _GT = "Không Xác Định";
                }
                Console.WriteLine("GioiTinh: {0} ", _GT);
                Console.WriteLine("maLop: {0} ", Sinhvien.MaLop);
                Console.WriteLine("");
            }
        }
        public static List<SV> SeachByName(List<SV> lstSV, string look)
        {
            List<SV> kq = new List<SV>();    
            for (int i = 0; i < lstSV.Count; i++)
            {
                if (lstSV[i].HoTen.Contains(look))
                {
                    kq.Add(lstSV[i]);
                }
            }
            return kq;
        }


    }
}
