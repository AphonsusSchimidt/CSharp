using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class Program
    {
        public void Bai1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b, c;
            Console.Write("Nhap Vao a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap Vao b= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap Vao c= ");
            c = int.Parse(Console.ReadLine());
            int max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            Console.WriteLine("Số lớn nhất là max= {0} ", max);
            Console.ReadKey();
        }
        public static void bai2()
        {

            int duong = 0, am = 0;
            int a;
            do
            {
                bool ok = true;
                do
                {
                    ok = int.TryParse(Console.ReadLine(), out a);

                } while (!ok);
                if (a == 0) break;
                if (a > 0) { duong++; }
                else
                {
                    am++;
                }

            } while (a != 0);

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("số dương bằng = {0},số âm là {1} ", duong, am);
            Console.ReadKey();
        }
        public static bool Snt(int a)
        {
         
            for (int i = 2; i <= a / 2; i++)
            {

                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int TongSole(int n)
        {
            int tong = 0;
            for (int i = 0; i <n; i++)
            {
               
                if (i % 2 != 0)
                {
                    tong += i;
                }
            }
            return tong;
            //Console.OutputEncoding = Encoding.UTF8;
            //int a;
            //bool ok = true;
            //do
            //{
            //    ok = int.TryParse(Console.ReadLine(), out a);
            //    if ((a % 2 == 0)) ok = false;

            //} while ((!ok));

            //Console.WriteLine("Tổng số lẻ là {0} ", TongSole(a));

            //Console.ReadKey();
        }
        public static int Sochan()
        {
            int [] a= new int[10];
            int soChan = 0;
           
          
            for (int i = 0; i < a.Length; i++)
            {
                bool ok = true;
                do
                {
                    ok = int.TryParse(Console.ReadLine(), out a[i]);                 
                } while ((!ok));
                if (a[i] % 2 == 0)
                {
                    soChan ++;
                }
            }
            return soChan;
            //Console.OutputEncoding = Encoding.UTF8;
            //int a;
            //bool ok = true;
            //do
            //{
            //    ok = int.TryParse(Console.ReadLine(), out a);
            //    if ((a % 2 == 0)) ok = false;

            //} while ((!ok));

            //Console.WriteLine("Tổng số lẻ là {0} ", TongSole(a));

            //Console.ReadKey();
        }
        
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Số chẵn là {0} ", Sochan());
           
            
            Console.ReadKey();
        }
    }
}
