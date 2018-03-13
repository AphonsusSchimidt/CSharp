namespace Client
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.rtbChatContain = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llblColor = new System.Windows.Forms.LinkLabel();
            this.lLblFont = new System.Windows.Forms.LinkLabel();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(55, 55);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(281, 20);
            this.txtIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(351, 54);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(75, 23);
            this.btnKetNoi.TabIndex = 2;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // rtbChatContain
            // 
            this.rtbChatContain.Location = new System.Drawing.Point(35, 93);
            this.rtbChatContain.Name = "rtbChatContain";
            this.rtbChatContain.Size = new System.Drawing.Size(358, 137);
            this.rtbChatContain.TabIndex = 3;
            this.rtbChatContain.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llblColor);
            this.groupBox1.Controls.Add(this.lLblFont);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.rtbChat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // llblColor
            // 
            this.llblColor.AutoSize = true;
            this.llblColor.Location = new System.Drawing.Point(82, 16);
            this.llblColor.Name = "llblColor";
            this.llblColor.Size = new System.Drawing.Size(31, 13);
            this.llblColor.TabIndex = 9;
            this.llblColor.TabStop = true;
            this.llblColor.Text = "Color";
            this.llblColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblColor_LinkClicked);
            // 
            // lLblFont
            // 
            this.lLblFont.AutoSize = true;
            this.lLblFont.Location = new System.Drawing.Point(32, 16);
            this.lLblFont.Name = "lLblFont";
            this.lLblFont.Size = new System.Drawing.Size(28, 13);
            this.lLblFont.TabIndex = 8;
            this.lLblFont.TabStop = true;
            this.lLblFont.Text = "Font";
            this.lLblFont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblFont_LinkClicked);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(351, 71);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(35, 38);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(301, 56);
            this.rtbChat.TabIndex = 6;
            this.rtbChat.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 20);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên: ";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbChatContain);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClient";
            this.Text = "Chat Program";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.RichTextBox rtbChatContain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llblColor;
        private System.Windows.Forms.LinkLabel lLblFont;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
    }
}

