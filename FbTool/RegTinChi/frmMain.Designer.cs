namespace RegTinChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.spl = new System.Windows.Forms.SplitContainer();
            this.dm = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsename = new System.Windows.Forms.TextBox();
            this.web1 = new Gecko.GeckoWebBrowser();
            this.txtdm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spl)).BeginInit();
            this.spl.Panel1.SuspendLayout();
            this.spl.Panel2.SuspendLayout();
            this.spl.SuspendLayout();
            this.SuspendLayout();
            // 
            // spl
            // 
            this.spl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl.Location = new System.Drawing.Point(0, 0);
            this.spl.Name = "spl";
            // 
            // spl.Panel1
            // 
            this.spl.Panel1.AutoScroll = true;
            this.spl.Panel1.Controls.Add(this.txtdm);
            this.spl.Panel1.Controls.Add(this.dm);
            this.spl.Panel1.Controls.Add(this.btnLogout);
            this.spl.Panel1.Controls.Add(this.label2);
            this.spl.Panel1.Controls.Add(this.label1);
            this.spl.Panel1.Controls.Add(this.btnLogin);
            this.spl.Panel1.Controls.Add(this.txtPass);
            this.spl.Panel1.Controls.Add(this.txtUsename);
            // 
            // spl.Panel2
            // 
            this.spl.Panel2.Controls.Add(this.web1);
            this.spl.Size = new System.Drawing.Size(714, 422);
            this.spl.SplitterDistance = 255;
            this.spl.TabIndex = 1;
            // 
            // dm
            // 
            this.dm.Location = new System.Drawing.Point(12, 271);
            this.dm.Name = "dm";
            this.dm.Size = new System.Drawing.Size(133, 23);
            this.dm.TabIndex = 9;
            this.dm.Text = "Chửi nó";
            this.dm.UseVisualStyleBackColor = true;
            this.dm.Click += new System.EventHandler(this.dm_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 181);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên truy cập ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 137);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 102);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(200, 20);
            this.txtPass.TabIndex = 6;
            // 
            // txtUsename
            // 
            this.txtUsename.Location = new System.Drawing.Point(12, 55);
            this.txtUsename.Name = "txtUsename";
            this.txtUsename.Size = new System.Drawing.Size(201, 20);
            this.txtUsename.TabIndex = 5;
            // 
            // web1
            // 
            this.web1.Cursor = System.Windows.Forms.Cursors.No;
            this.web1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web1.Location = new System.Drawing.Point(0, 0);
            this.web1.Name = "web1";
            this.web1.Size = new System.Drawing.Size(455, 422);
            this.web1.TabIndex = 2;
            this.web1.UseHttpActivityObserver = false;
            // 
            // txtdm
            // 
            this.txtdm.Location = new System.Drawing.Point(12, 245);
            this.txtdm.Name = "txtdm";
            this.txtdm.Size = new System.Drawing.Size(201, 20);
            this.txtdm.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 422);
            this.Controls.Add(this.spl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fb-kBz";
            this.spl.Panel1.ResumeLayout(false);
            this.spl.Panel1.PerformLayout();
            this.spl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl)).EndInit();
            this.spl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer spl;
        private Gecko.GeckoWebBrowser web1;      
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsename;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button dm;
        private System.Windows.Forms.TextBox txtdm;
    }
}