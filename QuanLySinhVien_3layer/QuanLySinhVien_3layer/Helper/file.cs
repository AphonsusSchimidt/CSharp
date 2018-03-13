using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_3layer.Helper
{
    class file
    {
        public static void docFile(string pad)
        {
            if (File.Exists(pad))
            {
                StreamReader stw = null;
                try
                {
                    stw = new StreamReader(pad);
                    ThamSoKetNoi.ServerName = MaHoaString.Decrypt(stw.ReadLine());
                    ThamSoKetNoi.DatabaseName = MaHoaString.Decrypt(stw.ReadLine());
                    ThamSoKetNoi.UserName = MaHoaString.Decrypt(stw.ReadLine());
                    ThamSoKetNoi.PassWord = MaHoaString.Decrypt(stw.ReadLine());
                    stw.Close();
                    stw.Dispose();
                }
                catch
                {
                    stw.Dispose();
                    return;
                }
            }

        }
        public static void ghifile(string pad, string Host, string Db, string uName, string pass)
        {
            StreamWriter stw = new StreamWriter(pad);
            stw.WriteLine("{0}", MaHoaString.Encrypt(Host));
            stw.WriteLine("{0}", MaHoaString.Encrypt(Db));
            stw.WriteLine("{0}", MaHoaString.Encrypt(uName));
            stw.WriteLine("{0}", MaHoaString.Encrypt(pass));
            stw.Close();

        }
        public static void XoaFile(string pad)
        {
            if (File.Exists(pad))
            {
                File.Delete(pad);
            }
            else
            {
                return;
            }
        }
    }
}
