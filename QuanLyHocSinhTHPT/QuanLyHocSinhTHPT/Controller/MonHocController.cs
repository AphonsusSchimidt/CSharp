using QuanLyHocSinhTHPT.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Controller
{
    class MonHocController
    {
        public bool ThemMH(string _MaMon, string _TenMon, float _HeSo)
        {
            string query = string.Format("INSERT INTO MonHoc values ('{0}',N'{1}', {2:0.0})",
                _MaMon, _TenMon, _HeSo);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool SuaMH(string _MaMon, string _TenMon, float _HeSo, string _MaMonID)
        {
            string query = string.Format("update MonHoc set MaMon='{0}',TenMon=N'{1}',HeSo={2} where MaMon='{3}'",
                _MaMon, _TenMon, _HeSo, _MaMonID);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool XoaMH(string _MaMon)
        {

            string query = string.Format("delete from MonHoc  Where MaMon ={0}", _MaMon);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }


    }
}
