using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoLoi
{
    class Diem
    {
        public int DiemID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Show(Graphics gr, Pen p)
        {
            gr.DrawEllipse(p, X - 5, Y - 5, 4, 4);
            gr.DrawString("(" + X + "," + Y + ")", new Font("arial", 8f), new SolidBrush(Color.Black), X-10, Y-20);
        }
        public void DanhDau(Graphics gr, Pen p)
        {
            gr.DrawEllipse(p, X - 5, Y - 5, 10, 10);
            
            gr.DrawString("(" + X + "," + Y + ")", new Font("arial", 8f), new SolidBrush(Color.Yellow), X - 10, Y - 20);
        }
        public void Veduongthang(Graphics gr, Pen p, Diem node)
        {
            gr.DrawLine(p, X, Y, node.X, node.Y);
        }
    }
}
