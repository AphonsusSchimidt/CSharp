using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoLoi
{
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Show(Graphics gr, Pen p, Diem node)
        {
            gr.DrawLine(p, node.X, node.Y, node.X + X, node.Y + Y);
        }
    }
}
