namespace QuanLyHocSinhTHPT.View
{
    partial class frmDanhMucMH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucMH));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.lblTheo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFist = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbTimKiem);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHeSo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenMonHoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaMon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.cbbType);
            this.grbTimKiem.Controls.Add(this.lblTheo);
            this.grbTimKiem.Controls.Add(this.label4);
            this.grbTimKiem.Controls.Add(this.txtTimKiem);
            this.grbTimKiem.Location = new System.Drawing.Point(479, 6);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(313, 85);
            this.grbTimKiem.TabIndex = 10;
            this.grbTimKiem.TabStop = false;
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Mã Môn",
            "Tên Môn",
            "Hệ Số"});
            this.cbbType.Location = new System.Drawing.Point(169, 43);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(101, 21);
            this.cbbType.TabIndex = 3;
            // 
            // lblTheo
            // 
            this.lblTheo.AutoSize = true;
            this.lblTheo.Location = new System.Drawing.Point(166, 21);
            this.lblTheo.Name = "lblTheo";
            this.lblTheo.Size = new System.Drawing.Size(32, 13);
            this.lblTheo.TabIndex = 2;
            this.lblTheo.Text = "Theo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(15, 43);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(132, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnLast);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnFist);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 37);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(726, 10);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(63, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(588, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(657, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(63, 23);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(519, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(450, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(63, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(216, 10);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(63, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(147, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(78, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnFist
            // 
            this.btnFist.Location = new System.Drawing.Point(9, 10);
            this.btnFist.Name = "btnFist";
            this.btnFist.Size = new System.Drawing.Size(63, 23);
            this.btnFist.TabIndex = 0;
            this.btnFist.Text = "|<";
            this.btnFist.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hệ số";
            // 
            // txtHeSo
            // 
            this.txtHeSo.Location = new System.Drawing.Point(90, 63);
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.Size = new System.Drawing.Size(312, 20);
            this.txtHeSo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên môn học";
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Location = new System.Drawing.Point(90, 37);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(312, 20);
            this.txtTenMonHoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã môn";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(90, 11);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(132, 20);
            this.txtMaMon.TabIndex = 0;
            // 
            // dtgrv
            // 
            this.dtgrv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrv.Location = new System.Drawing.Point(0, 0);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.Size = new System.Drawing.Size(805, 207);
            this.dtgrv.TabIndex = 0;
            this.dtgrv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_CellClick);
            // 
            // frmDanhMucMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 336);
            this.Controls.Add(this.dtgrv);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDanhMucMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục môn học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhMucMH_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFist;
        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label lblTheo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}