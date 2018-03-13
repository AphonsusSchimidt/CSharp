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
    class LopController
    {
        public Lop GetData(string id)
        {
            string sql = string.Format("select * from Lop where Malop='{0}'", id);
            DataTable dt = sqlHelper.Query(sql);
            List<DataRow> list = dt.AsEnumerable().ToList();
            if (list.Count > 0)
            {
                Lop L = new Lop();
                L.Malop = list[0].ItemArray[0].ToString();
                L.ViTri = list[0].ItemArray[1].ToString();
                L.SiSo = list[0].ItemArray[2].ToString();
                L.MaGV = list[0].ItemArray[3].ToString();
                return L;
            }
            return null;
        }
        public bool ThemLop(string _Malop, string _ViTri, int SiSo, string _MaGV)
        {
            string query = string.Format("INSERT INTO Lop values ('{0}',N'{1}', {2},'{3}')",
                _Malop, _ViTri, SiSo,_MaGV);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool SuaLop(string _Malop, string _ViTri, int _SiSo,string _MaGV, string _MalopID)
        {
            string query = string.Format("update Lop set Malop='{0}',ViTri=N'{1}',SiSo={2},MaGV='{3}' where Malop='{4}'",
                _Malop, _ViTri, _SiSo, _MaGV, _MalopID);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool XoaLop(string _Malop, string _maLopThay)
        {
            //@maLop VARCHAR(9), @maLopThay VARCHAR(9)
            if (MessageBox.Show("Do you want delete data?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (sqlHelper.NonQuery("XoaLop", new SqlParameter("@maLop", _Malop), new SqlParameter("@maLopThay", _maLopThay)))
                    return true;
                else return false;
            }
            else return false;
        }
        public bool CheckErr(string _Malop, string _ViTri, string _SiSo,string _MaGV)
        {
            int siso;
            if (_Malop == "") { MessageBox.Show("Trống Mã Lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_ViTri == "") { MessageBox.Show("Trống Tên Vị Trí ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_MaGV == "") { MessageBox.Show("Trống Mã Giáo Viên ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (!int.TryParse(_SiSo, out siso))
            {
                MessageBox.Show("Lỗi sĩ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }
            return true;
        }


    }
}
