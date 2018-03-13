using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoPhuc
{
    public class SoPhuc
    {
        public float pThuc { get; set; }
        public float pAo { get; set; }
        public SoPhuc()
        {
            this.pThuc = 0;
            this.pAo = 0;
        }
        public SoPhuc(float _pThuc, float _pAo)
        {
            this.pThuc = _pThuc;
            this.pAo = _pAo;
        }
        public static SoPhuc operator +(SoPhuc s1, SoPhuc s2)
        {
            return new SoPhuc(s1.pThuc + s2.pThuc, s1.pAo + s2.pAo);
        }

        public static SoPhuc operator -(SoPhuc s1, SoPhuc s2)
        {
            return new SoPhuc(s1.pThuc - s2.pThuc, s1.pAo - s2.pAo);
        }


        public static SoPhuc operator *(SoPhuc s1, SoPhuc s2)
        {
            return new SoPhuc(s1.pThuc * s2.pThuc - s1.pAo * s2.pAo, s1.pThuc * s2.pAo + s1.pAo * s2.pThuc);
        }
        public static SoPhuc operator /(SoPhuc s1, SoPhuc s2)
        {
            float tongbp;
            tongbp = s1.pThuc * s2.pThuc + s1.pAo * s2.pAo;
            return new SoPhuc((s1.pThuc * s1.pAo + s2.pThuc * s2.pAo) / tongbp, s1.pAo * s2.pThuc - s1.pThuc * s2.pAo);
        }
        //So sánh

        public double Modun()
        {
            return Math.Sqrt((this.pThuc * this.pThuc + this.pAo * this.pAo));
        }
        public static bool operator >(SoPhuc s1, SoPhuc s2)
        {
            return (s1.Modun() > s1.Modun()) ? true : false;
        }
        public static bool operator <(SoPhuc s1, SoPhuc s2)
        {
            return (s1.Modun() > s1.Modun()) ? true : false;
        }
        public static bool operator <=(SoPhuc s1, SoPhuc s2)
        {
            return (s1.Modun() > s1.Modun()) ? true : false;
        }
        public static bool operator >=(SoPhuc s1, SoPhuc s2)
        {
            return (s1.Modun() > s1.Modun()) ? true : false;
        }
        public static bool operator !=(SoPhuc s1, SoPhuc s2)
        {
            return (s1.Modun() != s1.Modun()) ? true : false;
        }
        public static bool operator ==(SoPhuc s1, SoPhuc s2)
        {
            return (s1.Modun() == s1.Modun()) ? true : false;
        }

        public void NhapSP()
        {
            Console.Write("Nhap phan thuc = ");
            this.pThuc = int.Parse(Console.ReadLine());
            Console.Write("Nhap phan ao = ");
            this.pAo = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            if (this.pAo < 0)
            {
                return this.pThuc + this.pAo + "*i";
            }
            else if (this.pThuc == 0)
            {
                return this.pAo + "*i";
            }
            else
                return this.pThuc + "+" + this.pAo + "*i";

        }
    }
}
