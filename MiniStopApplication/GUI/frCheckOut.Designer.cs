namespace MiniStopApplication.GUI
{
    partial class frCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCheckOut));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.listviewMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.cbDanhMuc = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelBan = new System.Windows.Forms.TextBox();
            this.btnThemMon = new DevExpress.XtraEditors.SimpleButton();
            this.panelCheckBan = new System.Windows.Forms.Panel();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongCong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnChuyenBan = new DevExpress.XtraEditors.SimpleButton();
            this.spDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.txtThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcBill = new DevExpress.XtraGrid.GridControl();
            this.gvBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.listviewMenu);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtTenSanPham);
            this.panel2.Controls.Add(this.cbDanhMuc);
            this.panel2.Location = new System.Drawing.Point(6, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 408);
            this.panel2.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.Location = new System.Drawing.Point(31, 8);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 31);
            this.btnReset.TabIndex = 44;
            this.btnReset.Text = "Reset";
            // 
            // listviewMenu
            // 
            this.listviewMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listviewMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listviewMenu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewMenu.GridLines = true;
            this.listviewMenu.HideSelection = false;
            this.listviewMenu.Location = new System.Drawing.Point(0, 76);
            this.listviewMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listviewMenu.Name = "listviewMenu";
            this.listviewMenu.Size = new System.Drawing.Size(500, 328);
            this.listviewMenu.TabIndex = 43;
            this.listviewMenu.UseCompatibleStateImageBehavior = false;
            this.listviewMenu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn giá";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ghi chú";
            this.columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            this.columnHeader4.Width = 165;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(412, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 33);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Tìm";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSanPham.Location = new System.Drawing.Point(188, 9);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Properties.Appearance.Options.UseFont = true;
            this.txtTenSanPham.Properties.NullText = "   -- Tên Sản Phẩm --";
            this.txtTenSanPham.Size = new System.Drawing.Size(218, 30);
            this.txtTenSanPham.TabIndex = 35;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDanhMuc.Location = new System.Drawing.Point(3, 43);
            this.cbDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.Properties.Appearance.Options.UseFont = true;
            this.cbDanhMuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDanhMuc.Properties.NullText = "                           -- Chọn danh mục --";
            this.cbDanhMuc.Size = new System.Drawing.Size(497, 30);
            this.cbDanhMuc.TabIndex = 31;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl3.Controls.Add(this.labelBan);
            this.panelControl3.Controls.Add(this.btnThemMon);
            this.panelControl3.Controls.Add(this.panelCheckBan);
            this.panelControl3.Controls.Add(this.btnThanhToan);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Controls.Add(this.txtTongCong);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.btnChuyenBan);
            this.panelControl3.Controls.Add(this.spDiscount);
            this.panelControl3.Controls.Add(this.txtThanhTien);
            this.panelControl3.Location = new System.Drawing.Point(12, 445);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(517, 195);
            this.panelControl3.TabIndex = 51;
            // 
            // labelBan
            // 
            this.labelBan.Location = new System.Drawing.Point(176, 38);
            this.labelBan.Name = "labelBan";
            this.labelBan.Size = new System.Drawing.Size(44, 23);
            this.labelBan.TabIndex = 53;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThemMon.Appearance.Options.UseFont = true;
            this.btnThemMon.Appearance.Options.UseForeColor = true;
            this.btnThemMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMon.ImageOptions.Image")));
            this.btnThemMon.Location = new System.Drawing.Point(340, 23);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(157, 52);
            this.btnThemMon.TabIndex = 35;
            this.btnThemMon.Text = "Thêm món";
            // 
            // panelCheckBan
            // 
            this.panelCheckBan.Location = new System.Drawing.Point(148, 37);
            this.panelCheckBan.Name = "panelCheckBan";
            this.panelCheckBan.Size = new System.Drawing.Size(25, 25);
            this.panelCheckBan.TabIndex = 51;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThanhToan.Location = new System.Drawing.Point(340, 86);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(157, 91);
            this.btnThanhToan.TabIndex = 34;
            this.btnThanhToan.Text = "Thanh toán";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(5, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Bàn đang chọn: ";
            // 
            // txtTongCong
            // 
            this.txtTongCong.Enabled = false;
            this.txtTongCong.Location = new System.Drawing.Point(124, 143);
            this.txtTongCong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongCong.Properties.Appearance.Options.UseFont = true;
            this.txtTongCong.Properties.AutoHeight = false;
            this.txtTongCong.Size = new System.Drawing.Size(206, 31);
            this.txtTongCong.TabIndex = 46;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 143);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 23);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Tổng cộng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 79);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 21);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "Thành tiền";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(40, 112);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 23);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Giảm giá";
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.Appearance.Options.UseFont = true;
            this.btnChuyenBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenBan.ImageOptions.Image")));
            this.btnChuyenBan.Location = new System.Drawing.Point(224, 23);
            this.btnChuyenBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(106, 52);
            this.btnChuyenBan.TabIndex = 33;
            this.btnChuyenBan.Text = "Chuyển";
            // 
            // spDiscount
            // 
            this.spDiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spDiscount.Location = new System.Drawing.Point(124, 114);
            this.spDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spDiscount.Name = "spDiscount";
            this.spDiscount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spDiscount.Properties.Appearance.Options.UseFont = true;
            this.spDiscount.Properties.AutoHeight = false;
            this.spDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spDiscount.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spDiscount.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spDiscount.Size = new System.Drawing.Size(206, 26);
            this.spDiscount.TabIndex = 36;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(125, 79);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Properties.Appearance.Options.UseFont = true;
            this.txtThanhTien.Properties.AutoHeight = false;
            this.txtThanhTien.Size = new System.Drawing.Size(205, 31);
            this.txtThanhTien.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(30, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Danh mục Menu";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl2.Controls.Add(this.panel2);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(517, 427);
            this.panelControl2.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(552, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Danh mục hóa đơn";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Location = new System.Drawing.Point(539, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(777, 629);
            this.panelControl1.TabIndex = 52;
            this.panelControl1.TabStop = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gcBill);
            this.panel1.Location = new System.Drawing.Point(11, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 609);
            this.panel1.TabIndex = 31;
            // 
            // gcBill
            // 
            this.gcBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBill.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcBill.Location = new System.Drawing.Point(3, 11);
            this.gcBill.MainView = this.gvBill;
            this.gcBill.Name = "gcBill";
            this.gcBill.Size = new System.Drawing.Size(753, 587);
            this.gcBill.TabIndex = 44;
            this.gcBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill});
            // 
            // gvBill
            // 
            this.gvBill.GridControl = this.gcBill;
            this.gvBill.Name = "gvBill";
            this.gvBill.OptionsView.ShowGroupPanel = false;
            // 
            // frCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelControl2);
            this.Name = "frCheckOut";
            this.Text = "frCheckOut";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private System.Windows.Forms.ListView listviewMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtTenSanPham;
        private DevExpress.XtraEditors.LookUpEdit cbDanhMuc;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.TextBox labelBan;
        private DevExpress.XtraEditors.SimpleButton btnThemMon;
        private System.Windows.Forms.Panel panelCheckBan;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtTongCong;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChuyenBan;
        private DevExpress.XtraEditors.SpinEdit spDiscount;
        private DevExpress.XtraEditors.TextEdit txtThanhTien;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBill;
    }
}