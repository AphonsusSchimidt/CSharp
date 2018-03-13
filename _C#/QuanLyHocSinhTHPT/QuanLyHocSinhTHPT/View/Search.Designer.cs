namespace QuanLyHocSinhTHPT.View
{
    partial class Search
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.txtInPutTk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kiểu tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Từ khóa";
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
            this.cbtype.Location = new System.Drawing.Point(257, 39);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(121, 21);
            this.cbtype.TabIndex = 10;
            this.cbtype.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
            // 
            // txtInPutTk
            // 
            this.txtInPutTk.Location = new System.Drawing.Point(38, 39);
            this.txtInPutTk.Name = "txtInPutTk";
            this.txtInPutTk.Size = new System.Drawing.Size(213, 20);
            this.txtInPutTk.TabIndex = 8;
            this.txtInPutTk.TextChanged += new System.EventHandler(this.txtInPutTk_TextChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 93);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.txtInPutTk);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.TextBox txtInPutTk;
    }
}