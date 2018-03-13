using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Helper
{
    enum ErrorType
    {
        Done,
        DuplicateID,
        Err,
        EmptyList

    }
    class ErrorHelper
    { 
         public static void Log(ErrorType ER)
        {
             switch(ER)
             {
                 case ErrorType.DuplicateID:
                     Console.WriteLine("Trùng");
                     break;
                 case ErrorType.EmptyList:
                     Console.WriteLine("Danh Sánh Rỗng");
                     break;
                 case ErrorType.Err:
                     Console.WriteLine("Lỗi Thực Thi");
                     break;
                 case ErrorType.Done:
                     Console.WriteLine("Hoàn Thành");
                     break;
             }
        }
    
    }
}
