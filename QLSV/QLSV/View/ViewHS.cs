using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.Model;
using QLSV.Controler;
using QLSV.Helper;
namespace QLSV.View
{
    class ViewHS
    {

        Controller hc = new Controller();  
        public void menu()
        {
            Console.Clear();
            Console.WriteLine("--------------QL DS HOC SINH--------------");
            Console.WriteLine("1. Thêm SV vào Danh Sách");
            Console.WriteLine("2. Sửa Thông Tin SV");
            Console.WriteLine("3. Xóa SV Khỏi Danh Sách");
            Console.WriteLine("4. Hiển Thị Danh Sách SV");
            Console.WriteLine("5. Thoát");
            Console.WriteLine("Lựa Chọn = ");
            char c = Console.ReadKey().KeyChar;
            Process(c);
     
        }
       
        public void Process(char c)
        {
            switch(c)
            {
                case '1':
                    ErrorHelper.Log(hc.AddNew(new SV(InputType.Them)));
                    break;
                case '2':
                    ErrorHelper.Log(hc.EDIT(new SV(InputType.Sua)));
                    break;
                case '3':
                    SV sv1= new SV(InputType.Xoa);
                    ErrorHelper.Log(hc.Delete(sv1.MaSV));
                    break;
                case '4':
                    ErrorHelper.Log(hc.viewList());
                    break;
                case '5':
                    break;
            }
            Console.ReadKey();
            menu();
        }
    }
}
