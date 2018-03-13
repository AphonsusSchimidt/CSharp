using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPTBac2
{
    class Program
    {

        public static void ptb2(double a, double b, double c )
        {

             double x, delta, x1, x2;
             Console.Write("Giai phuong trinh bac 2");
          
            

            if (a == 0)
            {
                if (b == 0)
                {

                    if (c == 0)
                         Console.Write("\nphuong trinh vo so nghiem");
                    else
                         Console.Write("\nphuong trinh vo nghiem");
                }
                else
                {
                    x = -c / b;
                     Console.Write("\nphuong trinh co nghiem duy nhat=%f", x);
                }
            }
            else
            {
                delta = (b * b) - (4 * a * c); //tinh denta//
                if (delta < 0)
                     Console.Write("\nphuong trinh vo nghiem");
                if (delta == 0)
                {//o day viet else if xong o duoi viet else//
                    x = (-b) / (2 * a);
                     Console.Write("\nphuong trinh co nghiem kep=%f", x);
                }
                if (delta > 0) //else o day co duoc k )
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                     Console.Write("\nphuong trinh co 2 nghiem phan biet: ");
                     Console.Write("\tx1= %f\t", x1);
                     Console.Write("x2= %f", x2);
                }
            }

        }
        static void Main(string[] args)
        {
            double a=0, b=0, c=0;
           
            bool ok = true;
            do
            {
                Console.Write("\nnhap a: ");
                ok = double.TryParse(Console.ReadLine(), out a);
                if(!ok) Console.Write("\nSai Dinh Dang ");
            } while (!ok);
          
            do
            {
                Console.Write("\nnhap b: ");
                ok = double.TryParse(Console.ReadLine(), out b);
                if (!ok) Console.Write("\nSai Dinh Dang ");
            } while ((!ok));
           
            do
            {
                Console.Write("\nnhap c: ");
                ok = double.TryParse(Console.ReadLine(), out c);
                if (!ok) Console.Write("\nSai Dinh Dang ");
            } while ((!ok));
           
            ptb2(a, b, c);
            Console.ReadKey();
        }
    }
}
