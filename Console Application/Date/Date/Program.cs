using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            date dt = new date();
            dt.Nhap();
           
            dt++.Xuat();
            
            Console.ReadKey();
            
        }
    }
}
