using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien_3layer.Models;
namespace QuanLySinhVien_3layer.Helper
{
    class SingletonData
    {
        private static SingletonData _instance = null;
        private SingletonData() { }
        public static SingletonData Getlates()
        {
            if (_instance == null)
                _instance = new SingletonData();
            return _instance;
        }
        ///////////////
        public Account nguoidung;
    }
}
