using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.UserSkins;
using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;

namespace MiniStopApplication.GUI
{
    public partial class frMain : DevExpress.XtraEditors.XtraForm
    {
        public frMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
         //   ribbonPageManager.Visible = false;
        }
     
        private Form CheckFormExist(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }
        private void btnShowForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            Form frm = this.CheckFormExist(typeof(frCheckOut));
            if (frm != null)
            {

                frm.Activate();
            }
            else
            {

                frCheckOut f = new frCheckOut();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void btnViewCategoryFood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            Form frm = this.CheckFormExist(typeof(frCategory));
            if (frm != null)
            {

                frm.Activate();
            }
            else
            {

                frCategory f = new frCategory();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void btnViewFood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            Form frm = this.CheckFormExist(typeof(frProduct));
            if (frm != null)
            {

                frm.Activate();
            }
            else
            {
                frProduct f = new frProduct();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void btnViewAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            Form frm = this.CheckFormExist(typeof(frStaff));
            if (frm != null)
            {

                frm.Activate();
            }
            else
            {
                frStaff f = new frStaff();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            Form frm = this.CheckFormExist(typeof(frImportWareHouse));
            if (frm != null)
            {

                frm.Activate();
            }
            else
            {
                frImportWareHouse f = new frImportWareHouse();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            Form frm = this.CheckFormExist(typeof(frExportWareHouse));
            if (frm != null)
            {

                frm.Activate();
            }
            else
            {
                frExportWareHouse f = new frExportWareHouse();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            Form frm = this.CheckFormExist(typeof(frSupplier));
            if (frm != null)
            {

                frm.Activate();
            }
            else
            {
                frSupplier f = new frSupplier();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            Form frm = this.CheckFormExist(typeof(frWareHourse));
            if (frm != null)
            {

                frm.Activate();
            }
            else
            {
                frWareHourse f = new frWareHourse();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void btnAccountInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                InfoEmployee f = new InfoEmployee();
                f.Show();
        }

        private void btnViewBill_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            Form frm = this.CheckFormExist(typeof(frListBill));
            if (frm != null)
            {

                frm.Activate();
            }
            else
            {
                frListBill f = new frListBill();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void btnStatistic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            Form frm = this.CheckFormExist(typeof(frStatistical));
            if (frm != null)
            {

                frm.Activate();
            }
            else
            {
                frStatistical f = new frStatistical();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }
    }
}