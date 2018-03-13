using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Helper
{
    enum InputType
    {
        Them,
        Sua,
        Xoa
    }
    class InputHepler
    {
 
     
        public static int InPutINT(string msg,string err)
        {
            int ret;
            bool ok;
            do
            {       
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(),out ret);
                if (!ok)
                {
                    Console.WriteLine(err);
                }
                else if (ret <= 0)
                {
                    ok = false;
                    Console.WriteLine(err);
                }
                else ok = true;
            } while (!ok);
            return ret;
        }
        public static string InPutStr(string mgs, string err,int min= int.MinValue,int max=int.MaxValue)
        {
            string str;
            bool ok;
            do
            {
                Console.WriteLine(mgs);
                str = Console.ReadLine();
                if (str.Length < min || str.Length > max)
                {
                    Console.WriteLine(err);
                    ok = false;
                }
                else ok = true;
            } while (!ok);
            return str;       
        }
        public static DateTime InPutDT(string mgs, string err,DateTime DTmax,DateTime DTmin)
        {
            DateTime DT;
            bool ok;
            do
            {
                Console.WriteLine(mgs);
                ok = DateTime.TryParse(Console.ReadLine(), out DT);
                if (DT < DTmin || DT > DTmax)
                {
                    Console.WriteLine(err);
                    ok = false;
                }
                else ok = true;
            } while (!ok);
            return DT;
        }
    }
}
