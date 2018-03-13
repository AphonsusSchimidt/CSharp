namespace BaoLoi
{
    partial class frmMain
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFindCos = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.radReset = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radDaGiac = new System.Windows.Forms.RadioButton();
            this.radRec = new System.Windows.Forms.RadioButton();
            this.btnKhoitao = new System.Windows.Forms.Button();
            this.dtgr = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSLDiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptb_pain = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblFindCos);
            this.groupBox3.Controls.Add(this.lblFind);
            this.groupBox3.Location = new System.Drawing.Point(9, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 94);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Điểm tìm được";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Thông Tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cos Max";
            // 
            // lblFindCos
            // 
            this.lblFindCos.AutoSize = true;
            this.lblFindCos.BackColor = System.Drawing.SystemColors.Control;
            this.lblFindCos.ForeColor = System.Drawing.Color.Red;
            this.lblFindCos.Location = new System.Drawing.Point(76, 29);
            this.lblFindCos.Name = "lblFindCos";
            this.lblFindCos.Size = new System.Drawing.Size(0, 13);
            this.lblFindCos.TabIndex = 9;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFind.Location = new System.Drawing.Point(76, 52);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(0, 13);
            this.lblFind.TabIndex = 10;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(190, 163);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // radReset
            // 
            this.radReset.AutoSize = true;
            this.radReset.Location = new System.Drawing.Point(9, 163);
            this.radReset.Name = "radReset";
            this.radReset.Size = new System.Drawing.Size(53, 17);
            this.radReset.TabIndex = 5;
            this.radReset.TabStop = true;
            this.radReset.Text = "Reset";
            this.radReset.UseVisualStyleBackColor = true;
            this.radReset.CheckedChanged += new System.EventHandler(this.radReset_CheckedChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(9, 94);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(36, 17);
            this.radAll.TabIndex = 4;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radDaGiac
            // 
            this.radDaGiac.AutoSize = true;
            this.radDaGiac.Location = new System.Drawing.Point(9, 140);
            this.radDaGiac.Name = "radDaGiac";
            this.radDaGiac.Size = new System.Drawing.Size(143, 17);
            this.radDaGiac.TabIndex = 3;
            this.radDaGiac.TabStop = true;
            this.radDaGiac.Text = "Đa giác lồi bao đóng min";
            this.radDaGiac.UseVisualStyleBackColor = true;
            this.radDaGiac.CheckedChanged += new System.EventHandler(this.radDaGiac_CheckedChanged);
            // 
            // radRec
            // 
            this.radRec.AutoSize = true;
            this.radRec.Location = new System.Drawing.Point(9, 117);
            this.radRec.Name = "radRec";
            this.radRec.Size = new System.Drawing.Size(170, 17);
            this.radRec.TabIndex = 3;
            this.radRec.TabStop = true;
            this.radRec.Text = "Hình chữ nhật ss trục có S min";
            this.radRec.UseVisualStyleBackColor = true;
            this.radRec.CheckedChanged += new System.EventHandler(this.radRec_CheckedChanged);
            // 
            // btnKhoitao
            // 
            this.btnKhoitao.Location = new System.Drawing.Point(121, 73);
            this.btnKhoitao.Name = "btnKhoitao";
            this.btnKhoitao.Size = new System.Drawing.Size(75, 23);
            this.btnKhoitao.TabIndex = 2;
            this.btnKhoitao.Text = "Khởi tạo";
            this.btnKhoitao.UseVisualStyleBackColor = true;
            this.btnKhoitao.Click += new System.EventHandler(this.btnKhoitao_Click);
            // 
            // dtgr
            // 
            this.dtgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgr.Location = new System.Drawing.Point(0, 0);
            this.dtgr.Name = "dtgr";
            this.dtgr.Size = new System.Drawing.Size(277, 291);
            this.dtgr.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 291);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số điểm";
            // 
            // txtSLDiem
            // 
            this.txtSLDiem.Location = new System.Drawing.Point(6, 47);
            this.txtSLDiem.Name = "txtSLDiem";
            this.txtSLDiem.Size = new System.Drawing.Size(190, 20);
            this.txtSLDiem.TabIndex = 0;
            this.txtSLDiem.Text = "15";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.radReset);
            this.groupBox2.Controls.Add(this.radAll);
            this.groupBox2.Controls.Add(this.radDaGiac);
            this.groupBox2.Controls.Add(this.radRec);
            this.groupBox2.Controls.Add(this.btnKhoitao);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSLDiem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(560, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 580);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptb_pain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 580);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture";
            // 
            // ptb_pain
            // 
            this.ptb_pain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_pain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_pain.Location = new System.Drawing.Point(3, 16);
            this.ptb_pain.Name = "ptb_pain";
            this.ptb_pain.Size = new System.Drawing.Size(554, 561);
            this.ptb_pain.TabIndex = 0;
            this.ptb_pain.TabStop = false;
            this.ptb_pain.Paint += new System.Windows.Forms.PaintEventHandler(this.ptb_pain_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFindCos;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton radReset;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radDaGiac;
        private System.Windows.Forms.RadioButton radRec;
        private System.Windows.Forms.Button btnKhoitao;
        private System.Windows.Forms.DataGridView dtgr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSLDiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptb_pain;
    }
}