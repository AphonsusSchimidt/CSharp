using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Reflection;
using System.Text;


using System.Windows.Forms;

namespace ReadDataEX
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

      
        private void BtnImport_Click(object sender, EventArgs e)
        {
            List<ClassBase> objlst = new List<ClassBase>();
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "(Flie excel)|*.xlsx";
            of.ShowDialog();
            object[,] DataGet = null;
            if (of.FileName != "")
            {


                dtgr1.DataSource = null;
                dtgr1.DataSource = ExcelController.ReadData<HocSinh>(of.FileName);
            }

            else
            {
                MessageBox.Show("No file select", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "(Flie excel)|*.xlsx";
            sf.ShowDialog();

            if (sf.FileName != "")
            {

                if (1!= 0)
                {
                    string[] str = { "Họ Tên", "Năm Sinh", "Quê Quán", "Địa Chỉ", "Họ Tên Bố", "Họ Tên Mẹ" };
                    //  ExcelController.Write(sf.FileName, listHS, str , "Thông Tin Học Sinh", 3, 3);
                    MessageBox.Show("Save Success", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Data", "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
