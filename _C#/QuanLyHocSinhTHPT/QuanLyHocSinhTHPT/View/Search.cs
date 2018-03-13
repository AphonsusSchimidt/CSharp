using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyHocSinhTHPT.View.VHocSinh.frmHocSinh;

namespace QuanLyHocSinhTHPT.View
{
    public partial class Search : Form
    {
        public string Key { get; set; }
        public string Type { get; set; }
        public List<string> TypeSearch { get; set; }
        public Button btnClick { get; set; }
        public Search()
        {
            btnClick = new Button();
            InitializeComponent();
        }
        private void Search_Load(object sender, EventArgs e)
        {
            //cbtype.DataSource = TypeSearch;
            //cmb
            //TypeSearch.ForEach(x =>
            //{
            //    cbtype.Items.Add(x);
            //});
            cbtype.Items.AddRange(TypeSearch.ToArray());
            this.Controls.Add(btnClick);
            btnClick.Location = new Point(403, 37);
            btnClick.Size = new Size(75, 23);
            btnClick.Text = "Search";
        }

        private void txtInPutTk_TextChanged(object sender, EventArgs e)
        {
            Key = txtInPutTk.Text;
        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type = cbtype.SelectedItem.ToString();
        }
    }
}
