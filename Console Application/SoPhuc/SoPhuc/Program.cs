using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoPhuc
{
    class Program
    {
        static void Main(string[] args)
        {
            SoPhuc sp = new SoPhuc(3, -2);
            SoPhuc sp2 = new SoPhuc(2, -3);
            Console.Write("cong: " + (sp + sp2).ToString()+"\n");
            Console.Write("Tru: " + (sp - sp2).ToString() + "\n");
            Console.Write("Nhan: " + (sp * sp2).ToString() + "\n");
            Console.Write("Chia: " + (sp / sp2).ToString() + "\n");
            Console.ReadKey();

        }
    }
}
