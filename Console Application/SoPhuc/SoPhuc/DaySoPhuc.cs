using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoPhuc
{
    class DaySoPhuc:SoPhuc
    {
        public int n { get; set; }
        public SoPhuc[] arrSP { get; set; }
        public DaySoPhuc()
        {
            this.n = 0;

        }
        public DaySoPhuc(int N)
        {
            this.n = N;
            this.arrSP = new SoPhuc[this.n];
        }
        public void NhapDSP()
        {
            Console.Write("Nhap n = ");

            this.n = Convert.ToInt16(Console.ReadLine());
            this.arrSP = new SoPhuc[this.n];
            for (int i = 0; i < this.n; i++)
            {

                Console.WriteLine("Nhap so phuc {0} : ", i + 1);
                this.arrSP[i] = new SoPhuc();
                this.arrSP[i].NhapSP();
            }
        }
        public void sort()
        {
            for (int i = 0; i < this.n - 1; i++)
            {
                for (int j = i + 1; j < this.n; j++)
                {
                    if (this.arrSP[i] < this.arrSP[j])
                    {
                        SoPhuc temp = this.arrSP[i];
                        this.arrSP[i] = this.arrSP[j];
                        this.arrSP[j] = temp;
                    }
                }
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Day so phuc da sap xep theo modul la : ");
            for (int i = 0; i < this.n; i++)
            {
                this.arrSP[i].ToString();
                Console.WriteLine();
            }
        }
    }
}
