namespace MiniStopApplication.GUI
{
    partial class frAddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddMember));
            this.label7 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNgayVaoLam = new System.Windows.Forms.Label();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.bttThoat = new DevExpress.XtraEditors.SimpleButton();
            this.bttCapNhat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Thông tin thành viên";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bttThoat);
            this.panelControl1.Controls.Add(this.bttCapNhat);
            this.panelControl1.Controls.Add(this.txtEmail);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.lbNgayVaoLam);
            this.panelControl1.Controls.Add(this.txtSDT);
            this.panelControl1.Controls.Add(this.txtHoTen);
            this.panelControl1.Location = new System.Drawing.Point(12, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(319, 151);
            this.panelControl1.TabIndex = 36;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 22);
            this.txtEmail.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Họ tên:";
            // 
            // lbNgayVaoLam
            // 
            this.lbNgayVaoLam.AutoSize = true;
            this.lbNgayVaoLam.Location = new System.Drawing.Point(8, 69);
            this.lbNgayVaoLam.Name = "lbNgayVaoLam";
            this.lbNgayVaoLam.Size = new System.Drawing.Size(44, 17);
            this.lbNgayVaoLam.TabIndex = 19;
            this.lbNgayVaoLam.Text = "Email:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(110, 41);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(187, 22);
            this.txtSDT.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(110, 13);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(187, 22);
            this.txtHoTen.TabIndex = 0;
            // 
            // bttThoat
            // 
            this.bttThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttThoat.ImageOptions.Image")));
            this.bttThoat.Location = new System.Drawing.Point(210, 100);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(94, 36);
            this.bttThoat.TabIndex = 84;
            this.bttThoat.Text = "Thoát";
            // 
            // bttCapNhat
            // 
            this.bttCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttCapNhat.ImageOptions.Image")));
            this.bttCapNhat.Location = new System.Drawing.Point(13, 100);
            this.bttCapNhat.Name = "bttCapNhat";
            this.bttCapNhat.Size = new System.Drawing.Size(186, 36);
            this.bttCapNhat.TabIndex = 83;
            this.bttCapNhat.Text = "Cập Nhật Thông Tin";
            this.bttCapNhat.Click += new System.EventHandler(this.bttCapNhat_Click);
            // 
            // frAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 184);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelControl1);
            this.Name = "frAddMember";
            this.Text = "Trang thêm thành viên";
            this.Load += new System.EventHandler(this.frAddMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNgayVaoLam;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.SimpleButton bttThoat;
        private DevExpress.XtraEditors.SimpleButton bttCapNhat;
    }
}