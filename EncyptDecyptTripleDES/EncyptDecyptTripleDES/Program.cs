using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// EncyptDecyptTripleDES---Code by LMT---lêminhthành.vn
/// Có tham khảo trên internet!
/// </summary>
namespace EncyptDecyptTripleDES
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Control ctr=new Control();
            while (true)
            {
                ctr.CONTROL();
                Console.Write("\nAn Enter neu muon tiep tuc!");
                Console.ReadKey();
                Console.Clear();
            }
            

        }
    }
}
