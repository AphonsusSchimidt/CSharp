using QuanLyHocSinhTHPT.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Controller
{
    class GiaoVienController
    {

        public bool ThemMH(string _MaGV, string _HoTen, string NgaySinh, int _GioiTinh, string _Sdt, string _QueQuan)
        {
            string query = string.Format("INSERT INTO GiaoVien values ('{0}', N'{1}', '{2}',{3},'{4}',N'{5}')",
                _MaGV, _HoTen, NgaySinh, _GioiTinh, _Sdt, _QueQuan);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool SuaMH(string _MaGV, string _HoTen, string _NgaySinh, int _GioiTinh, string _Sdt, string _QueQuan)
        {
            string query = string.Format("update INTO GiaoVien values (MaGV='{0}', HoTen=N'{1}', NgaySinh='{2}',GioiTinh={3},Sdt='{4}',QueQuan=N'{5}' where MaGV='{6}')",
                _MaGV, _HoTen, _NgaySinh, _GioiTinh, _Sdt, _QueQuan,_MaGV);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool XoaMH(string _MaGV)
        {

            string query = string.Format("delete from GiaoVien  Where MaGV ={0}", _MaGV);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }



    }
}
