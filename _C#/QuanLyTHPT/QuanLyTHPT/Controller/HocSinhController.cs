using QuanLyHocSinhTHPT.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Controller
{
    class HocSinhController
    {
        public bool ThemHS(string _MaHS,string _HoTen, string _QueQuan,
            int _GioiTinh, string _NgaySinh, string _TenBo,
            string _TenMe, string _MaLop)
        {
            string query = string.Format("INSERT INTO HocSinh values ('{0}',N'{1}', N'{2}',{3},'{4}',N'{5}',N'{6}','{7}')",
                _MaHS, _HoTen, _QueQuan, _GioiTinh, _NgaySinh, _TenBo, _TenMe, _MaLop);
            if(sqlHelper.NonQuery(query))
                 return true;  else return false;
        }

        public bool SuaHS(string _MaHS, string _HoTen, string _QueQuan,
            int _GioiTinh, string _NgaySinh, string _TenBo,
            string _TenMe, string _MaLop)
        {
            string query = string.Format("update INTO HocSinh set (MaHS='{0}',HoTen=N'{1}',QueQuan= N'{2}',GioiTinh={3},NgaySinh='{4}',TenBo=N'{5}',TenMe=N'{6}',MaLop='{7}')",
                _MaHS, _HoTen, _QueQuan, _GioiTinh, _NgaySinh, _TenBo, _TenMe, _MaLop);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool Xoa(string _MaHS)
        {
            string query = string.Format("delete from HocSinh  Where MaHS ={0}", _MaHS);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

    }
}
