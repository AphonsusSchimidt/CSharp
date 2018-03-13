using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgoDinhPhuc_15150178
{
    class SinhVienCotroller
    {

        public static void GhiFile(string pad, List<SinhVien> Sv)
        {
            StreamWriter stw = new StreamWriter(pad);
            foreach (SinhVien sinhvien in Sv)
            {
                stw.WriteLine("{0}", sinhvien.MaSV);
                stw.WriteLine("{0}", sinhvien.HoTen);
                stw.WriteLine("{0}", sinhvien.MaLop);
                stw.WriteLine("{0}", sinhvien.NgaySinh);
                stw.WriteLine("{0}", sinhvien.GioiTinh);
                stw.WriteLine("{0}", sinhvien.DiemTongKet);
            }
            stw.Close();
        }
        public static List<SinhVien> docFile(string pad)
        {
            List<SinhVien> lst = new List<SinhVien>();
            StreamReader stw = new StreamReader(pad);
            while (!stw.EndOfStream)
            {
                SinhVien sinhvien = new SinhVien();
                sinhvien.MaSV = stw.ReadLine();
                sinhvien.HoTen = stw.ReadLine();
                sinhvien.MaLop = stw.ReadLine();
                sinhvien.NgaySinh = DateTime.Parse(stw.ReadLine());
                sinhvien.GioiTinh = bool.Parse(stw.ReadLine());
                sinhvien.DiemTongKet = double.Parse(stw.ReadLine());
                lst.Add(sinhvien);
            }
            stw.Close();
            return lst;
        }
        public static List<SinhVien> addInList(List<SinhVien> LstSV ,string _MaSV, string _HoTen, DateTime _NgaySinh, bool _GioiTinh, string _MaLop, double _DiemTongKet
            )
        {
            SinhVien SinhVien1 = new SinhVien(
                 _MaSV,  _HoTen,  _NgaySinh,  _GioiTinh,  _MaLop,  _DiemTongKet
                );
            LstSV.Add(SinhVien1);
            return LstSV;

        }

        public static List<SinhVien> SeachByName(List<SinhVien> lstSV, string look)
        {
            List<SinhVien> kq = new List<SinhVien>();
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
