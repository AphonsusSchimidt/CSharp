using QuanLyHocSinhTHPT.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Controller
{
    class HocController
    {
        public bool ThemH(string _MaMH, string _MaSV, float _DiemTongKet)
        {
            string query = string.Format("INSERT INTO GiaoVien values ('{0}', '{1}', {2})",
                _MaMH, _MaSV, _DiemTongKet);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool SuaH(string _MaMH, string _MaSV, float _DiemTongKet, string _MaMHID, string _MaSVID)
        {
            string query = string.Format("INSERT INTO GiaoVien values (MaMH='{0}',MaSV='{1}', DiemTongKet={2} where MaMH='{3}' and MaSV ='{4}' )",
                _MaMH, _MaSV, _DiemTongKet, _MaMHID, _MaSVID);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool XoaH(string _MaMH, string _MaSV)
        {

            string query = string.Format("delete from GiaoVien  Where MaGV ={0} and MaSV={1} ", _MaMH, _MaSV);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

    }
}
