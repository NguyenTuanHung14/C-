namespace MiniStopApplication.GUI
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnShowForm = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnViewFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewCategoryFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewTable = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewBill = new DevExpress.XtraBars.BarButtonItem();
            this.btnStatistic = new DevExpress.XtraBars.BarButtonItem();
            this.bsTextDate = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnLog = new DevExpress.XtraBars.BarButtonItem();
            this.btnSendMail = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.txtCaption = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCateogry = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupStatictis = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnShowForm,
            this.barSubItem1,
            this.btnViewFood,
            this.btnViewCategoryFood,
            this.btnViewTable,
            this.btnAccountInfo,
            this.btnLogOut,
            this.btnViewAccount,
            this.btnViewBill,
            this.btnStatistic,
            this.bsTextDate,
            this.ribbonGalleryBarItem1,
            this.btnBackup,
            this.btnRestore,
            this.btnLog,
            this.btnSendMail,
            this.skinPaletteDropDownButtonItem1,
            this.skinRibbonGalleryBarItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.txtCaption,
            this.barButtonItem6});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 27;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage,
            this.ribbonPageManager});
            this.ribbon.QuickToolbarItemLinks.Add(this.txtCaption);
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1367, 176);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btnShowForm
            // 
            this.btnShowForm.Caption = "Tác vụ";
            this.btnShowForm.Id = 2;
            this.btnShowForm.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShowForm.ImageOptions.SvgImage")));
            this.btnShowForm.LargeWidth = 75;
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnShowForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowForm_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 3;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnViewFood
            // 
            this.btnViewFood.Caption = "Hàng hóa";
            this.btnViewFood.Id = 4;
            this.btnViewFood.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewFood.ImageOptions.SvgImage")));
            this.btnViewFood.LargeWidth = 75;
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnViewFood.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewFood_ItemClick);
            // 
            // btnViewCategoryFood
            // 
            this.btnViewCategoryFood.Caption = "Danh mục";
            this.btnViewCategoryFood.Id = 5;
            this.btnViewCategoryFood.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewCategoryFood.ImageOptions.SvgImage")));
            this.btnViewCategoryFood.LargeWidth = 75;
            this.btnViewCategoryFood.Name = "btnViewCategoryFood";
            this.btnViewCategoryFood.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnViewCategoryFood.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewCategoryFood_ItemClick);
            // 
            // btnViewTable
            // 
            this.btnViewTable.Caption = "Bàn";
            this.btnViewTable.Id = 6;
            this.btnViewTable.LargeWidth = 75;
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.Caption = "Thông tin tài khoản";
            this.btnAccountInfo.Id = 7;
            this.btnAccountInfo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAccountInfo.ImageOptions.SvgImage")));
            this.btnAccountInfo.LargeWidth = 75;
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAccountInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccountInfo_ItemClick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 8;
            this.btnLogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogOut.ImageOptions.SvgImage")));
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Caption = "Nhân viên";
            this.btnViewAccount.Id = 9;
            this.btnViewAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewAccount.ImageOptions.SvgImage")));
            this.btnViewAccount.LargeWidth = 75;
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnViewAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewAccount_ItemClick);
            // 
            // btnViewBill
            // 
            this.btnViewBill.Caption = "Doanh thu";
            this.btnViewBill.Id = 10;
            this.btnViewBill.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewBill.ImageOptions.SvgImage")));
            this.btnViewBill.LargeWidth = 75;
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnViewBill.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewBill_ItemClick);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Caption = "Thống kê";
            this.btnStatistic.Id = 11;
            this.btnStatistic.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStatistic.ImageOptions.SvgImage")));
            this.btnStatistic.LargeWidth = 75;
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStatistic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStatistic_ItemClick);
            // 
            // bsTextDate
            // 
            this.bsTextDate.Caption = "barStaticItem1";
            this.bsTextDate.Id = 12;
            this.bsTextDate.Name = "bsTextDate";
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 13;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao Lưu";
            this.btnBackup.Id = 14;
            this.btnBackup.LargeWidth = 75;
            this.btnBackup.Name = "btnBackup";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi";
            this.btnRestore.Id = 15;
            this.btnRestore.LargeWidth = 75;
            this.btnRestore.Name = "btnRestore";
            // 
            // btnLog
            // 
            this.btnLog.Caption = "Nhật ký hệ thống";
            this.btnLog.Id = 16;
            this.btnLog.LargeWidth = 75;
            this.btnLog.Name = "btnLog";
            // 
            // btnSendMail
            // 
            this.btnSendMail.Caption = "Gửi báo cáo";
            this.btnSendMail.Id = 17;
            this.btnSendMail.LargeWidth = 75;
            this.btnSendMail.Name = "btnSendMail";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Enabled = false;
            this.skinPaletteDropDownButtonItem1.Id = 18;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 19;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nhà cung cấp";
            this.barButtonItem1.Id = 20;
            this.barButtonItem1.LargeWidth = 75;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Kho";
            this.barButtonItem2.Id = 21;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.LargeWidth = 75;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Nhập Kho";
            this.barButtonItem3.Id = 22;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.LargeWidth = 75;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 23;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Xuất Kho";
            this.barButtonItem5.Id = 24;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.LargeWidth = 75;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // txtCaption
            // 
            this.txtCaption.Caption = "Chào Quản lý!";
            this.txtCaption.Id = 25;
            this.txtCaption.Name = "txtCaption";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Nhà cung cấp";
            this.barButtonItem6.Id = 26;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroupSystem,
            this.ribbonPageGroup2});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnShowForm);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Chức năng";
            // 
            // ribbonPageGroupSystem
            // 
            this.ribbonPageGroupSystem.ItemLinks.Add(this.btnAccountInfo);
            this.ribbonPageGroupSystem.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroupSystem.Name = "ribbonPageGroupSystem";
            this.ribbonPageGroupSystem.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Giao diện";
            // 
            // ribbonPageManager
            // 
            this.ribbonPageManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCateogry,
            this.ribbonPageGroupStatictis,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPageManager.Name = "ribbonPageManager";
            this.ribbonPageManager.Text = "Quản lý";
            // 
            // ribbonPageGroupCateogry
            // 
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.btnViewFood);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.btnViewCategoryFood);
            this.ribbonPageGroupCateogry.Name = "ribbonPageGroupCateogry";
            this.ribbonPageGroupCateogry.Text = "Quản lý Menu";
            // 
            // ribbonPageGroupStatictis
            // 
            this.ribbonPageGroupStatictis.ItemLinks.Add(this.btnViewAccount);
            this.ribbonPageGroupStatictis.Name = "ribbonPageGroupStatictis";
            this.ribbonPageGroupStatictis.Text = "Quản lý nhân sự";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnViewBill);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnStatistic);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý doanh thu";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý kho";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 857);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frMain";
            this.Text = "Trang chính";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnShowForm;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnViewFood;
        private DevExpress.XtraBars.BarButtonItem btnViewCategoryFood;
        private DevExpress.XtraBars.BarButtonItem btnViewTable;
        private DevExpress.XtraBars.BarButtonItem btnAccountInfo;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnViewAccount;
        private DevExpress.XtraBars.BarButtonItem btnViewBill;
        private DevExpress.XtraBars.BarButtonItem btnStatistic;
        private DevExpress.XtraBars.BarStaticItem bsTextDate;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnLog;
        private DevExpress.XtraBars.BarButtonItem btnSendMail;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCateogry;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStatictis;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarStaticItem txtCaption;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
    }
}