using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    class ps
    {
        public float ts { get; set; }
        public float ms { get; set; }

        public ps()
        {
            this.ts = 0;
            this.ms = 0;
        }
        public ps(float _ts, float _ms)
        {
            this.ts = _ts;
            this.ms = _ms;
        }


        private bool kiem_tra_mau_so(float ms)
        {
            return ms != 0;
        }

    
        public static ps operator +(ps ps1, ps ps2)
        { 
            return new ps(ps1.ts * ps2.ms + ps2.ts * ps1.ms, ps1.ms * ps2.ms);
        }
        public static ps operator -(ps ps1, ps ps2) 
        {
            return new ps(ps1.ts * ps2.ms - ps2.ts * ps1.ms, ps1.ms * ps2.ms);
        }
        public static ps operator *(ps ps1, ps ps2)
        {
            return new ps(ps1.ts * ps2.ts, ps1.ms * ps2.ms);
        }
        public static ps operator /(ps ps1, ps ps2)
        {
            return new ps(ps1.ts * ps2.ms, ps1.ms * ps2.ts);
        }

        public bool SoSanh(ps a) 
        {
            float x;
            float y;
            if (ms != a.ms)
            {
                x = ts * a.ms;
                y = ms * a.ts;
            }
            else
            {
                y = ts;
                x = a.ts;
            }
            if (x > y)
                return true;
            return false;
        }
        public float UCLN(float a, float b)
        {
            a = Math.Abs(ts);
            b = Math.Abs(ms);
            while (a != b && b != 0 && a != 0)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        public void RutGonps() 
        {
            float uoc = UCLN(ts, ms);
            if (uoc != 0)
            {
                this.ts = (float)ts / uoc;
                this.ms = ms / uoc;
            }
            else
            {
                this.ts = ts;
                this.ms = ms;
            }     
        } 
        public override string ToString()
        {
            this.RutGonps();
            if (ts == 0) return "Loi Fomat";
            else if(ms==1) return this.ts.ToString();
            return this.ts + "/" +this.ms;
        }
    }
}
