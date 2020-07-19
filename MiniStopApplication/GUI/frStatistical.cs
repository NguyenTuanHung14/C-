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
using MiniStopApplication.BUS.StrategyPattern;

namespace MiniStopApplication.GUI
{
    public partial class frStatistical : DevExpress.XtraEditors.XtraForm
    {
        public frStatistical()
        {
            InitializeComponent();
          
        }
        private void Load() {
            try
            {
                gcThongKe.DataSource = null;
                gvThongKe.Columns.Clear();
                StatisticalContext context = new StatisticalContext();
                if (rdProduct.Checked == true)
                {


                    context.SetStrategy(new StatisticalByProduct());
                }
                if (rdProductType.Checked == true) {
                    context.SetStrategy(new StatisticalByProductType());
                }
               if (rdDate.Checked == true)
                {
                    context.SetStrategy(new StatisticalByDate());
                }
               if (rdMonth.Checked == true)
                {
                    context.SetStrategy(new StatisticalByMonth());
                }
                context.Statistical(gcThongKe, gvThongKe);
            }
            catch ( Exception ex) {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        
        }

        private void rdMonth_CheckedChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void rdDate_CheckedChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void rdProductType_CheckedChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void rdProduct_CheckedChanged(object sender, EventArgs e)
        {
            Load();
        }
    }
}