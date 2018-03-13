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

namespace Thread_OS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        Int32[,] Arr1;
        Int32[,] Arr2;
        Int32[,] ArrKQ;
        TextBox[,] show;
        TextBox[,] getIn1;
        TextBox[,] getIn2;
        int M, N, P;
        private void button1_Click(object sender, EventArgs e)
        {
            
            ArrKQ = new int[M, N];

            Thread[] thr = new Thread[M];
            show = new TextBox[M,N];
            for (int i = 0; i < M; i++ )
            {
                for( int j = 0; j < N; j++)
                {
                    show[i, j] = new TextBox();
                    show[i, j].Location = new Point(250 + j* 45, 30 + i * 20);
                    show[i, j].Size = new System.Drawing.Size(40, 20);
                    panel3.Controls.Add(show[i,j]);
                }
            }
            for (int index = 0; index < M; index++)
            {
                thr[index] = new Thread(() => Xuli(index, N, P));
                thr[index].Start();
            }
        }
        private void Xuli(int index, int N, int P)
        {
            if(index==M) index--;
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < P; j++)
                {
                    ArrKQ[index, i] += Arr1[index, j] * Arr2[j, i];
                    Thread.Sleep(100);
                }
                show[index,i].Text = ArrKQ[index, i].ToString();
            }
            
        }

        private void Grp_input2_Enter(object sender, EventArgs e)
        {

        }

        private void btnsinh1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (txtcot1.Text.Trim() != "")
            {
                try 
                {
                    P = int.Parse(txtcot1.Text);
                    txthang2.Text = P.ToString();
                }
                catch
                {
                    MessageBox.Show("Lỗi", "Phải nhập đúng giá trị",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }  
            else { MessageBox.Show("Thiếu", "Erros"); return; }
            if (txthang1.Text.Trim() != "")
            {
                try
                {
                    M = int.Parse(txthang1.Text);
                }
                catch
                {
                    MessageBox.Show("Lỗi", "Phải nhập đúng giá trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else { MessageBox.Show("Thiếu", "Erros"); return; }
            Arr1 = new int[M, P];
            getIn1 = new TextBox[M, P];
            for (int v = 0; v < M; v++)
            {
                for (int k = 0; k < P; k++)
                {
                    getIn1[v, k] = new TextBox();
                    getIn1[v, k].Location = new Point(20 + k * 45, 10 + v * 30);
                    getIn1[v, k].Size = new System.Drawing.Size(40, 20);
                    panel1.Controls.Add(getIn1[v, k]);
                }
            }
        }

        private void btnsinh2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            if (txthang2.Text.Trim() != "")
            {
                int temp = 0;
                try
                {
                    temp = int.Parse(txthang2.Text);
                }
                catch
                {
                    MessageBox.Show("Lỗi, Phải nhập đúng giá trị", "Erros");
                    return;
                }
                if(temp!=P)
                {
                    MessageBox.Show("Số Hàng của ma trận 2 phải bằng số Hàng của ma trận 1","Erros");
                    txthang2.Text = P.ToString();
                    return;
                }
            }
            else { MessageBox.Show("Thiếu", "Erros"); return; }
            if (txtcot2.Text.Trim() != "")
            {
                try
                {
                    N = int.Parse(txtcot2.Text);
                }
                catch
                {
                    MessageBox.Show("Lỗi, Phải nhập đúng giá trị", "Erros");
                    return;
                }
            }
            else { MessageBox.Show("Thiếu", "Erros"); return; }
            Arr2 = new int[P, N];
            getIn2 = new TextBox[P, N];
            for (int v = 0; v < P; v++)
            {
                for (int k = 0; k < N; k++)
                {
                    getIn2[v, k] = new TextBox();
                    getIn2[v, k].Location = new Point(20 + k * 45, 10 + v * 30);
                    getIn2[v, k].Size = new System.Drawing.Size(40, 20);
                    panel2.Controls.Add(getIn2[v, k]);
                }
            }
        }

        private void btnlay1_Click(object sender, EventArgs e)
        {
            if((M==0)||(P==0))
            {
                MessageBox.Show("Nhập vào các giá trị cần thiết trước khi lấy", "Erros");
                return;
            }
            else 
            {
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < P; j++)
                    {
                        if (getIn1[i, j].Text.Trim()!="")
                        {
                            try
                            {
                                Arr1[i, j] = int.Parse(getIn1[i, j].Text.Trim());
                            }
                            catch
                            {
                                MessageBox.Show("Lỗi, Phải nhập đúng giá trị", "Erros");
                                return;
                            }
                        }
                    }
                }
                MessageBox.Show("Nhập dữ liệu cho ma trận 1 thành công", "Thành Công");
            }
        }

        private void btnlay2_Click(object sender, EventArgs e)
        {
            {
                if ((N == 0) || (P == 0))
                {
                    MessageBox.Show("Nhập vào các giá trị cần thiết trước khi lấy", "Erros");
                    return;
                }
                else
                {
                    for (int i = 0; i < P; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            if (getIn2[i, j].Text.Trim() != "")
                            {
                                try
                                {
                                    Arr2[i, j] = int.Parse(getIn2[i, j].Text.Trim());
                                }
                                catch
                                {
                                    MessageBox.Show("Lỗi, Phải nhập đúng giá trị", "Erros");
                                    return;
                                }
                            }
                        }
                    }
                    MessageBox.Show("Nhập dữ liệu cho ma trận 2 thành công", "Thành Công");
                }
            }
        }

    }
}
