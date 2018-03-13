namespace CrackSipmleFacebook
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
            this.btnCrack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prsBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnCrack
            // 
            this.btnCrack.Location = new System.Drawing.Point(143, 28);
            this.btnCrack.Name = "btnCrack";
            this.btnCrack.Size = new System.Drawing.Size(75, 23);
            this.btnCrack.TabIndex = 0;
            this.btnCrack.Text = "Crack Now";
            this.btnCrack.UseVisualStyleBackColor = true;
            this.btnCrack.Click += new System.EventHandler(this.btnCrack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Design by PhucBinz";
            // 
            // prsBar
            // 
            this.prsBar.Location = new System.Drawing.Point(12, 71);
            this.prsBar.Name = "prsBar";
            this.prsBar.Size = new System.Drawing.Size(354, 23);
            this.prsBar.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 155);
            this.Controls.Add(this.prsBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crack ATP Simple Facebook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prsBar;
    }
}

