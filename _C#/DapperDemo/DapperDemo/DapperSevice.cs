using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public static class DapperService
    {
        private static string strCn = "Data Source=PHUCND\\PHUCND;Initial Catalog=QuanLyHocSinh;Integrated Security=True";

        public static List<HocSinh> getAllData()
        {
            using (IDbConnection db = new SqlConnection(strCn))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<HocSinh>("SELECT *FROM dbo.HocSinh").ToList();
            }
        }
    }
}