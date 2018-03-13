using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.Controller
{
    class HocController
    {
        public Hoc GetData(string id1,string id2)
        {
            string sql = string.Format("select * from Hoc where MaHS='{0}' and MaMH='{1}'", id1,id2);
            DataTable dt = sqlHelper.Query(sql);
            List<DataRow> list = dt.AsEnumerable().ToList();
            if (list.Count > 0)
            {
                Hoc H = new Hoc();
                H.MaMH = list[0].ItemArray[0].ToString();
                H.MaHS = list[0].ItemArray[1].ToString();
                H.DiemTongKet = list[0].ItemArray[2].ToString();
                return H;
            }
            return null;
        }
        public bool ThemH(string _MaMH, string _MaHS, string _DiemTongKet)
        {
            _DiemTongKet = _DiemTongKet.Replace(",", ".");
            string query = string.Format("INSERT INTO Hoc values ('{0}', '{1}', {2})",
                _MaMH, _MaHS, _DiemTongKet);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }
        public bool SuaH(string _MaMH, string _MaSV, string _DiemTongKet, string _MaMHID, string _MaSVID)
        {

            _DiemTongKet = _DiemTongKet.Replace(",", ".");
            string query = string.Format("update Hoc set MaMH='{0}',MaHS='{1}', DiemTongKet={2} where MaMH='{3}' and MaHS ='{4}'",
                _MaMH, _MaSV, _DiemTongKet, _MaMHID, _MaSVID);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool XoaH(string _MaMH, string _MaHS)
        {

            if (MessageBox.Show("Do you want delete data?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (sqlHelper.NonQuery("XoaHoc", new SqlParameter("@@MaMH", _MaMH), new SqlParameter("@maHS", _MaHS)))
                    return true;
                else return false;
            }
            else return false;
        }


        public bool CheckErr(string _MaMH, string _MaHS, string _DiemTongKet)
        {
            float dt;
            if (_MaMH == "") { MessageBox.Show("Trống Mã Môn Học", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_MaHS == "") { MessageBox.Show("Trống mã HS", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_DiemTongKet == "") { MessageBox.Show("Trống Điểm Tổng kết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            else
            {
                if (!float.TryParse(_DiemTongKet, out dt))
                {
                    MessageBox.Show("Lỗi điểm tổng kết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                }
            } 
            return true;
        }

    }
}
