namespace RegTinChi
{
    partial class web3
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
            this.web12 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // web12
            // 
            this.web12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web12.Location = new System.Drawing.Point(0, 0);
            this.web12.MinimumSize = new System.Drawing.Size(20, 20);
            this.web12.Name = "web12";
            this.web12.Size = new System.Drawing.Size(284, 261);
            this.web12.TabIndex = 0;
            this.web12.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web12_DocumentCompleted);
            // 
            // web3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.web12);
            this.Name = "web3";
            this.Text = "web3";
            this.Load += new System.EventHandler(this.web3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser web12;
    }
}