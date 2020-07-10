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
using DevExpress.XtraSplashScreen;

namespace MiniStopApplication.GUI
{
    public partial class frLogin : DevExpress.XtraEditors.XtraForm
    {
        public frLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            frMain fr = new frMain();
            SplashScreenManager.CloseForm();
            fr.ShowDialog();
        }
    }
}