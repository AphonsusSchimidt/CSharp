using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncyptDecyptTripleDES
{
    class Control
    {
        Encypt en=new Encypt();
        Decypt de=new Decypt();
        public void CONTROL()
        {
            Console.Title = "#";
            Console.Write("----ENCYPT & DECYPT TRIPLE DES----\n");
            Console.Write("Nhap 1 de ma hoa \n 2 de giai ma: ");
            int n = int.Parse(Console.ReadLine());
            try
            {
                switch (n)
                {
                    case 1:
                        string text1, key, encypt;
                        Console.Write("Nhap van ban can ma hoa: ");
                        text1 = Console.ReadLine();
                        Console.Write("Nhap key: ");
                        key = Console.ReadLine();
                        encypt = en.Encrypt(text1, key);
                        Console.Write("\nKet qua=>>> {0}", encypt);
                        Clipboard.SetText(encypt);
                        Console.Write("\nDa copy vao clipboard!");
                        break;
                    case 2:
                        string text2, key2, decypt;
                        Console.Write("Nhap van ban can giai ma: ");
                        text2 = Console.ReadLine();
                        Console.Write("Nhap key: ");
                        key2 = Console.ReadLine();
                        decypt = de.Decrypt(text2, key2);
                        Console.Write("\nKet qua=>>> {0}", decypt);
                        Clipboard.SetText(decypt);
                        Console.Write("\nDa copy vao clipboard!");
                        break;
                    default: 
                        Console.Write("Chi nhap 1 hoac 2 nhe!\n");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.Write("\nDa co loi, van ban khong thoa hoac key khong chinh xac\nVui long nhap lai");
            }
        }
    }
}
