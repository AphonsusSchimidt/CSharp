namespace DownlByLinkGgDrive
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
            this.btnGetLink = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtInPut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.bntIDM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetLink
            // 
            this.btnGetLink.Location = new System.Drawing.Point(15, 92);
            this.btnGetLink.Name = "btnGetLink";
            this.btnGetLink.Size = new System.Drawing.Size(75, 23);
            this.btnGetLink.TabIndex = 1;
            this.btnGetLink.Text = "GetLink";
            this.btnGetLink.UseVisualStyleBackColor = true;
            this.btnGetLink.Click += new System.EventHandler(this.btnGetLink_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(111, 92);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtInPut
            // 
            this.txtInPut.Location = new System.Drawing.Point(15, 42);
            this.txtInPut.Name = "txtInPut";
            this.txtInPut.Size = new System.Drawing.Size(371, 20);
            this.txtInPut.TabIndex = 0;
            this.txtInPut.Text = "Please enter link Google drive in text box !!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Link Google drive";
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = true;
            this.lblThongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongbao.ForeColor = System.Drawing.Color.DarkRed;
            this.lblThongbao.Location = new System.Drawing.Point(24, 132);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(0, 13);
            this.lblThongbao.TabIndex = 6;
            // 
            // bntIDM
            // 
            this.bntIDM.Location = new System.Drawing.Point(211, 91);
            this.bntIDM.Name = "bntIDM";
            this.bntIDM.Size = new System.Drawing.Size(75, 23);
            this.bntIDM.TabIndex = 7;
            this.bntIDM.Text = "Dl IDM";
            this.bntIDM.UseVisualStyleBackColor = true;
            this.bntIDM.Click += new System.EventHandler(this.bntIDM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 180);
            this.Controls.Add(this.bntIDM);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInPut);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnGetLink);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Download Link On GGdrive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetLink;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtInPut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.Button bntIDM;
    }
}

