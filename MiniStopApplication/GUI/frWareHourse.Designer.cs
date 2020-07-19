namespace MiniStopApplication.GUI
{
    partial class frWareHourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frWareHourse));
            this.gcWare = new DevExpress.XtraGrid.GridControl();
            this.gvWare = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.radioXemTheoDanhMuc = new System.Windows.Forms.RadioButton();
            this.txtSearchCategory = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.radioXemTatCa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcWare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcWare
            // 
            this.gcWare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcWare.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcWare.Location = new System.Drawing.Point(12, 125);
            this.gcWare.MainView = this.gvWare;
            this.gcWare.Name = "gcWare";
            this.gcWare.Size = new System.Drawing.Size(1027, 430);
            this.gcWare.TabIndex = 28;
            this.gcWare.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWare,
            this.gridView2});
            // 
            // gvWare
            // 
            this.gvWare.GridControl = this.gcWare;
            this.gvWare.Name = "gvWare";
            this.gvWare.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcWare;
            this.gridView2.Name = "gridView2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 74;
            this.label3.Text = "Tìm kiếm";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.radioXemTheoDanhMuc);
            this.panelControl1.Controls.Add(this.txtSearchCategory);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.radioXemTatCa);
            this.panelControl1.Location = new System.Drawing.Point(12, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1027, 78);
            this.panelControl1.TabIndex = 75;
            // 
            // btnXem
            // 
            this.btnXem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnXem.Appearance.Options.UseFont = true;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(678, 12);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(85, 35);
            this.btnXem.TabIndex = 31;
            this.btnXem.Text = "Xem";
            // 
            // radioXemTheoDanhMuc
            // 
            this.radioXemTheoDanhMuc.AutoSize = true;
            this.radioXemTheoDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioXemTheoDanhMuc.Location = new System.Drawing.Point(779, 16);
            this.radioXemTheoDanhMuc.Name = "radioXemTheoDanhMuc";
            this.radioXemTheoDanhMuc.Size = new System.Drawing.Size(217, 22);
            this.radioXemTheoDanhMuc.TabIndex = 30;
            this.radioXemTheoDanhMuc.TabStop = true;
            this.radioXemTheoDanhMuc.Text = "Xem hàng hóa sắp hết hàng ";
            this.radioXemTheoDanhMuc.UseVisualStyleBackColor = true;
            this.radioXemTheoDanhMuc.CheckedChanged += new System.EventHandler(this.radioXemTheoDanhMuc_CheckedChanged);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.EditValue = "";
            this.txtSearchCategory.Location = new System.Drawing.Point(149, 18);
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
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(43, 19);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 33);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Tìm";
            // 
            // radioXemTatCa
            // 
            this.radioXemTatCa.AutoSize = true;
            this.radioXemTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioXemTatCa.Location = new System.Drawing.Point(779, 44);
            this.radioXemTatCa.Name = "radioXemTatCa";
            this.radioXemTatCa.Size = new System.Drawing.Size(100, 22);
            this.radioXemTatCa.TabIndex = 29;
            this.radioXemTatCa.TabStop = true;
            this.radioXemTatCa.Text = "Xem tất cả";
            this.radioXemTatCa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 23);
            this.label1.TabIndex = 76;
            this.label1.Text = "Danh sách hàng hóa trong kho";
            // 
            // frWareHourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcWare);
            this.Name = "frWareHourse";
            this.Text = "frWareHourse";
            ((System.ComponentModel.ISupportInitialize)(this.gcWare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCategory.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcWare;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWare;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private System.Windows.Forms.RadioButton radioXemTheoDanhMuc;
        private DevExpress.XtraEditors.TextEdit txtSearchCategory;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.RadioButton radioXemTatCa;
        private System.Windows.Forms.Label label1;
    }
}