namespace QuanLyHocSinhTHPT.View.VMonHoc
{
    partial class TimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiem));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.txtInPutTk = new System.Windows.Forms.TextBox();
            this.btnSubmitTk = new System.Windows.Forms.Button();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // txtInPutTk
            // 
            this.txtInPutTk.Location = new System.Drawing.Point(14, 41);
            this.txtInPutTk.Name = "txtInPutTk";
            this.txtInPutTk.Size = new System.Drawing.Size(213, 21);
            this.txtInPutTk.TabIndex = 3;
            // 
            // btnSubmitTk
            // 
            this.btnSubmitTk.Location = new System.Drawing.Point(371, 41);
            this.btnSubmitTk.Name = "btnSubmitTk";
            this.btnSubmitTk.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitTk.TabIndex = 4;
            this.btnSubmitTk.Text = "Tìm Kiếm";
            this.btnSubmitTk.UseVisualStyleBackColor = true;
            this.btnSubmitTk.Click += new System.EventHandler(this.btnSubmitTk_Click);
            // 
            // cbtype
            // 
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "All",
            "Mã Học Sinh",
            "Họ Tên",
            "Lớp",
            "Họ Tên Bố",
            "Họ Tên Mẹ",
            "Địa Chỉ",
            "Ngày Sinh",
            "Giới Tinh"});
            this.cbtype.Location = new System.Drawing.Point(233, 41);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(121, 21);
            this.cbtype.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ khóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kiểu tìm kiếm";
            // 
            // TimKiem
            // 
            this.AcceptButton = this.btnSubmitTk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 113);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.btnSubmitTk);
            this.Controls.Add(this.txtInPutTk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tim Kiếm Học Sinh";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.TextBox txtInPutTk;
        private System.Windows.Forms.Button btnSubmitTk;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}