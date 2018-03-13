using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgoDinhPhuc_15150178
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }
        List<SinhVien> lst = new List<SinhVien>();
        string Tenfle = "SinVien.txt";
        public void Hienthi()
        {
            dtvSV.DataSource = lst;
            dtvSV.Refresh();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtHoTen.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtLop.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtNgaySinh.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtDiemTk.Text.Trim() == "") { MessageBox.Show("Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            bool GT=false;
            if(ckNam.Checked)
            {
                GT = true;
            }
            DateTime ns = DateTime.Parse(txtNgaySinh.Text.Trim());
            double diemtk = double.Parse(txtDiemTk.Text.Trim());
            lst = SinhVienCotroller.addInList(lst,txtMaSV.Text.Trim(), txtHoTen.Text.Trim(), ns, GT, txtLop.Text.Trim(), diemtk);
            SinhVienCotroller.GhiFile(Tenfle,lst);
            lst = SinhVienCotroller.docFile(Tenfle);
            Hienthi();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lst = SinhVienCotroller.docFile(Tenfle);
            Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
