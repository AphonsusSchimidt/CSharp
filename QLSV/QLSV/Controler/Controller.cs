using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.Helper;
using QLSV.Model;

namespace QLSV.Controler
{
    class Controller
    {
        List<SV> HS = new List<SV>();
        public ErrorType AddNew(SV Sv1)
        {
            if (HS.Count == 0)
            {
                HS.Add(Sv1);
                return ErrorType.Done;
            }
            else
            {
                int check = HS.FindIndex(x => x.MaSV == Sv1.MaSV);
                if (check != -1)
                    return ErrorType.DuplicateID;
                else
                {
                    HS.Add(Sv1);
                    return ErrorType.Done;
                }
            }
        }
        public ErrorType EDIT(SV Sv1)
        {
            if (HS.Count == 0) return ErrorType.EmptyList;
            else
            {

                int check = HS.FindIndex(x => x.MaSV == Sv1.MaSV);
                if (check != -1)
                {
                    HS.Add(Sv1);
                    return ErrorType.Done;
                }
                else return ErrorType.Err;

            }
        }
        public ErrorType Delete(int ID)
        {
            if (HS.Count == 0) return ErrorType.EmptyList;
            else
            {
                int check = HS.FindIndex(x => x.MaSV == ID);
                if (check != -1)
                {
                    HS.RemoveAt(check);
                    return ErrorType.Done;
                }
                else return ErrorType.Err;
            }
        }
         public ErrorType viewList()
        {
            if (HS.Count == 0) return ErrorType.EmptyList;
            else
            {
                HS.ForEach(x => x.HienThi());
                return ErrorType.Done;
            }
        }
    }
}
