using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            ps phanso1 = new ps(1,2);
            ps phanso2 = new ps(1, 2);
            Console.Write((phanso1 + phanso2).ToString());
            Console.ReadKey();
        }
    }
}
