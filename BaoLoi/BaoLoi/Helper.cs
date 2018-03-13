using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoLoi
{
    class Helper
    {
        public static Diem Laydiemcogocnhonhatsovoivector(List<Diem> lstDiem, Diem node, Vector vector, List<CosGoc> lstCos)
        {
            lstCos.Clear();
            List<Diem> newLstDiem = new List<Diem>();
            newLstDiem = lstDiem.FindAll(x => x.DiemID != node.DiemID);
         
            newLstDiem.ForEach(x =>
            {
                Vector tempV = new Vector() { X = x.X - node.X, Y = x.Y - node.Y };
                double tuso = tempV.X * vector.X + tempV.Y*vector.Y;
                double mauso = Math.Sqrt(tempV.X * tempV.X + tempV.Y * tempV.Y) * Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
                string toado = string.Format("({0};{1})", x.X, x.Y);
                CosGoc c = new CosGoc(toado, (tuso / mauso));
                lstCos.Add(c);
               
            });
            double max = lstCos[0].Cos;
            for(int j=0;j<lstCos.Count;j++)
            {
                if(max < lstCos[j].Cos) max = lstCos[j].Cos;
            }
               
            List<Diem> lstDiemMax = new List<Diem>();
            for (int i = 0; i < lstCos.Count; i++)
            {
                if (lstCos[i].Cos == max)
                    lstDiemMax.Add(newLstDiem[i]);
            }
            int min = lstDiemMax[0].X;
            lstDiemMax.ForEach(x =>
            {
                min = min > x.X ? x.X : min;
            });
            return lstDiemMax.Find(x => x.X == min);
        }
    }
}
