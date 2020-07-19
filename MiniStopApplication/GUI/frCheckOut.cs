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
using MiniStopApplication.DTO;
using System.Globalization;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors.Filtering.Templates;
using MiniStopApplication.BUS.StrategyPattern;

namespace MiniStopApplication.GUI
{
    public partial class frCheckOut : DevExpress.XtraEditors.XtraForm
    {
        public frCheckOut()
        {
            InitializeComponent();
            taoHoaDon();
            load_cbDanhMuc();
            loadListProduct();
            ShowBill();


        }
        int id_product = 0;
        int id_hoadon = 0;
        float price_product = 0;
        CultureInfo culture = new CultureInfo("vi-VN");
        float thanhtien = 0, totalPrice = 0, finalPrice = 0;
        private void load_cbDanhMuc() {
            cbDanhMuc.Properties.DataSource = CategoryBus.Instance.GetAllProductType();
            cbDanhMuc.Properties.DisplayMember = "Name_Type";
            cbDanhMuc.Properties.ValueMember = "Id_ProductType";
        }
        private void taoHoaDon() {
            try
            {
                int id_employee = 1;
                id_hoadon = BillBus.Instance.getBill();
                if (id_hoadon == 0)
                {
                    BillBus.Instance.InsertBill(id_employee);
                }
                id_hoadon = BillBus.Instance.getBill();
                txtMaHoaDon.Text = "HD" + id_hoadon;
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }
        private void loadListProduct() {

            gcProduct.DataSource = ProductBus.Instance.GetAllProductForCheckOut();
            gvProduct.Columns[0].Caption = "Mã hàng hóa";
            gvProduct.Columns[1].Caption = "Tên hàng hóa";
            gvProduct.Columns[2].Caption = "Gía cả";
            gvProduct.Columns[3].Caption = "Số lượng trên kệ";
            gvProduct.Columns[4].Caption = "Hình ảnh";
            gvProduct.Columns[5].Caption = "Ngày sản xuất";
            gvProduct.Columns[6].Caption = "Ngày hết hạn";
            gvProduct.Columns[7].Caption = "Khuyến mãi";
            gvProduct.Columns[8].Caption = "Mã loại hàng hóa";
            gvProduct.Columns[0].Visible = false;
            gvProduct.Columns[4].Visible = false;
            gvProduct.Columns[9].Visible = false;

            txtNgayBan.Text = DateTime.Now.Day + "";
        }
        private void loadListProductByType(int id) {
            gcProduct.DataSource = ProductBus.Instance.GetAllProductByType(id);
            gvProduct.Columns[0].Caption = "Mã hàng hóa";
            gvProduct.Columns[0].Visible = false;
            gvProduct.Columns[1].Caption = "Tên hàng hóa";
            gvProduct.Columns[2].Caption = "Gía cả";
            gvProduct.Columns[3].Caption = "Số lượng trên kệ";
            gvProduct.Columns[4].Caption = "Hình ảnh";
            gvProduct.Columns[4].Visible = false;
            gvProduct.Columns[5].Caption = "Ngày sản xuất";
            gvProduct.Columns[6].Caption = "Ngày hết hạn";
            gvProduct.Columns[7].Caption = "Khuyến mãi";
            gvProduct.Columns[8].Caption = "Mã loại hàng hóa";
            gvProduct.Columns[9].Visible = false;
        }
        private void cbDanhMuc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                loadListProductByType((int)cbDanhMuc.EditValue);
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
          
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTenSanPham.Text;
                gcProduct.DataSource = ProductBus.Instance.seacrhProduct(name);
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " +  ex.Message);
            }
           
        }



        private void btnThemMon_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (id_product == 0)
                {
                    XtraMessageBox.Show("Hãy chọn món");
                    return;
                }
                BillDetail billDetail = new BillDetail(
                    price_product,
                    1,
                    id_hoadon,
                    id_product
                    );
                BillDetailBus.Instance.InsertBillDetal(billDetail);
                ShowBill();
                loadListProduct();
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
            
        }
        private void ShowBill() {
           
            gcBill.DataSource = BillDetailBus.Instance.getListBillDetailByBill(id_hoadon);
            gvBill.Columns[0].Caption = "Mã hàng hóa";
            gvBill.Columns[0].Visible = false;
            gvBill.Columns[1].Caption = "Tên";
            gvBill.Columns[2].Caption = "Số lượng";
            gvBill.Columns[3].Caption = "Giá cả";
            gvBill.Columns[4].Caption = "Khuyến mãi";
            gvBill.Columns[5].Caption = "Thành tiền";
            if (gvBill.RowCount > 0)
            {
                thanhtien = 0;
                for (int i = 0; i < gvBill.RowCount; i++)
                {
                    DataRow row = gvBill.GetDataRow(i);
                    thanhtien += float.Parse(row["Total"].ToString());
                }
                txtThanhTien.Text = thanhtien.ToString("c", culture);
                finalPrice = thanhtien - (thanhtien / 100) * ((int)spDiscount.Value);
                txtTongCong.Text = finalPrice.ToString("c", culture);
            }
           
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void gcProduct_Click(object sender, EventArgs e)
        {
            if (gvProduct.RowCount > 0)
            {
                id_product = int.Parse(gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[0]).ToString());

            }
        }

        private void gvProduct_Click(object sender, EventArgs e)
        {
            if (gvProduct.RowCount > 0)
            {
                id_product = int.Parse(gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[0]).ToString());
                price_product = float.Parse(gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[2]).ToString());
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int discount = (int)spDiscount.Value;
                if (gvProduct.RowCount == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn món để thanh toán!");
                    return;
                }
                if (XtraMessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn này chứ?"),
                        "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    CheckOutContext checkOutContext = new CheckOutContext();
                    checkOutContext.SetStrategy(new StandardCheckOut());
                    checkOutContext.CheckOut(discount, finalPrice, id_hoadon);
                    BillBus.Instance.UpdateBill(id_hoadon);
                    Refesh();
                }
      
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex.Message);
            } 
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gvBill.RowCount; i++)
                {
                    DataRow row = gvBill.GetDataRow(i);
                    float price = float.Parse(row["Price"].ToString());
                    int idProduct = int.Parse(row["Id_product"].ToString());
                    BillDetail billDetail = new BillDetail(
                           price,
                           -1000,
                           id_hoadon,
                           idProduct
                           );
                    BillDetailBus.Instance.InsertBillDetal(billDetail);
                    
                }

            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
            Refesh();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void frCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void btnSuDungDiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvProduct.RowCount == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn món để thanh toán!");
                    return;
                }
                int discount = (int)spDiscount.Value;
                int id_member = (int)cbMember.EditValue;
                int usingPoint = int.Parse(txtDiem.Text);
                if (XtraMessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn này chứ?"),
                        "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    CheckOutContext checkOutContext = new CheckOutContext();
                    checkOutContext.SetStrategy(new MemberCheckOut());
                    checkOutContext.CheckOut(discount, finalPrice, id_hoadon,usingPoint,id_member);
                    BillBus.Instance.UpdateBill(id_hoadon);
                    Refesh();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Refesh() {
            id_hoadon = 0;
            thanhtien = 0; totalPrice = 0; finalPrice = 0;
            txtThanhTien.Text = null;
            spDiscount.Text = null;
            txtTongCong.Text = null;
            taoHoaDon();
            ShowBill();
            loadListProduct();
        }
        private void spDiscount_EditValueChanged(object sender, EventArgs e)
        {
            finalPrice = totalPrice - (totalPrice / 100) * ((int)spDiscount.Value);
            txtTongCong.Text = finalPrice.ToString("c", culture);
        }
    }
}