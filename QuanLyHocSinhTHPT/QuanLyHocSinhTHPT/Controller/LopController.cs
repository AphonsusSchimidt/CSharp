using QuanLyHocSinhTHPT.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Controller
{
    class LopController
    {
        public bool ThemLop(string _Malop, string _ViTri, int SiSo)
        {
            string query = string.Format("INSERT INTO Lop values ('{0}',N'{1}', {2})",
                _Malop, _ViTri, SiSo);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool SuaLop(string _Malop, string _ViTri, int _SiSo, string _MalopID)
        {
            string query = string.Format("update Lop set Malop='{0}',ViTri=N'{1}',SiSo={2} where Malop='{3}'",
                _Malop, _ViTri, _SiSo, _MalopID);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool XoaLop(string _Malop)
        {

            string query = string.Format("delete from Lop Where Malop ={0}", _Malop);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

    }
}
