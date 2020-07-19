namespace MiniStopApplication.GUI
{
    partial class frStatistical
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
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcThongKe = new DevExpress.XtraGrid.GridControl();
            this.gvThongKe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rdProduct = new System.Windows.Forms.RadioButton();
            this.rdProductType = new System.Windows.Forms.RadioButton();
            this.rdMonth = new System.Windows.Forms.RadioButton();
            this.rdDate = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thống Kê";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.gcThongKe);
            this.panelControl2.Location = new System.Drawing.Point(7, 52);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(965, 413);
            this.panelControl2.TabIndex = 4;
            // 
            // gcThongKe
            // 
            this.gcThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcThongKe.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcThongKe.Location = new System.Drawing.Point(1, 14);
            this.gcThongKe.MainView = this.gvThongKe;
            this.gcThongKe.Name = "gcThongKe";
            this.gcThongKe.Size = new System.Drawing.Size(954, 394);
            this.gcThongKe.TabIndex = 0;
            this.gcThongKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThongKe});
            // 
            // gvThongKe
            // 
            this.gvThongKe.GridControl = this.gcThongKe;
            this.gvThongKe.Name = "gvThongKe";
            this.gvThongKe.OptionsView.ShowGroupPanel = false;
            // 
            // rdProduct
            // 
            this.rdProduct.AutoSize = true;
            this.rdProduct.Location = new System.Drawing.Point(72, 12);
            this.rdProduct.Name = "rdProduct";
            this.rdProduct.Size = new System.Drawing.Size(181, 21);
            this.rdProduct.TabIndex = 0;
            this.rdProduct.TabStop = true;
            this.rdProduct.Text = "Thống kê theo hàng hóa";
            this.rdProduct.UseVisualStyleBackColor = true;
            this.rdProduct.CheckedChanged += new System.EventHandler(this.rdProduct_CheckedChanged);
            // 
            // rdProductType
            // 
            this.rdProductType.AutoSize = true;
            this.rdProductType.Location = new System.Drawing.Point(279, 12);
            this.rdProductType.Name = "rdProductType";
            this.rdProductType.Size = new System.Drawing.Size(204, 21);
            this.rdProductType.TabIndex = 1;
            this.rdProductType.TabStop = true;
            this.rdProductType.Text = "Thống kê theo loại hàng hóa";
            this.rdProductType.UseVisualStyleBackColor = true;
            this.rdProductType.CheckedChanged += new System.EventHandler(this.rdProductType_CheckedChanged);
            // 
            // rdMonth
            // 
            this.rdMonth.AutoSize = true;
            this.rdMonth.Location = new System.Drawing.Point(700, 12);
            this.rdMonth.Name = "rdMonth";
            this.rdMonth.Size = new System.Drawing.Size(159, 21);
            this.rdMonth.TabIndex = 2;
            this.rdMonth.TabStop = true;
            this.rdMonth.Text = "Thống kê theo tháng";
            this.rdMonth.UseVisualStyleBackColor = true;
            this.rdMonth.CheckedChanged += new System.EventHandler(this.rdMonth_CheckedChanged);
            // 
            // rdDate
            // 
            this.rdDate.AutoSize = true;
            this.rdDate.Location = new System.Drawing.Point(515, 12);
            this.rdDate.Name = "rdDate";
            this.rdDate.Size = new System.Drawing.Size(154, 21);
            this.rdDate.TabIndex = 3;
            this.rdDate.TabStop = true;
            this.rdDate.Text = "Thống kê theo ngày";
            this.rdDate.UseVisualStyleBackColor = true;
            this.rdDate.CheckedChanged += new System.EventHandler(this.rdDate_CheckedChanged);
            // 
            // frStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 477);
            this.Controls.Add(this.rdMonth);
            this.Controls.Add(this.rdDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.rdProductType);
            this.Controls.Add(this.rdProduct);
            this.Name = "frStatistical";
            this.Text = "Trang thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThongKe;
        private System.Windows.Forms.RadioButton rdDate;
        private System.Windows.Forms.RadioButton rdMonth;
        private System.Windows.Forms.RadioButton rdProductType;
        private System.Windows.Forms.RadioButton rdProduct;
        public DevExpress.XtraGrid.GridControl gcThongKe;
    }
}