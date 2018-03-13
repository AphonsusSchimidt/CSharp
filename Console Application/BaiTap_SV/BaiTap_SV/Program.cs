using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap_SV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int luachon = 0;
            SV sinhvien = new SV();
            List<SV> lsst = null;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Nhap Du Lieu ");
                Console.WriteLine("2.Doc Du lieu Tu File ");
                Console.WriteLine("3.Xem Danh Sach");
                Console.WriteLine("4.Sort");
                Console.WriteLine("5. Tim Kiem Theo Ho Ten ");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        businiss.GhiFile("DucMl.txt", businiss.addInList());
                        Console.ReadKey();
                        break;
                    case 2:
                        lsst = businiss.docFile("DucMl.txt");
                        businiss.ShowInList(lsst);
                        Console.ReadKey();
                        break;
                    case 3:
                        lsst = businiss.docFile("DucMl.txt");
                        businiss.ShowInList(lsst);
                        break;
                    case 4:
                        {
                            lsst.Sort(;
                            businiss.ShowInList(lsst);
                        }
                        break;
                    case 5:
                        {
                            string look;
                            Console.WriteLine("Nhap vao Ten:  ");
                            look = Console.ReadLine();
                            List<SV> kq = businiss.SeachByName(lsst, look);
                            businiss.ShowInList(kq);
                            Console.ReadKey();
                        }
                        break;
                    case 6:
                        return;
                }
            } while (luachon != 6);
            Console.ReadKey();
        }
    }
}
