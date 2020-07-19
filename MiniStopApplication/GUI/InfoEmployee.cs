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

namespace MiniStopApplication.GUI
{
    public partial class InfoEmployee : DevExpress.XtraEditors.XtraForm
    {
        public InfoEmployee()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtHoTen_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}