using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace BaoLoi
{
    public partial class frmMain : Form
    {
        DiemController dContr = new DiemController();
        bool HinhCN = false;
        bool HinhDG = false;
        int numberShow = 0;
        public frmMain()
        {
            InitializeComponent();
        }
       
        private void btnNext_Click(object sender, EventArgs e)
        {
            numberShow++;
            ptb_pain.Refresh();
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            numberShow = 0;
            dContr.Init(int.Parse(txtSLDiem.Text));
            ptb_pain.Refresh();
        }

        private void ptb_pain_Paint(object sender, PaintEventArgs e)
        {

            List<CosGoc> cosL = new List<CosGoc>();
            if (HinhCN)
                dContr.Hinhchunhatchuviminbaodong(e.Graphics);
            if (HinhDG)
            {
                Diem d = new Diem();
                d = dContr.Dagiacloi(e.Graphics, ref numberShow, cosL);
                if (d != null)
                    lblFind.Text = string.Format("ID= {0} Tọa Độ ({1};{2})", d.DiemID, d.X, d.Y);
                dtgr.DataSource = cosL;
                if (cosL.Count > 0)
                {
                    double max = cosL[0].Cos;
                    for (int j = 0; j < cosL.Count; j++)
                    {
                        if (max < cosL[j].Cos) max = cosL[j].Cos;
                    }
                    lblFindCos.Text = max.ToString();
                }
              
            }
            dContr.Show(e.Graphics);
            
            
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
         
            groupBox3.Visible = true;
            dtgr.Visible = true;
            btnNext.Visible = true;
            HinhCN = true;
            HinhDG = true;
            ptb_pain.Refresh();

           
        }

        private void radRec_CheckedChanged(object sender, EventArgs e)
        {
            dtgr.Visible = false;
            btnNext.Visible = false;
            groupBox3.Visible = false;
            HinhCN = true;
            HinhDG = false;
            ptb_pain.Refresh();
         
        }

        private void radDaGiac_CheckedChanged(object sender, EventArgs e)
        {

            groupBox3.Visible = true;
            dtgr.Visible = true;
            btnNext.Visible = true;
            HinhCN = false;
            HinhDG = true;
            ptb_pain.Refresh();
        }

        private void radReset_CheckedChanged(object sender, EventArgs e)
        {
            HinhCN = false;
            HinhDG = false;
            dtgr.DataSource = null;
            ptb_pain.Refresh();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dtgr.Visible = false;
            btnNext.Visible = false;
            groupBox3.Visible = false;
        }
    }
}
