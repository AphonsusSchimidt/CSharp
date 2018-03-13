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
    class HocSinhController
    {
        public HocSinh GetData(string id)
        {
            string sql = string.Format("select * from HocSinh where MaHS='{0}'", id);
            DataTable dt = sqlHelper.Query(sql);
            List<DataRow> list = dt.AsEnumerable().ToList();
            if (list.Count > 0)
            {
                HocSinh hs = new HocSinh();
                hs.MaHS = list[0].ItemArray[0].ToString();
                hs.HoTen = list[0].ItemArray[1].ToString();
                hs.QueQuan = list[0].ItemArray[2].ToString();
                hs.GioiTinh = list[0].ItemArray[3].ToString();
                hs.NgaySinh = list[0].ItemArray[4].ToString();
                hs.TenBo = list[0].ItemArray[5].ToString();
                hs.TenMe = list[0].ItemArray[6].ToString();
                hs.MaLop = list[0].ItemArray[7].ToString();
                return hs;
            }
            return null;
        }
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
            string query = string.Format("update HocSinh set MaHS='{0}',HoTen=N'{1}',QueQuan= N'{2}',GioiTinh={3},NgaySinh='{4}',TenBo=N'{5}',TenMe=N'{6}',MaLop='{7}' where MaHS='{8}'",
                _MaHS, _HoTen, _QueQuan, _GioiTinh, _NgaySinh, _TenBo, _TenMe, _MaLop, _MaHS);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool Xoa(string _MaHS)
        {
            if (MessageBox.Show("Do you want delete data?", "Note", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (sqlHelper.NonQuery("XoaHS", new SqlParameter("@maHS", _MaHS)))
                    return true;
                else return false;
            }
            else return false;
        }

        public DataTable Timkiem(int mode, string key)
        {
            string query= "Select * from HocSinh";
            switch (mode)
            {
                case 0://all
                    query = string.Format("Select * from HocSinh  Where  MaHS ='{0}' or HoTen Like N'%{1}%' or MaLop ='{2}' or TenBo Like N'%{3}%' or  TenMe Like N'%{4}%' or QueQuan Like N'%{5}%' ", key, key, key, key, key, key);
                    break;
                case 1://Mã Học Sinh
                    query = string.Format("Select * from HocSinh  Where MaHS Like '%{0}%'", key);
                    break;
                case 2://Họ Tên
                    query = string.Format("Select * from HocSinh  Where HoTen Like N'%{0}%'", key);
                    break;
                case 3://Lớp
                    query = string.Format("Select * from HocSinh  Where MaLop Like '%{0}%'", key);
                    break;
                case 4://Họ Tên Bố
                    query = string.Format("Select * from HocSinh  Where TenBo Like N'%{0}%'", key);
                    break;
                case 5://Họ Tên Mẹ
                    query = string.Format("Select * from HocSinh  Where TenMe Like N'%{0}%'", key);
                    break;
                case 6://Địa Chỉ
                    query = string.Format("Select * from HocSinh  Where QueQuan Like N'%{0}%'", key);
                    break;

            }
            DataTable dt = new DataTable();
            dt = sqlHelper.Query(query);
            if (dt != null)
            {
                return dt;
            }
            else return null;
        }

        public bool CheckErr(string _MaHS, string _HoTen, string _QueQuan,
            int _GioiTinh, string _NgaySinh, string _TenBo,
            string _TenMe)
        {
            DateTime dt;
            if (_MaHS == "") { MessageBox.Show("Trống Mã SV", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_HoTen == "") { MessageBox.Show("Trống Họ Tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_TenBo == "") { MessageBox.Show("Trống Họ Tên bố", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_TenMe == "") { MessageBox.Show("Trống Họ Tên mẹ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_NgaySinh == "") { MessageBox.Show("Trống Ngày Sinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            else
            {
                if (!DateTime.TryParse(_NgaySinh, out dt))
                {
                    MessageBox.Show("Lỗi Ngày Sinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                }
            }
            if (_QueQuan == "") { MessageBox.Show("Trống quê quán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            return true;
        }
    }
}
