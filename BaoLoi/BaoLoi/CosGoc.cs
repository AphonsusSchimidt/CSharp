using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoLoi
{
    public class CosGoc
    {
        public string toado { get; set; }
        public double Cos { get; set; }
        public CosGoc(string id, double cos)
        {
            this.toado = id;
            this.Cos = cos;
        }
    }
}
