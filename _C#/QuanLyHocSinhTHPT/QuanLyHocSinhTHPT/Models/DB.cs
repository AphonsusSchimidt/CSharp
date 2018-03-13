using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
   public class DB
    {
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(ConnectionString.Connection);
        public static class ConnectionString
        {
            public static string Connection = @"Data Source=PHUCND\PHUCND;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
        }
    }
}
