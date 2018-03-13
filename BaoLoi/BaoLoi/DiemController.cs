using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BaoLoi
{
    class DiemController
    {
        public List<Diem> lstDiem = new List<Diem>();
        public Pen pDiem = new Pen(Color.Red);
        public Pen pBien = new Pen(Color.Blue);

        public void Init(int sodiem)
        {
            lstDiem.Clear();
            Random rd = new Random(DateTime.Now.Second);
            for (int i = 0; i < sodiem; i++)
            {
                Diem d = new Diem();
                d.DiemID = i;
                d.X = rd.Next(10, 530);
                d.Y = rd.Next(10, 530);
                lstDiem.Add(d);
                Thread.Sleep(1);
            }
        }

        public void Hinhchunhatchuviminbaodong(Graphics gr)
        {
            if (lstDiem.Count == 0) return;
            int X_min = lstDiem[0].X;
            int X_max = lstDiem[0].X;
            int Y_min = lstDiem[0].Y;
            int Y_max = lstDiem[0].Y;
            for (int i = 0; i < lstDiem.Count; i++)
            {
                X_min = X_min > lstDiem[i].X ? lstDiem[i].X : X_min;
                X_max = X_max < lstDiem[i].X ? lstDiem[i].X : X_max;
                Y_min = Y_min > lstDiem[i].Y ? lstDiem[i].Y : Y_min;
                Y_max = Y_max < lstDiem[i].Y ? lstDiem[i].Y : Y_max;
            }
            gr.DrawRectangle(pBien, X_min, Y_min, Math.Abs(X_max - X_min), Math.Abs(Y_max - Y_min));
        }
        public Diem Dagiacloi(Graphics gr, ref int numberShow,List<CosGoc> lstCos)
        {
            if (lstDiem.Count == 0) return null;
            int X_max = lstDiem[0].X;
            int Y_max = lstDiem[0].Y;
            Vector vector = new Vector() { X = 10, Y = 10 };
            for (int i = 0; i < lstDiem.Count; i++)
            {
                if (Y_max < lstDiem[i].Y)
                {
                    Y_max = lstDiem[i].Y;
                    X_max = lstDiem[i].X;
                }
                else if (Y_max == lstDiem[i].Y)
                {
                    Y_max = lstDiem[i].Y;
                    X_max = X_max < lstDiem[i].X ? lstDiem[i].X : X_max;
                }
            }
            Diem node = lstDiem.Find(x => x.X == X_max && x.Y == Y_max);
            vector.Show(gr, pBien, node);
            List<Diem> lstBien = new List<Diem>();
            lstBien.Add(node);

            //for (int i = 0; i < lstDiem.Count; i++)
            //{
            //    Diem newDiemBien = Helper.Laydiemcogocnhonhatsovoivector(lstDiem, node, vector, lstCos);
            //    if (lstBien.FindIndex(x => x.DiemID == newDiemBien.DiemID) < 0)
            //    {
            //        lstBien.Add(newDiemBien);
            //    }
            //    vector = new Vector() { X = newDiemBien.X - node.X, Y = newDiemBien.Y - node.Y };
            //    node = newDiemBien;
            //}


            Diem newDiemBien=null;
            node.DanhDau(gr, new Pen(Color.Gray));
            for (int i = 0; i < numberShow; i++)
            {
                 newDiemBien = Helper.Laydiemcogocnhonhatsovoivector(lstDiem, node, vector, lstCos);
                if (lstBien.FindIndex(x => x.DiemID == newDiemBien.DiemID) < 0)
                {
                    lstBien.Add(newDiemBien);
                }
                vector = new Vector() { X = newDiemBien.X - node.X, Y = newDiemBien.Y - node.Y };
                node = newDiemBien;
                newDiemBien.DanhDau(gr, new Pen(Color.Gray));
                //vector.Show(gr, pBien, node);
            }
            if (numberShow >= lstBien.Count)
                numberShow = lstBien.Count - 1;

            for (int i = 0; i < numberShow; i++)
            {
                lstBien[i].Veduongthang(gr, pBien, lstBien[i + 1]);
            }
            if (newDiemBien != null)
                if (newDiemBien.DiemID == lstBien[0].DiemID)
                lstBien[lstBien.Count - 1].Veduongthang(gr, pBien, lstBien[0]);
            return newDiemBien;
        }
        public void Show(Graphics gr)
        {
            if (lstDiem.Count == 0) return;
            for (int i = 0; i < lstDiem.Count; i++)
            {
                lstDiem[i].Show(gr, pDiem);
            }
        }
    }
}
