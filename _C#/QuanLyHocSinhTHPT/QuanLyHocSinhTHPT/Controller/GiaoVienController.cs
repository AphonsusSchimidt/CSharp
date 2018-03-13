using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHocSinhTHPT.Controller
{
    class GiaoVienController
    {
        public GiaoVien GetData(string id)
        {
            string sql = string.Format("select * from GiaoVien where MaGV='{0}'", id);
            DataTable dt = sqlHelper.Query(sql);
            List<DataRow> list = dt.AsEnumerable().ToList();
            if(list.Count>0)
            {
                GiaoVien gv = new GiaoVien();
                gv.MaGV = list[0].ItemArray[0].ToString();
                gv.HoTen = list[0].ItemArray[1].ToString();
                gv.NgaySinh = list[0].ItemArray[2].ToString();
                gv.GioiTinh = list[0].ItemArray[3].ToString();
                gv.Sdt = list[0].ItemArray[4].ToString();
                gv.QueQuan = list[0].ItemArray[5].ToString();
                return gv;
            }
            return null;
        }
        public bool ThemGV(string _MaGV, string _HoTen, string NgaySinh, int _GioiTinh, string _Sdt, string _QueQuan)
        {
            string query = string.Format("INSERT INTO GiaoVien values ('{0}', N'{1}', '{2}',{3},'{4}',N'{5}')",
                _MaGV, _HoTen, NgaySinh, _GioiTinh, _Sdt, _QueQuan);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool SuaGV(string _MaGV, string _HoTen, string _NgaySinh, int _GioiTinh, string _Sdt, string _QueQuan)
        {
            string query = string.Format("update GiaoVien set MaGV='{0}', HoTen=N'{1}', NgaySinh='{2}',GioiTinh={3},Sdt='{4}',QueQuan=N'{5}' where MaGV='{6}' ",
                _MaGV, _HoTen, _NgaySinh, _GioiTinh, _Sdt, _QueQuan, _MaGV);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool XoaGV(string _MaGV, string _maGVThay)
        {
           // XoaGV  @maGV VARCHAR(9), @maGVThay VARCHAR(9)
            if (MessageBox.Show("Do you want delete data?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (sqlHelper.NonQuery("XoaGV", new SqlParameter("@maGV", _MaGV), new SqlParameter("@maGVThay", _maGVThay)))
                    return true;
                else return false;
            }
            else return false;
        }
        public bool CheckErr(string _MaGV, string _HoTen, string _NgaySinh, int _GioiTinh, string _Sdt, string _QueQuan)
        {
            DateTime dt;
            if (_MaGV == "") { MessageBox.Show("Trống Mã GV", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_HoTen == "") { MessageBox.Show("Trống Họ Tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_NgaySinh == "") { MessageBox.Show("Trống Ngày Sinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            else
            {
                if (!DateTime.TryParse(_NgaySinh, out dt))
                {
                    MessageBox.Show("Lỗi Ngày Sinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                }
            }
            if (_Sdt == "") { MessageBox.Show("Trống số diện thoại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            else
            {
                int sdt;
                if (_Sdt.Length < 9 || !int.TryParse(_Sdt, out sdt))
                {
                    MessageBox.Show("số diện thoại không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                }
            }
            if (_QueQuan == "") { MessageBox.Show("Trống quê quán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            return true;
        }



    }
}
