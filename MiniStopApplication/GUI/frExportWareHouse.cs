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
using MiniStopApplication.DAO;
using MiniStopApplication.BUS;
using DevExpress.DataProcessing;
using MiniStopApplication.DTO;
using DevExpress.XtraReports.UI;

namespace MiniStopApplication.GUI
{
    public partial class frExportWareHouse : DevExpress.XtraEditors.XtraForm
    {
        public frExportWareHouse()
        {
            InitializeComponent();
            loadPhieuXuatTheoNgay();
        }
        int id_product = 0;
        int idPhieuNhap = 0;
        DataTable dt;
        DataRow[] dr;
        ExportWareHourseReport report = new ExportWareHourseReport();
        private void loadPhieuXuatTheoNgay()
        {
        
            try
            {
                Load_cbTenHangHoa();
                idPhieuNhap = GoodsDeliveryNoteBus.Instance.getGoodsDeliveryNoteByDate();
                gcXuatKho.DataSource = DeliveryNoteDetailBus.Instance.getListByIdDeliveryNodeDetail(idPhieuNhap);
                gvXuatKho.Columns[0].Caption = "Mã chi tiết phiếu xuất";
                gvXuatKho.Columns[1].Caption = "Tên hàng hóa";
                gvXuatKho.Columns[2].Caption = "Số lượng xuất kho";
                gvXuatKho.Columns[3].Caption = "Giá cả";
                gvXuatKho.Columns[4].Caption = "Ngày sản xuất";
                gvXuatKho.Columns[5].Caption = "Ngày hết hạn";
                gvXuatKho.Columns[6].Caption = "Ngày xuất kho";
                gvXuatKho.Columns[7].Caption = "Thời gian xuất kho";
                gvXuatKho.Columns[8].Caption = "Tên nhân viên xuất kho";
                gvXuatKho.Columns[9].Caption = "Mã nhân viên";
                gvXuatKho.Columns[10].Caption = "Mã phiếu xuất";


                gcXuatKhoTrongNgay.DataSource = DeliveryNoteDetailBus.Instance.getListDeliveryNodeDetail();
                gvXuatKhoTrongNgay.Columns[0].Caption = "Mã chi tiết phiếu xuất";
                gvXuatKhoTrongNgay.Columns[1].Caption = "Tên hàng hóa";
                gvXuatKhoTrongNgay.Columns[2].Caption = "Số lượng xuất kho";
                gvXuatKhoTrongNgay.Columns[3].Caption = "Giá cả";
                gvXuatKhoTrongNgay.Columns[4].Caption = "Ngày sản xuất";
                gvXuatKhoTrongNgay.Columns[5].Caption = "Ngày hết hạn";
                gvXuatKhoTrongNgay.Columns[6].Caption = "Ngày xuất kho";
                gvXuatKhoTrongNgay.Columns[7].Caption = "Thời gian xuất kho";
                gvXuatKhoTrongNgay.Columns[8].Caption = "Tên nhân viên xuất kho";
                gvXuatKhoTrongNgay.Columns[9].Caption = "Mã nhân viên";
                gvXuatKhoTrongNgay.Columns[10].Caption = "Mã phiếu xuất";

            }
            catch (Exception ex)
            {

            }
        }

        private void Load_cbTenHangHoa() {
            dt = WareHourseBus.Instance.GetAllWareHourseProduct();
            cbTenHangHoa.Properties.DataSource = dt;
            cbTenHangHoa.Properties.DisplayMember = "Name_product";
            cbTenHangHoa.Properties.ValueMember = "Id_Product";
        }

        private void cbTenHangHoa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                id_product = (int)cbTenHangHoa.EditValue;

                dr = dt.Select("Id_Product =" + id_product);
                foreach (DataRow row in dr)
                {
                    txtDonGia.Text = row["Price"].ToString();
                    txtSoLuongTon.Text = row["Inventory"].ToString();
                    txtDonViTinh.Text = row["Amount"].ToString();
                }
            }
            catch (Exception ex) { 
            
            }
          
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            try
            {
                int soLuongXuat = int.Parse(txtSoLuongXuat.Text);
               idPhieuNhap =  GoodsDeliveryNoteBus.Instance.getGoodsDeliveryNoteByDate();
                if (idPhieuNhap == 0) {
                    int id_employee = 1;
                    GoodsDeliveryNoteBus.Instance.InsertDeliveryNote(id_employee);
                }
                idPhieuNhap = GoodsDeliveryNoteBus.Instance.getGoodsDeliveryNoteByDate();
                DeliveryNoteDetail deliveryNoteDetail = new DeliveryNoteDetail(
                       idPhieuNhap,
                       id_product,
                       soLuongXuat
                );
                DeliveryNoteDetailBus.Instance.InsertDeliveryNoteDetail(deliveryNoteDetail);
                XtraMessageBox.Show("Cập nhật sản phẩm thành công!", "Cập nhật sản phẩm");
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex);
            }
            loadPhieuXuatTheoNgay();
            resetInput();
        }

        public void resetInput() {

            txtDonGia.Text = null;
            txtDonViTinh.Text = null;
            txtSoLuongTon.Text = null;
            txtSoLuongXuat.Text = null;
            cbTenHangHoa.EditValue = null;
        }

        private void btnXuatPhieuNhap_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(string.Format("Bạn có chắc xuất báo cáo doanh thu này chứ?"),
                 "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ReportPrintTool tool = new ReportPrintTool(report);

                report.DataSource = gcXuatKho.DataSource;
                report.Parameters["CreateDate"].Value = DateTime.Now.Date;
                report.Parameters["NguoiLap"].Value = "Tuấn Hùng";
                report.Parameters["TotalPrice"].Value = 20000;
                tool.ShowPreview();
            }
        }
    }

}