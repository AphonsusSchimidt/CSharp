using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeDieuHanh
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Int32[,] Arr1;
        Int32[,] Arr2;
        Int32[,] ArrKQ;
        TextBox[] show;
        
        private void Xuli(int index, int N, int P)
        {
            //index--;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    ArrKQ[index, i] += Arr1[index, j] * Arr2[j, i];
                    show[index].Text += ArrKQ[index, i].ToString();
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            #region

            //int M = 4, N = 6, P = 5;
            //Arr1 = new int[M, P];
            //for (int v = 0; v < M; v++)
            //{
            //    for (int k = 0; k < P; k++)
            //    {
            //        Arr1[v, k] = 3;
            //    }
            //}
            //Arr2 = new int[P, N];
            //for (int v = 0; v < P; v++)
            //    for (int k = 0; k < N; k++)
            //    {
            //        Arr2[v, k] = 2;
            //    }
            //ArrKQ = new int[M, N];

            //Thread[] thr = new Thread[M];
            //show = new TextBox[M];
            //for (int index = 0; index < M; index++)
            //{
            //    thr[index] = new Thread(() => Xuli(index, N, P));
            //    thr[index].Start();
            //    show[index] = new TextBox();
            //    show[index].Location = new Point(100, index * 20);
            //    this.Controls.Add(show[index]);
            //}
            #endregion



        }
    }
}
