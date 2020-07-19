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
using System.Drawing.Printing;
using MiniStopApplication.BUS;

namespace MiniStopApplication.GUI
{
    public partial class frWareHourse : DevExpress.XtraEditors.XtraForm
    {
        public frWareHourse()
        {
            InitializeComponent();
            load();
        }

        private void radioXemTheoDanhMuc_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void load() {

            try
            {
                gcWare.DataSource = WareHourseBus.Instance.GetAllWareHourseProduct();
                gvWare.Columns[0].Caption = "Mã hàng hóa";
                gvWare.Columns[1].Caption = "Tên hàng hóa";
                gvWare.Columns[2].Caption = "Số lượng trên kệ";
                gvWare.Columns[3].Caption = "Số lượng tồn kho";
                gvWare.Columns[4].Caption = "Ngày sản xuất";
                gvWare.Columns[5].Caption = "Ngày hết hạn";
                gvWare.Columns[6].Caption = "Ngày nhập hàng";
                gvWare.Columns[7].Caption = "Nhân viên nhập";
                gvWare.Columns[8].Caption = "Nhà cung cấp";
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchCategory.Text ==null)
                {
                    XtraMessageBox.Show("Vui lòng nhập thông tin!");
                    return;
                }
               gcWare.DataSource = WareHourseBus.Instance.GetAllByName_WarehouseProduct(txtSearchCategory.Text);
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex);

            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (rdAll.Checked == true)
            {

                load();
            }
            else {
                try
                {
                    gcWare.DataSource = WareHourseBus.Instance.GetAllExpire_WarehouseProduct();
                }
                catch (Exception ex) {
                    XtraMessageBox.Show("Error: " + ex);
                }
            }
        }
    }
}