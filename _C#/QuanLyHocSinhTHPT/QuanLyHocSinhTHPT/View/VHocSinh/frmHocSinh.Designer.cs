namespace QuanLyHocSinhTHPT.View.VHocSinh
{
    partial class frmHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocSinh));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnTimKiem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lblSoBanGhi = new DevExpress.XtraBars.BarStaticItem();
            this.btnStart = new DevExpress.XtraBars.BarButtonItem();
            this.btnBack = new DevExpress.XtraBars.BarButtonItem();
            this.btnNext = new DevExpress.XtraBars.BarButtonItem();
            this.btnEnd = new DevExpress.XtraBars.BarButtonItem();
            this.lblpage = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Thống Kê";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Print";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTimKiem);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Caption = "Tìm Kiếm";
            this.btnTimKiem.Id = 7;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.LargeImage")));
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTimKiem_ItemClick);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnXoa);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 5;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSua);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 4;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức Năng";
            // 
            // dtgrv
            // 
            this.dtgrv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrv.Location = new System.Drawing.Point(0, 141);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.Size = new System.Drawing.Size(915, 343);
            this.dtgrv.TabIndex = 6;
            this.dtgrv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_CellClick);
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.lblSoBanGhi);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnStart);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnBack);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnNext);
            this.ribbonStatusBar1.ItemLinks.Add(this.btnEnd);
            this.ribbonStatusBar1.ItemLinks.Add(this.lblpage);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 484);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(915, 27);
            // 
            // lblSoBanGhi
            // 
            this.lblSoBanGhi.Id = 9;
            this.lblSoBanGhi.Name = "lblSoBanGhi";
            // 
            // btnStart
            // 
            this.btnStart.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnStart.Id = 10;
            this.btnStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.ImageOptions.Image")));
            this.btnStart.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStart.ImageOptions.LargeImage")));
            this.btnStart.Name = "btnStart";
            this.btnStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStart_ItemClick);
            // 
            // btnBack
            // 
            this.btnBack.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnBack.Id = 11;
            this.btnBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageOptions.Image")));
            this.btnBack.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageOptions.LargeImage")));
            this.btnBack.Name = "btnBack";
            this.btnBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBack_ItemClick);
            // 
            // btnNext
            // 
            this.btnNext.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnNext.Id = 12;
            this.btnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.Image")));
            this.btnNext.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.LargeImage")));
            this.btnNext.Name = "btnNext";
            this.btnNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNext_ItemClick);
            // 
            // btnEnd
            // 
            this.btnEnd.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnEnd.Id = 13;
            this.btnEnd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEnd.ImageOptions.Image")));
            this.btnEnd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEnd.ImageOptions.LargeImage")));
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEnd_ItemClick);
            // 
            // lblpage
            // 
            this.lblpage.Id = 14;
            this.lblpage.Name = "lblpage";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.barButtonItem4,
            this.btnTimKiem,
            this.lblSoBanGhi,
            this.btnStart,
            this.btnBack,
            this.btnNext,
            this.btnEnd,
            this.lblpage});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(915, 141);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 511);
            this.Controls.Add(this.dtgrv);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Học Sinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnTimKiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private System.Windows.Forms.DataGridView dtgrv;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarStaticItem lblSoBanGhi;
        private DevExpress.XtraBars.BarButtonItem btnStart;
        private DevExpress.XtraBars.BarButtonItem btnBack;
        private DevExpress.XtraBars.BarButtonItem btnNext;
        private DevExpress.XtraBars.BarButtonItem btnEnd;
        private DevExpress.XtraBars.BarStaticItem lblpage;
    }
}