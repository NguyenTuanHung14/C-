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
using DevExpress.XtraEditors.Filtering.Templates;
using MiniStopApplication.DTO;
using System.IO;

namespace MiniStopApplication.GUI
{
    public partial class frProduct : DevExpress.XtraEditors.XtraForm
    {
        public frProduct()
        {
            InitializeComponent();
        }

        private void frProduct_Load(object sender, EventArgs e)
        {
            LoadAllProduct();
        }
        int id_product = 0,id_productType = 0;
    
        private void LoadAllProduct() {
            try
            {
                gcProduct.DataSource = ProductBus.Instance.GetAllProduct();
                gvProduct.Columns[0].Caption = "Mã hàng hóa";
                gvProduct.Columns[1].Caption = "Tên hàng hóa";
                gvProduct.Columns[2].Caption = "Gía cả";
                gvProduct.Columns[3].Caption = "Số lượng trên kệ";
                gvProduct.Columns[4].Caption = "Hình ảnh";
                gvProduct.Columns[5].Caption = "Ngày sản xuất";
                gvProduct.Columns[6].Caption = "Ngày hết hạn";
                gvProduct.Columns[7].Caption = "Khuyến mãi";
                gvProduct.Columns[8].Caption = "Mã loại hàng hóa";

                gvProduct.RowHeight = 100;
                txtSoLuong.Enabled = false;
                dpkNgayHetHan.Enabled = false;
                dpkNgaySanXuat.Enabled = false;
                txtGia.Enabled = false;
                txtGiamGia.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string name_product = txtTenHangHoa.Text;
              
                Product product = new Product(
                    name_product,
                    0,
                    0,
                   toArray(),    
                    DateTime.Now,
                    DateTime.Now,
                    0,
                   (int)(cbDanhMuc.EditValue)
                );
                ProductBus.Instance.InsertProduct(product);
                LoadAllProduct();
               
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
            ResetInput();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (radioXemTatCa.Checked == true) {
                LoadAllProduct();
            }
            if (radioXemTheoDanhMuc.Checked == true) {
                XemProductTheoDanhMuc((int)(cbTimKiem.EditValue));
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật sản phẩm!", "Cập nhật sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string name_product = txtTenHangHoa.Text;
                    float price = float.Parse(txtGia.Text);
                    int amount = int.Parse(txtSoLuong.Text);
                    DateTime mfg_date = Convert.ToDateTime(dpkNgaySanXuat.Value);
                    DateTime exp_date = Convert.ToDateTime(dpkNgayHetHan.Value);
                    float discount = float.Parse(txtGiamGia.Text);
                    Product product = new Product(
                        id_product,
                        name_product,
                        price,
                        amount,
                        toArray(),
                        mfg_date,
                        exp_date,
                        discount,
                        id_productType
                    );
                    ProductBus.Instance.UpdateProduct(product);
                    XtraMessageBox.Show("Cập nhật sản phẩm thành công!", "Cập nhật sản phẩm");
                    LoadAllProduct();
                 
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex.Message);
                }
                ResetInput();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa sản phẩm này chứ!", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    ProductBus.Instance.DeleteProduct(id_product);
                    XtraMessageBox.Show("Xóa sản phẩm thành công!", "Xóa sản phẩm");
                    LoadAllProduct();
                  
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex.Message);
                }
                ResetInput();
            }
        }
        private Array toArray()
        {
            MemoryStream pic = new MemoryStream();
            picImage.Image.Save(pic, picImage.Image.RawFormat);
            return pic.ToArray();
        }
        private void toImage(byte[] val) {
            MemoryStream picture = new MemoryStream(val);
            picImage.Image = Image.FromStream(picture);
        }
        private void gvProduct_Click(object sender, EventArgs e)
        {
            if (gvProduct.RowCount > 0)
            {
                id_product = int.Parse(gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[0]).ToString());
                txtTenHangHoa.Text = gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[1]).ToString();
                txtGia.Text = (gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[2]).ToString());
                txtSoLuong.Text = (gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[3]).ToString());
                dpkNgaySanXuat.Value = DateTime.Parse(gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[5]).ToString());
                dpkNgayHetHan.Value = DateTime.Parse(gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[6]).ToString());
                txtGiamGia.Text =(gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[7]).ToString());
                id_productType = int.Parse(gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[8]).ToString());
                byte[] pic;
                pic = (byte[])gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, gvProduct.Columns[4]);
                MemoryStream picture = new MemoryStream(pic);
                toImage(pic);

                dpkNgayHetHan.Enabled = true;
                dpkNgaySanXuat.Enabled = true;
                txtGia.Enabled = true;
                txtGiamGia.Enabled = true;
                txtSoLuong.Enabled = true;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((OPF.ShowDialog() == DialogResult.OK))
            {
                picImage.Image = Image.FromFile(OPF.FileName);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void XemProductTheoDanhMuc(int id_danhmua) {
            try
            {
                gcProduct.DataSource = ProductBus.Instance.GetAllProductByType(id_danhmua);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                gcProduct.DataSource = ProductBus.Instance.seacrhProduct(txtSearchCategory.Text);
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbTimKiem_MouseHover(object sender, EventArgs e)
        {
            Load_ProductType();
        }
        private void Load_ProductType() {
            cbDanhMuc.Properties.DataSource = CategoryBus.Instance.GetAllProductType();
            cbDanhMuc.Properties.DisplayMember = "TenLoaiHangHoa";
            cbDanhMuc.Properties.ValueMember = "MaLoaiHangHoa";

            cbTimKiem.Properties.DataSource = CategoryBus.Instance.GetAllProductType();
            cbTimKiem.Properties.DisplayMember = "TenLoaiHangHoa";
            cbTimKiem.Properties.ValueMember = "MaLoaiHangHoa";
        }

        private void cbDanhMuc_MouseHover(object sender, EventArgs e)
        {
            Load_ProductType();
        }

        private void ResetInput() {
            txtTenHangHoa.Text = null;
            txtGia.Text = null;
            txtSoLuong.Text = null;
            txtSoLuong.Text = null;
            dpkNgayHetHan.Value = DateTime.Now;
            dpkNgaySanXuat.Value = DateTime.Now;
            txtGiamGia.Text = null;
            picImage.Image = null;
            id_product = 0;
            id_productType = 0;
        }
    }
}