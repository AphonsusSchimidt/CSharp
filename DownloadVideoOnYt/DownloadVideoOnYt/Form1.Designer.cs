namespace DownloadVideoOnYt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTaiVe = new System.Windows.Forms.Button();
            this.cmbLinkVideo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.hinhanh = new System.Windows.Forms.PictureBox();
            this.lblTenVideo = new System.Windows.Forms.Label();
            this.btnChonThuMuc = new System.Windows.Forms.Button();
            this.txtLuuTru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prc = new System.Windows.Forms.ToolStripProgressBar();
            this.lblDangTai = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaiVe
            // 
            this.btnTaiVe.BackColor = System.Drawing.Color.White;
            this.btnTaiVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiVe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTaiVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTaiVe.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiVe.Image")));
            this.btnTaiVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiVe.Location = new System.Drawing.Point(537, 265);
            this.btnTaiVe.Name = "btnTaiVe";
            this.btnTaiVe.Size = new System.Drawing.Size(97, 23);
            this.btnTaiVe.TabIndex = 25;
            this.btnTaiVe.Text = "Tải về";
            this.btnTaiVe.UseVisualStyleBackColor = false;
            // 
            // cmbLinkVideo
            // 
            this.cmbLinkVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinkVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLinkVideo.ForeColor = System.Drawing.Color.Blue;
            this.cmbLinkVideo.FormattingEnabled = true;
            this.cmbLinkVideo.Location = new System.Drawing.Point(344, 266);
            this.cmbLinkVideo.Name = "cmbLinkVideo";
            this.cmbLinkVideo.Size = new System.Drawing.Size(187, 21);
            this.cmbLinkVideo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(271, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Độ phân giải";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMoTa);
            this.groupBox1.Controls.Add(this.hinhanh);
            this.groupBox1.Controls.Add(this.lblTenVideo);
            this.groupBox1.Location = new System.Drawing.Point(35, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 175);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // lblMoTa
            // 
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMoTa.Location = new System.Drawing.Point(173, 49);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(426, 114);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // hinhanh
            // 
            this.hinhanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hinhanh.Image = ((System.Drawing.Image)(resources.GetObject("hinhanh.Image")));
            this.hinhanh.Location = new System.Drawing.Point(13, 15);
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Size = new System.Drawing.Size(150, 150);
            this.hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanh.TabIndex = 3;
            this.hinhanh.TabStop = false;
            // 
            // lblTenVideo
            // 
            this.lblTenVideo.ForeColor = System.Drawing.Color.Red;
            this.lblTenVideo.Location = new System.Drawing.Point(173, 16);
            this.lblTenVideo.Name = "lblTenVideo";
            this.lblTenVideo.Size = new System.Drawing.Size(426, 33);
            this.lblTenVideo.TabIndex = 4;
            this.lblTenVideo.Text = "Video:";
            // 
            // btnChonThuMuc
            // 
            this.btnChonThuMuc.BackColor = System.Drawing.Color.White;
            this.btnChonThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonThuMuc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChonThuMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonThuMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonThuMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnChonThuMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnChonThuMuc.Image")));
            this.btnChonThuMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonThuMuc.Location = new System.Drawing.Point(537, 232);
            this.btnChonThuMuc.Name = "btnChonThuMuc";
            this.btnChonThuMuc.Size = new System.Drawing.Size(97, 23);
            this.btnChonThuMuc.TabIndex = 21;
            this.btnChonThuMuc.Text = "   Chọn ...";
            this.btnChonThuMuc.UseVisualStyleBackColor = false;
            // 
            // txtLuuTru
            // 
            this.txtLuuTru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtLuuTru.Location = new System.Drawing.Point(88, 234);
            this.txtLuuTru.Name = "txtLuuTru";
            this.txtLuuTru.ReadOnly = true;
            this.txtLuuTru.Size = new System.Drawing.Size(442, 20);
            this.txtLuuTru.TabIndex = 20;
            this.txtLuuTru.Text = "C:\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(35, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lưu trữ:";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(537, 20);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(103, 23);
            this.btnView.TabIndex = 18;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtURL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtURL.ForeColor = System.Drawing.Color.Black;
            this.txtURL.Location = new System.Drawing.Point(115, 19);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(416, 25);
            this.txtURL.TabIndex = 17;
            this.txtURL.Text = "https://www.youtube.com/watch?v=1xFeazKh00I";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "URL video:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 10);
            this.panel1.TabIndex = 26;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prc,
            this.lblDangTai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prc
            // 
            this.prc.Name = "prc";
            this.prc.Size = new System.Drawing.Size(150, 16);
            this.prc.Visible = false;
            // 
            // lblDangTai
            // 
            this.lblDangTai.Name = "lblDangTai";
            this.lblDangTai.Size = new System.Drawing.Size(63, 17);
            this.lblDangTai.Text = "lblDangTai";
            this.lblDangTai.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 344);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTaiVe);
            this.Controls.Add(this.cmbLinkVideo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChonThuMuc);
            this.Controls.Add(this.txtLuuTru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaiVe;
        private System.Windows.Forms.ComboBox cmbLinkVideo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.PictureBox hinhanh;
        private System.Windows.Forms.Label lblTenVideo;
        private System.Windows.Forms.Button btnChonThuMuc;
        private System.Windows.Forms.TextBox txtLuuTru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar prc;
        private System.Windows.Forms.ToolStripStatusLabel lblDangTai;
    }
}

