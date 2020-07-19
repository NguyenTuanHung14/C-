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
using MiniStopApplication.BUS;

namespace MiniStopApplication.GUI
{
    public partial class frListBill : DevExpress.XtraEditors.XtraForm
    {
        public frListBill()
        {
            InitializeComponent();
            loadBill();
        }
        int id_bill, id_employee;
        string name_employee, date_create;
        
        private void loadBill() {
            try
            {
                gcBill.DataSource=BillBus.Instance.getAllBill();
                gvBill.Columns[0].Caption = "Mã hóa đơn";
                gvBill.Columns[1].Caption = "Ngày tạo";
                gvBill.Columns[2].Caption = "Thời gian tạo";
                gvBill.Columns[3].Caption = "Tổng cộng";
                gvBill.Columns[4].Caption = "Nhân viên bán hàng";
                gvBill.Columns[5].Caption = "Mã nhân viên";
                calDoanhThu();
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }


        private void loadBillDetail(int id_bill) {
            gcBillDetail.DataSource = BillDetailBus.Instance.getListBillDetailByBill(id_bill);
            gvBillDetail.Columns[0].Caption = "Mã hàng hóa";
            gvBillDetail.Columns[1].Caption = "Tên";
            gvBillDetail.Columns[2].Caption = "Số lượng";
            gvBillDetail.Columns[3].Caption = "Giá cả";
            gvBillDetail.Columns[4].Caption = "Khuyến mãi";
            gvBillDetail.Columns[5].Caption = "Thành tiền";
        }
        private void gvBill_Click(object sender, EventArgs e)
        {
            if (gvBill.RowCount > 0) { 
                 id_bill = int.Parse(gvBill.GetRowCellValue(gvBill.FocusedRowHandle, gvBill.Columns[0]).ToString());
                 date_create = gvBill.GetRowCellValue(gvBill.FocusedRowHandle, gvBill.Columns[1]).ToString();
                 id_employee = int.Parse(gvBill.GetRowCellValue(gvBill.FocusedRowHandle, gvBill.Columns[5]).ToString());
                 name_employee = gvBill.GetRowCellValue(gvBill.FocusedRowHandle, gvBill.Columns[4]).ToString();

                txtMaHoaDon.Text = "MHD" + id_bill;
                txtNgayBan.Text = date_create;
                txtMaNhanVien.Text = "MNV" + id_employee;
                txtTenNhanVien.Text = name_employee;

                loadBillDetail(id_bill);
                calDoanhThu();
            }
        }

        private void gcBill_DataSourceChanged(object sender, EventArgs e)
        {
            calDoanhThu();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = Convert.ToDateTime(deFromDate.EditValue);
                DateTime toDate = Convert.ToDateTime(deToDate.EditValue);
                gcBill.DataSource = BillBus.Instance.getAllBillByDate(fromDate, toDate);
            }
            catch (Exception ex) {

                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }

        private void calDoanhThu() {
            float doanhThu = 0;
            for (int i = 0; i < gvBill.RowCount; i++)
            {
                DataRow row = gvBill.GetDataRow(i);
                doanhThu += float.Parse(row["Total"].ToString());
            }
            txtDoanhThu.Text = doanhThu + " VND";
            txtSoLuongHoaDon.Text = gvBill.RowCount + " hóa đơn";
        }
    }
}