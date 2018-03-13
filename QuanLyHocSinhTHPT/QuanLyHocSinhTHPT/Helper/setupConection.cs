using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_3layer.Helper
{
    class setupConection
    {
        public static string str { get; set; }
        public static SqlConnection connection =
           new SqlConnection(str);
  }
}
