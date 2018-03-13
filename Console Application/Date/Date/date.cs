using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class date
    {
        public int ngay { get; set; }
        public int thang { get; set; }
        public int nam { get; set; }
        public date()
        {
            this.ngay = 0;
            this.thang = 0;
            this.nam = 0;
        }
        public date(int _ngay, int _thang, int _nam)
        {
            this.ngay = _ngay;
            this.thang = _thang;
            this.nam = _nam;
        }

        public bool KTNhuan()
        {
            if ((this.nam % 4 == 0 && this.nam % 100 != 0) || this.nam % 400 == 0)
            {
                return true;
            }
            return false;
        }

        public static int SoNgayTrongThang(date date)
        {
            if (date.thang == 2)
            {
                if (date.KTNhuan()) return 29;
                return 28;
            }
            if (date.thang == 4 || date.thang == 6 || date.thang == 9 || date.thang == 11) return 30;
            return 31;
        }



        public static date operator ++(date a)
        {
            a.ngay++;
            if (a.thang == 1 || a.thang == 3 || a.thang == 5 || a.thang == 7 || a.thang == 8 || a.thang == 10 || a.thang == 12)
            {
                if (a.ngay > 31)
                {
                    a.ngay = 1;
                    a.thang++;
                    if (a.thang > 12)
                    {
                        a.thang = 1;
                        a.nam++;
                    }
                }
            }
            else if (a.thang == 2)
            {
                if (a.KTNhuan())
                {
                    if (a.ngay > 29)
                    {

                        a.ngay = 1;
                        a.thang++;
                    }
                }
                else
                {
                    if (a.ngay > 28)
                    {
                        a.ngay = 1;
                        a.thang++;
                    }
                }
            }
            else
            {
                if (a.ngay > 30)
                {
                    a.ngay = 1;
                    a.thang++;
                    if (a.thang > 12)
                    {
                        a.thang = 1;
                        a.nam++;
                    }
                }
            }
            return a;
        }
        public static date operator --(date a)
        {
            a.ngay--;
            if (a.ngay < 0)
            {
                if (a.thang == 1 || a.thang == 5 || a.thang == 7 || a.thang == 8 || a.thang == 10 || a.thang == 12)
                {

                    a.thang--;
                    a.ngay = 30;
                    if (a.thang < 0)
                    {
                        a.thang = 12;
                        a.nam--;
                    }
                }
                else if (a.thang == 3)
                {
                    if (a.KTNhuan())
                    {
                        a.ngay = 29;
                        a.thang--;
                    }
                    else
                    {
                        a.ngay = 28;
                        a.thang--;
                    }
                }
                else
                {
                    a.ngay = 31;
                    a.thang--;
                }
            }
            return a;
        }

        public void Nhap()
        {
            bool ok;
            int _nam = 0, _thang = 0, _ngay = 0;
            do
            {
                Console.Write("\nNhap nam : ");
                ok = int.TryParse(Console.ReadLine(), out _nam);

                if (_nam <= 2017 && _nam > 1990) { this.nam = _nam; }
                else { Console.Write("\nSai Định Dạng năm"); ok = false; }

            } while (!ok);
            do
            {
                Console.Write("\nNhap Thang: ");
                ok = int.TryParse(Console.ReadLine(), out _thang);

                if (_thang <= 12 && _thang > 0)
                {
                    this.thang = _thang;
                }
                else
                {
                    Console.Write("\nSai Định Dạng Tháng"); ok = false;
                }

            } while (!ok);
            do
            {
                Console.Write("\nNhập Ngày : ");
                ok = int.TryParse(Console.ReadLine(), out _ngay);

                switch (_thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        {
                            if (_ngay > 0 && _ngay <= 31) this.ngay = _ngay; else { Console.Write("\nSai Định Dạng Ngày"); ok = false; }
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        {
                            if (_ngay > 0 && _ngay <= 30) this.ngay = _ngay; else { Console.Write("\nSai Định Dạng Ngày"); ok = false; }
                        }
                        break;
                    case 2:
                        {
                            if (this.KTNhuan())
                            {
                                if (_ngay > 0 && _ngay <= 29) this.ngay = _ngay; else { Console.Write("\nSai Định Dạng Ngày"); ok = false; }
                            }
                            else
                            {
                                if (_ngay > 0 && _ngay <= 8) this.ngay = _ngay; else { Console.Write("\nSai Định Dạng Ngày"); ok = false; }
                                break;
                            }
                        }
                        break;
                }

            } while (!ok);


        }
        public void Xuat()
        {
            if (this.ngay < 10)
            {
                Console.Write("0{0}", this.ngay);
            }
            else
            {
                Console.Write("{0}", this.ngay);
            }
            if (this.thang < 10)
            {
                Console.Write(" : 0{0}", this.thang);
            }
            else
            {
                Console.Write(" : {0}", this.thang);
            }
            Console.Write(" : {0}", this.nam);
        }
    }
}

