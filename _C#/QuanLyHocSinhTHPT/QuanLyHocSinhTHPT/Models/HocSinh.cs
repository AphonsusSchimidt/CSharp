using Dapper;
using QuanLyHocSinhTHPT.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
   public class HocSinh
    {
        [DisplayName("Mã học sinh")]
        public string MaHS { get; set; }
        [DisplayName("Họ Tên")]
        public string HoTen { get; set; }
        [DisplayName("Quê quán")]
        public string QueQuan { get; set; }
        private string _gioiTinh;
        [DisplayName("Giới tính")]
        public string GioiTinh
        {
            get
            {
                return _gioiTinh;
            }
            set
            {
                string temp = value;
                if (temp.ToLower() == "true" || temp.ToLower() == "1")
                    _gioiTinh = "Nam";
                else
                    _gioiTinh = "Nữ";
            }
        }
        [DisplayName("Ngày Sinh")]
        public string NgaySinh { get; set; }
        [DisplayName("Tên Bố")]
        public string TenBo { get; set; }
        [DisplayName("Tên Mẹ")]
        public string TenMe { get; set; }
        [DisplayName("Mã Lớp")]
        public string MaLop { get; set; }
        public HocSinh(string _MaHS,string _HoTen, string _QueQuan, string _GioiTinh, string _NgaySinh, string _TenBo, string _TenMe, string _MaLop)
        {
            this.MaHS = _MaHS;
            this.HoTen = _HoTen;
            this.QueQuan = _QueQuan;
            this.GioiTinh = _GioiTinh;
            this.NgaySinh = _NgaySinh;
            this.TenBo = _TenBo;
            this.TenMe = _TenMe;
            this.MaLop = _MaLop;
        }
        public HocSinh()
        {
            this.MaHS = "";
            this.HoTen = "";
            this.QueQuan = "";
            this.GioiTinh = "";
            this.NgaySinh = "";
            this.TenBo = "";
            this.TenMe = "";
            this.MaLop = "";
        }
    }

    public class HocSinhController
    {
        public List<HocSinh> Get(int page, int numberRecord)
        {
            List<HocSinh> hocsinhs = new List<HocSinh>();
            hocsinhs.Clear();
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                hocsinhs = connection.Query<HocSinh>("Hocsinh_Get",
                    new
                    {
                        page = page,
                        numberRecord = numberRecord
                    },
                    commandType: CommandType.StoredProcedure)
                    .ToList();
                return hocsinhs;
            }
        }
        public void Post(HocSinh hocsinh)
        {
            using(var connection = DB.ConnectionFactory())
            {
                connection.Open();
                using(var transaction = connection.BeginTransaction())
                {
                    int hocsinhId = connection.Execute("Hocsinh_Insert",
                        new
                        {

                        },
                        commandType: CommandType.StoredProcedure,
                        transaction: transaction);

                    transaction.Commit();
                }
            }
        }
        public void Put(HocSinh hocsinh)
        {
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    int hocsinhId = connection.Execute("Hocsinh_Insert",
                        new
                        {

                        },
                        commandType: CommandType.StoredProcedure,
                        transaction: transaction);

                    transaction.Commit();
                }
            }
        }
        public void Delete(string id)
        {
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    int hocsinhId = connection.Execute("Hocsinh_Insert",
                        new
                        {

                        },
                        commandType: CommandType.StoredProcedure,
                        transaction: transaction);

                    transaction.Commit();
                }
            }
        }
    }
}
