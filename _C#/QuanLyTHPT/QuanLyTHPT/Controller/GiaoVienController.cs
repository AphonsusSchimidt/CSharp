using QuanLyHocSinhTHPT.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                _MaGV, _HoTen, _NgaySinh, _GioiTinh, _Sdt, _QueQuan, _MaGV);
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
