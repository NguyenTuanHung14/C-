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
               
            }
            catch (Exception ex) { 
            
            }
          
        }

        private void Load_cbTenHangHoa()
        {
            dt = WareHourseBus.Instance.GetAllWareHourseProduct();
            cbTenHangHoa.Properties.DataSource = dt;
            cbTenHangHoa.Properties.DisplayMember = "Name_product";
            cbTenHangHoa.Properties.ValueMember = "Id_Product";
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
                    idPhieuNhap =  GoodReceiptNoteBus.Instance.InsertReceiptNote(id_employee);
                }
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