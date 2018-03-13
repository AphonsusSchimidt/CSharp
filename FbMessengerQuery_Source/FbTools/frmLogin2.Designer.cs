namespace FbTools
{
    partial class frmLogin2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin2));
            this.web = new Gecko.GeckoWebBrowser();
            this.tm_XoaNoiDung = new System.Windows.Forms.Timer(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTuLuc = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDenLuc = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnLoadTinNhan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tm_XuLyTinNhan = new System.Windows.Forms.Timer(this.components);
            this.tabMain = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.tab1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.web2 = new Gecko.GeckoWebBrowser();
            this.chkImgOffline = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.btnDangNhap = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.linkFb = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.linkWeb = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.groupDangNhap = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.txtPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUser = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.groupDanhSach = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnDongChuongTrinh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnKetXuat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkTaiTextDuyNhat = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonWrapLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.btnSpam = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLuuTru = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.btnDaLoc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDangCho = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTinNhanDen = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab1)).BeginInit();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDangNhap.Panel)).BeginInit();
            this.groupDangNhap.Panel.SuspendLayout();
            this.groupDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDanhSach.Panel)).BeginInit();
            this.groupDanhSach.Panel.SuspendLayout();
            this.groupDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.Name = "web";
            this.web.NoDefaultContextMenu = true;
            this.web.Size = new System.Drawing.Size(446, 569);
            this.web.TabIndex = 4;
            this.web.UseHttpActivityObserver = false;
            // 
            // tm_XoaNoiDung
            // 
            this.tm_XoaNoiDung.Tick += new System.EventHandler(this.tm_XoaNoiDung_Tick);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(254, 110);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(103, 20);
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonLabel1.Values.Image")));
            this.kryptonLabel1.Values.Text = "Cho đến ngày";
            // 
            // txtTuLuc
            // 
            this.txtTuLuc.AllowButtonSpecToolTips = true;
            this.txtTuLuc.AutoShift = true;
            this.txtTuLuc.CalendarTodayText = "Hôm nay:";
            this.txtTuLuc.Checked = false;
            this.txtTuLuc.CustomFormat = "dd/MM/yyyy HH:mm";
            this.txtTuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTuLuc.Location = new System.Drawing.Point(353, 110);
            this.txtTuLuc.Name = "txtTuLuc";
            this.txtTuLuc.ShowCheckBox = true;
            this.txtTuLuc.Size = new System.Drawing.Size(143, 21);
            this.txtTuLuc.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txtTuLuc.TabIndex = 11;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(9, 110);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(101, 20);
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonLabel2.Values.Image")));
            this.kryptonLabel2.Values.Text = "Ngày bắt đầu";
            // 
            // txtDenLuc
            // 
            this.txtDenLuc.AllowButtonSpecToolTips = true;
            this.txtDenLuc.AutoShift = true;
            this.txtDenLuc.CalendarTodayText = "Hôm nay:";
            this.txtDenLuc.Checked = false;
            this.txtDenLuc.CustomFormat = "dd/MM/yyyy HH:mm";
            this.txtDenLuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDenLuc.Location = new System.Drawing.Point(110, 110);
            this.txtDenLuc.Name = "txtDenLuc";
            this.txtDenLuc.ShowCheckBox = true;
            this.txtDenLuc.Size = new System.Drawing.Size(143, 21);
            this.txtDenLuc.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txtDenLuc.TabIndex = 13;
            // 
            // btnLoadTinNhan
            // 
            this.btnLoadTinNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadTinNhan.Location = new System.Drawing.Point(9, 190);
            this.btnLoadTinNhan.Name = "btnLoadTinNhan";
            this.btnLoadTinNhan.Size = new System.Drawing.Size(143, 25);
            this.btnLoadTinNhan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoadTinNhan.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnLoadTinNhan.TabIndex = 14;
            this.btnLoadTinNhan.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadTinNhan.Values.Image")));
            this.btnLoadTinNhan.Values.Text = "Tải tin nhắn";
            this.btnLoadTinNhan.Click += new System.EventHandler(this.btnLoadTinNhan_Click);
            // 
            // tm_XuLyTinNhan
            // 
            this.tm_XuLyTinNhan.Interval = 50;
            this.tm_XuLyTinNhan.Tick += new System.EventHandler(this.tm_XuLyTinNhan_Tick);
            // 
            // tabMain
            // 
            this.tabMain.AllowPageReorder = false;
            this.tabMain.AllowTabFocus = false;
            this.tabMain.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.tabMain.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.tabMain.Button.NextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.tabMain.Button.PreviousButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.tabMain.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.tab1,
            this.kryptonPage2});
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(448, 598);
            this.tabMain.TabIndex = 16;
            // 
            // tab1
            // 
            this.tab1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tab1.Controls.Add(this.web);
            this.tab1.Flags = 65534;
            this.tab1.ImageSmall = ((System.Drawing.Image)(resources.GetObject("tab1.ImageSmall")));
            this.tab1.LastVisibleSet = true;
            this.tab1.MinimumSize = new System.Drawing.Size(50, 50);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(446, 569);
            this.tab1.Text = "Trang Facebook Messenger";
            this.tab1.ToolTipTitle = "Page ToolTip";
            this.tab1.UniqueName = "7610E331C45249DF0BA370056C703887";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.web2);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonPage2.ImageSmall")));
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(446, 569);
            this.kryptonPage2.Text = "Nội Dung Hội Thoại";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "4B509236DDB94AF3C588055634B74259";
            // 
            // web2
            // 
            this.web2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web2.Location = new System.Drawing.Point(0, 0);
            this.web2.Name = "web2";
            this.web2.NoDefaultContextMenu = true;
            this.web2.Size = new System.Drawing.Size(446, 569);
            this.web2.TabIndex = 5;
            this.web2.UseHttpActivityObserver = false;
            // 
            // chkImgOffline
            // 
            this.chkImgOffline.Location = new System.Drawing.Point(9, 164);
            this.chkImgOffline.Name = "chkImgOffline";
            this.chkImgOffline.Size = new System.Drawing.Size(481, 20);
            this.chkImgOffline.TabIndex = 17;
            this.chkImgOffline.Values.Text = "Tải hình ảnh offline, convert hình ảnh thành dạng base 64 và nhúng vào file kết x" +
    "uất";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Location = new System.Drawing.Point(385, 42);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(116, 25);
            this.btnDangNhap.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnDangNhap.TabIndex = 18;
            this.btnDangNhap.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Values.Image")));
            this.btnDangNhap.Values.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.pic);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.linkFb);
            this.kryptonPanel2.Controls.Add(this.kryptonGroup3);
            this.kryptonPanel2.Controls.Add(this.linkWeb);
            this.kryptonPanel2.Controls.Add(this.groupDangNhap);
            this.kryptonPanel2.Controls.Add(this.groupDanhSach);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(974, 611);
            this.kryptonPanel2.TabIndex = 22;
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(461, 367);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(506, 209);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 37;
            this.pic.TabStop = false;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(461, 583);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(164, 20);
            this.kryptonLabel3.TabIndex = 36;
            this.kryptonLabel3.Values.Text = "Email: hainh2k3@gmail.com";
            // 
            // linkFb
            // 
            this.linkFb.Location = new System.Drawing.Point(757, 582);
            this.linkFb.Name = "linkFb";
            this.linkFb.Size = new System.Drawing.Size(211, 20);
            this.linkFb.TabIndex = 35;
            this.linkFb.Values.Text = "https://www.facebook.com/hpskynet";
            this.linkFb.LinkClicked += new System.EventHandler(this.linkFb_LinkClicked);
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.Location = new System.Drawing.Point(4, 5);
            this.kryptonGroup3.Name = "kryptonGroup3";
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonPanel4);
            this.kryptonGroup3.Size = new System.Drawing.Size(450, 600);
            this.kryptonGroup3.TabIndex = 23;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.tabMain);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(448, 598);
            this.kryptonPanel4.TabIndex = 1;
            // 
            // linkWeb
            // 
            this.linkWeb.Location = new System.Drawing.Point(642, 582);
            this.linkWeb.Name = "linkWeb";
            this.linkWeb.Size = new System.Drawing.Size(102, 20);
            this.linkWeb.TabIndex = 34;
            this.linkWeb.Values.Text = "http://hainh.com";
            this.linkWeb.LinkClicked += new System.EventHandler(this.linkWeb_LinkClicked);
            // 
            // groupDangNhap
            // 
            this.groupDangNhap.Location = new System.Drawing.Point(459, 5);
            this.groupDangNhap.Name = "groupDangNhap";
            // 
            // groupDangNhap.Panel
            // 
            this.groupDangNhap.Panel.Controls.Add(this.kryptonPanel3);
            this.groupDangNhap.Panel.Controls.Add(this.kryptonHeader2);
            this.groupDangNhap.Size = new System.Drawing.Size(508, 101);
            this.groupDangNhap.TabIndex = 22;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonWrapLabel1);
            this.kryptonPanel3.Controls.Add(this.txtPass);
            this.kryptonPanel3.Controls.Add(this.txtUser);
            this.kryptonPanel3.Controls.Add(this.btnDangNhap);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 21);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(506, 78);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.AutoSize = false;
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(9, 8);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(492, 34);
            this.kryptonWrapLabel1.Text = "Nhập email hoặc số điện thoại vào, chương trình sẽ tự động điền tài khoản và mật " +
    "khẩu này vào trang đăng nhập facebook và chuyển đến trang danh sách tin nhắn của" +
    " bạn.";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(202, 45);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(177, 19);
            this.txtPass.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPass.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPass.StateCommon.Border.Width = 1;
            this.txtPass.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPass.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPass.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txtPass.TabIndex = 22;
            this.txtPass.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(9, 45);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(187, 19);
            this.txtUser.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUser.StateCommon.Border.Width = 1;
            this.txtUser.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.txtUser.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUser.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txtUser.TabIndex = 21;
            this.txtUser.Text = "Tên đăng nhập";
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(506, 21);
            this.kryptonHeader2.StateDisabled.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonHeader2.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeader2.StateDisabled.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonHeader2.TabIndex = 0;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Đăng nhập bằng tài khoản facebook";
            this.kryptonHeader2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader2.Values.Image")));
            // 
            // groupDanhSach
            // 
            this.groupDanhSach.Enabled = false;
            this.groupDanhSach.Location = new System.Drawing.Point(460, 112);
            this.groupDanhSach.Name = "groupDanhSach";
            // 
            // groupDanhSach.Panel
            // 
            this.groupDanhSach.Panel.Controls.Add(this.kryptonPanel1);
            this.groupDanhSach.Panel.Controls.Add(this.kryptonHeader1);
            this.groupDanhSach.Size = new System.Drawing.Size(507, 249);
            this.groupDanhSach.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.groupDanhSach.TabIndex = 21;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txtTuLuc);
            this.kryptonPanel1.Controls.Add(this.btnDongChuongTrinh);
            this.kryptonPanel1.Controls.Add(this.btnKetXuat);
            this.kryptonPanel1.Controls.Add(this.chkTaiTextDuyNhat);
            this.kryptonPanel1.Controls.Add(this.kryptonWrapLabel2);
            this.kryptonPanel1.Controls.Add(this.btnSpam);
            this.kryptonPanel1.Controls.Add(this.btnLuuTru);
            this.kryptonPanel1.Controls.Add(this.kryptonCheckBox1);
            this.kryptonPanel1.Controls.Add(this.btnDaLoc);
            this.kryptonPanel1.Controls.Add(this.btnDangCho);
            this.kryptonPanel1.Controls.Add(this.btnTinNhanDen);
            this.kryptonPanel1.Controls.Add(this.chkImgOffline);
            this.kryptonPanel1.Controls.Add(this.btnLoadTinNhan);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txtDenLuc);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 21);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(505, 226);
            this.kryptonPanel1.StateDisabled.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnDongChuongTrinh
            // 
            this.btnDongChuongTrinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDongChuongTrinh.Location = new System.Drawing.Point(347, 190);
            this.btnDongChuongTrinh.Name = "btnDongChuongTrinh";
            this.btnDongChuongTrinh.Size = new System.Drawing.Size(143, 25);
            this.btnDongChuongTrinh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongChuongTrinh.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnDongChuongTrinh.TabIndex = 33;
            this.btnDongChuongTrinh.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnDongChuongTrinh.Values.Image")));
            this.btnDongChuongTrinh.Values.Text = "Đóng chương trình";
            this.btnDongChuongTrinh.Click += new System.EventHandler(this.btnDongChuongTrinh_Click);
            // 
            // btnKetXuat
            // 
            this.btnKetXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKetXuat.Location = new System.Drawing.Point(176, 190);
            this.btnKetXuat.Name = "btnKetXuat";
            this.btnKetXuat.Size = new System.Drawing.Size(143, 25);
            this.btnKetXuat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKetXuat.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnKetXuat.TabIndex = 32;
            this.btnKetXuat.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnKetXuat.Values.Image")));
            this.btnKetXuat.Values.Text = "Kết xuât HTML";
            this.btnKetXuat.Click += new System.EventHandler(this.btnKetXuat_Click);
            // 
            // chkTaiTextDuyNhat
            // 
            this.chkTaiTextDuyNhat.Location = new System.Drawing.Point(9, 138);
            this.chkTaiTextDuyNhat.Name = "chkTaiTextDuyNhat";
            this.chkTaiTextDuyNhat.Size = new System.Drawing.Size(394, 20);
            this.chkTaiTextDuyNhat.TabIndex = 31;
            this.chkTaiTextDuyNhat.Values.Text = "Chi tải text duy nhất, bỏ qua hình ảnh, video có trong nội dung chat";
            // 
            // kryptonWrapLabel2
            // 
            this.kryptonWrapLabel2.AutoSize = false;
            this.kryptonWrapLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel2.Location = new System.Drawing.Point(9, 68);
            this.kryptonWrapLabel2.Name = "kryptonWrapLabel2";
            this.kryptonWrapLabel2.Size = new System.Drawing.Size(492, 34);
            this.kryptonWrapLabel2.Text = "Lọc tin nhắn theo ngày, chương trình sẽ tải nội dung tin nhắn bắt đầu từ lúc \"Cho" +
    " đến ngày\" và chạy ngược về \"Ngày bắt đầu\"";
            // 
            // btnSpam
            // 
            this.btnSpam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpam.Location = new System.Drawing.Point(397, 34);
            this.btnSpam.Name = "btnSpam";
            this.btnSpam.Size = new System.Drawing.Size(98, 25);
            this.btnSpam.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnSpam.TabIndex = 28;
            this.btnSpam.Values.Text = "Spam";
            this.btnSpam.Click += new System.EventHandler(this.btnSpam_Click);
            // 
            // btnLuuTru
            // 
            this.btnLuuTru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuTru.Location = new System.Drawing.Point(301, 34);
            this.btnLuuTru.Name = "btnLuuTru";
            this.btnLuuTru.Size = new System.Drawing.Size(88, 25);
            this.btnLuuTru.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnLuuTru.TabIndex = 27;
            this.btnLuuTru.Values.Text = "Lưu trữ";
            this.btnLuuTru.Click += new System.EventHandler(this.btnLuuTru_Click);
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Checked = true;
            this.kryptonCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kryptonCheckBox1.Location = new System.Drawing.Point(8, 8);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(288, 20);
            this.kryptonCheckBox1.TabIndex = 24;
            this.kryptonCheckBox1.Values.Text = "Ẩn các chức năng thao tác với nội dung tin nhắn";
            // 
            // btnDaLoc
            // 
            this.btnDaLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaLoc.Location = new System.Drawing.Point(204, 34);
            this.btnDaLoc.Name = "btnDaLoc";
            this.btnDaLoc.Size = new System.Drawing.Size(90, 25);
            this.btnDaLoc.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnDaLoc.TabIndex = 26;
            this.btnDaLoc.Values.Text = "Đã lọc";
            this.btnDaLoc.Click += new System.EventHandler(this.btnDaLoc_Click);
            // 
            // btnDangCho
            // 
            this.btnDangCho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangCho.Location = new System.Drawing.Point(107, 34);
            this.btnDangCho.Name = "btnDangCho";
            this.btnDangCho.Size = new System.Drawing.Size(90, 25);
            this.btnDangCho.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnDangCho.TabIndex = 25;
            this.btnDangCho.Values.Text = "Đang chờ";
            this.btnDangCho.Click += new System.EventHandler(this.btnDangCho_Click);
            // 
            // btnTinNhanDen
            // 
            this.btnTinNhanDen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinNhanDen.Location = new System.Drawing.Point(9, 34);
            this.btnTinNhanDen.Name = "btnTinNhanDen";
            this.btnTinNhanDen.Size = new System.Drawing.Size(90, 25);
            this.btnTinNhanDen.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnTinNhanDen.TabIndex = 24;
            this.btnTinNhanDen.Values.Text = "Tin nhắn đến";
            this.btnTinNhanDen.Click += new System.EventHandler(this.btnTinNhanDen_Click);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(505, 21);
            this.kryptonHeader1.TabIndex = 0;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Thao tác với danh sách tin nhắn";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // frmLogin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 611);
            this.Controls.Add(this.kryptonPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FbMessenger Query 1.0 - Kết xuất nội dung chat facebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin2_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab1)).EndInit();
            this.tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupDangNhap.Panel)).EndInit();
            this.groupDangNhap.Panel.ResumeLayout(false);
            this.groupDangNhap.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDangNhap)).EndInit();
            this.groupDangNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDanhSach.Panel)).EndInit();
            this.groupDanhSach.Panel.ResumeLayout(false);
            this.groupDanhSach.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDanhSach)).EndInit();
            this.groupDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gecko.GeckoWebBrowser web;
        private System.Windows.Forms.Timer tm_XoaNoiDung;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker txtTuLuc;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker txtDenLuc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLoadTinNhan;
        private System.Windows.Forms.Timer tm_XuLyTinNhan;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator tabMain;
        private ComponentFactory.Krypton.Navigator.KryptonPage tab1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private Gecko.GeckoWebBrowser web2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkImgOffline;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDangNhap;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup groupDangNhap;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUser;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup groupDanhSach;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDaLoc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDangCho;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTinNhanDen;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSpam;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLuuTru;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkTaiTextDuyNhat;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDongChuongTrinh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnKetXuat;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel linkFb;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel linkWeb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.PictureBox pic;
    }
}