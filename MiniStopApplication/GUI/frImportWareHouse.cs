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
using MiniStopApplication.DTO;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraReports.UI;

namespace MiniStopApplication.GUI
{
    public partial class frImportWareHouse : DevExpress.XtraEditors.XtraForm
    {
        public frImportWareHouse()
        {
            InitializeComponent();
            loadPhieuNhapTheoNgay();
        }
        int idPhieuNhap = 0,id_product =  0;
        DataTable dt;
        DataRow[] dr;
        ImportWareHorseReport report = new ImportWareHorseReport();
        private void loadPhieuNhapTheoNgay()
        {
           
            try
            {
                Load_cbTenHangHoa();

                idPhieuNhap = GoodReceiptNoteBus.Instance.getGoodsReceiptNoteByDate();
                gcNhapKho.DataSource = ReceiptNoteDetailBus.Instance.getListByIdReceiptNodeDetail(idPhieuNhap);
                


                gvNhapKho.Columns[0].Caption = "Mã chi tiết phiếu nhập";
                gvNhapKho.Columns[1].Caption = "Tên hàng hóa";
                gvNhapKho.Columns[2].Caption = "Số lượng nhập kho";
                gvNhapKho.Columns[3].Caption = "Giá cả";
                gvNhapKho.Columns[4].Caption = "Ngày sản xuất";
                gvNhapKho.Columns[5].Caption = "Ngày hết hạn";
                gvNhapKho.Columns[6].Caption = "Ngày nhập kho";
                gvNhapKho.Columns[7].Caption = "Thời gian nhập kho";
                gvNhapKho.Columns[8].Caption = "Tên nhân viên nhập kho";
                gvNhapKho.Columns[9].Caption = "Mã nhân viên";
                gvNhapKho.Columns[10].Caption = "Mã phiếu nhập";


                gcNhapKhoTrongNgay.DataSource = ReceiptNoteDetailBus.Instance.getListReceiptNodeDetail();

                gvNhapKhoTrongNgay.Columns[0].Caption = "Mã chi tiết phiếu nhập";
                gvNhapKhoTrongNgay.Columns[1].Caption = "Tên hàng hóa";
                gvNhapKhoTrongNgay.Columns[2].Caption = "Số lượng nhập kho";
                gvNhapKhoTrongNgay.Columns[3].Caption = "Giá cả";
                gvNhapKhoTrongNgay.Columns[4].Caption = "Ngày sản xuất";
                gvNhapKhoTrongNgay.Columns[5].Caption = "Ngày hết hạn";
                gvNhapKhoTrongNgay.Columns[6].Caption = "Ngày nhập kho";
                gvNhapKhoTrongNgay.Columns[7].Caption = "Thời gian nhập kho";
                gvNhapKhoTrongNgay.Columns[8].Caption = "Tên nhân viên nhập kho";
                gvNhapKhoTrongNgay.Columns[9].Caption = "Mã nhân viên";
                gvNhapKhoTrongNgay.Columns[10].Caption = "Mã phiếu nhập";
            }
            catch (Exception ex) { 
            
            }
          
        }

        private void Load_cbTenHangHoa()
        {
            dt = ProductBus.Instance.GetAllProduct();
            cbTenHangHoa.Properties.DataSource = dt;
            cbTenHangHoa.Properties.DisplayMember = "Name_product";
            cbTenHangHoa.Properties.ValueMember = "Id_Product";
        }
        private void Load_cbNhaCungCap() {
        
            cbNhaCungCap.Properties.DataSource = SupplierBus.Instance.GetAllSupplier();
            cbNhaCungCap.Properties.DisplayMember = "Name";
            cbNhaCungCap.Properties.ValueMember = "Id_Supplier";
        }
        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            try
            {
                int soLuongNhap = int.Parse(txtSoLuongNhap.Text);
                float price = float.Parse(txtDonGia.Text);
                DateTime mfg_date = Convert.ToDateTime(dpkNgaySanXuat.Value);
                DateTime exp_date = Convert.ToDateTime(dpkNgayHetHan.Value);
               
                if (idPhieuNhap == 0)
                {
                    int id_employee = 1;
                    GoodReceiptNoteBus.Instance.InsertReceiptNote(id_employee);
                }
                idPhieuNhap = GoodReceiptNoteBus.Instance.getGoodsReceiptNoteByDate();
                ReceiptNoteDetail receiptNoteDetail = new ReceiptNoteDetail(
                       price,
                       soLuongNhap,
                       idPhieuNhap,
                       id_product,
                       mfg_date,
                       exp_date,
                       1
                );
                ReceiptNoteDetailBus.Instance.InsertReceiptNoteDetail(receiptNoteDetail);
                XtraMessageBox.Show("Nhập hàng thành công!", "Nhập hàng ");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
            loadPhieuNhapTheoNgay();
            resetInput();
        }

        private void resetInput()
        {
            cbNhaCungCap.EditValue = null;
            cbTenHangHoa.EditValue = null;
            txtDonGia.Text = null;
            txtSoLuongNhap.Text = null;
            dpkNgayHetHan.Value = DateTime.Now;
            dpkNgaySanXuat.Value = DateTime.Now;

        }

        private void btnXuatPhieuNhap_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(string.Format("Bạn có chắc xuất báo cáo doanh thu này chứ?"),
                    "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ReportPrintTool tool = new ReportPrintTool(report);

                report.DataSource = gcNhapKho.DataSource;
                report.Parameters["CreateDate"].Value = DateTime.Now.Date;
                report.Parameters["NguoiLap"].Value = "Tuấn Hùng";
                report.Parameters["TotalPrice"].Value = 20000;
                tool.ShowPreview();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void cbNhaCungCap_MouseHover(object sender, EventArgs e)
        {
            Load_cbNhaCungCap();
        }

        private void cbTenHangHoa_MouseHover(object sender, EventArgs e)
        {
            Load_cbTenHangHoa();
        }

        private void cbTenHangHoa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                id_product = (int)cbTenHangHoa.EditValue;
            }
            catch (Exception ex)
            {

            }
        }
    }
  
}