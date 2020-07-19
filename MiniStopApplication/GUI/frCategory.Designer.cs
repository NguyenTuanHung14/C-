namespace MiniStopApplication.GUI
{
    partial class frCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCategory));
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchCategory = new DevExpress.XtraEditors.TextEdit();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.t = new System.Windows.Forms.Label();
            this.cbTimKiem = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCategory = new DevExpress.XtraGrid.GridControl();
            this.gvCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnXem.Appearance.Options.UseFont = true;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(24, 56);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(85, 35);
            this.btnXem.TabIndex = 31;
            this.btnXem.Text = "Xem";
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCategory.EditValue = "";
            this.txtSearchCategory.Location = new System.Drawing.Point(131, 14);
            this.txtSearchCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCategory.Properties.Appearance.Options.UseFont = true;
            this.txtSearchCategory.Properties.AutoHeight = false;
            this.txtSearchCategory.Properties.NullText = "-- Tìm tên món ăn --";
            this.txtSearchCategory.Properties.NullValuePrompt = "-- Tìm tên món ăn --";
            this.txtSearchCategory.Size = new System.Drawing.Size(160, 33);
            this.txtSearchCategory.TabIndex = 27;
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(171, 59);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 44);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(13, 109);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 44);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(171, 109);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 44);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(13, 59);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 44);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Tahoma", 10F);
            this.t.Location = new System.Drawing.Point(9, 16);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(121, 21);
            this.t.TabIndex = 3;
            this.t.Text = "Tên sản phẩm:";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Location = new System.Drawing.Point(132, 54);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbTimKiem.Properties.Appearance.Options.UseFont = true;
            this.cbTimKiem.Properties.AutoHeight = false;
            this.cbTimKiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTimKiem.Properties.NullText = "";
            this.cbTimKiem.Size = new System.Drawing.Size(160, 32);
            this.cbTimKiem.TabIndex = 27;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbTimKiem);
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.txtSearchCategory);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Location = new System.Drawing.Point(12, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(306, 124);
            this.panelControl1.TabIndex = 77;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(24, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 33);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Tìm";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcCategory;
            this.gridView2.Name = "gridView2";
            // 
            // gcCategory
            // 
            this.gcCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcCategory.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcCategory.Location = new System.Drawing.Point(5, 16);
            this.gcCategory.MainView = this.gvCategory;
            this.gcCategory.Name = "gcCategory";
            this.gcCategory.Size = new System.Drawing.Size(624, 491);
            this.gcCategory.TabIndex = 27;
            this.gcCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategory,
            this.gridView2});
            this.gcCategory.Click += new System.EventHandler(this.gcCategory_Click);
            // 
            // gvCategory
            // 
            this.gvCategory.GridControl = this.gcCategory;
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.OptionsView.ShowGroupPanel = false;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(131, 16);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(160, 23);
            this.txtTen.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl3.Controls.Add(this.btnSua);
            this.panelControl3.Controls.Add(this.btnXoa);
            this.panelControl3.Controls.Add(this.btnThoat);
            this.panelControl3.Controls.Add(this.btnThem);
            this.panelControl3.Controls.Add(this.t);
            this.panelControl3.Controls.Add(this.txtTen);
            this.panelControl3.Location = new System.Drawing.Point(12, 164);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(306, 361);
            this.panelControl3.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(325, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "Danh sách danh mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(21, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 75;
            this.label3.Text = "Tìm kiếm";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.gcCategory);
            this.panelControl2.Location = new System.Drawing.Point(324, 18);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(634, 512);
            this.panelControl2.TabIndex = 78;
            // 
            // frCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 542);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelControl2);
            this.Name = "frCategory";
            this.Text = "Trang quản lý loại hàng hóa";
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.TextEdit txtSearchCategory;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label t;
        private DevExpress.XtraEditors.LookUpEdit cbTimKiem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gcCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategory;
        private System.Windows.Forms.TextBox txtTen;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}