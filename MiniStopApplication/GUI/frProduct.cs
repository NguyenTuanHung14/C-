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

        private void LoadAllProduct() {
            try
            {
                gcProduct.DataSource = ProductBus.Instance.GetAllProduct();
                gvProduct.Columns[0].Caption = "Mã hàng hóa";
                gvProduct.Columns[1].Caption = "Tên hàng hóa";
                gvProduct.Columns[2].Caption = "Gía cả";
                gvProduct.Columns[3].Caption = "Số lượng trên kệ";
                gvProduct.Columns[4].Caption = "Ngày sản xuất";
                gvProduct.Columns[5].Caption = "Ngày hết hạn";
                gvProduct.Columns[6].Caption = "Khuyến mãi";
                gvProduct.Columns[7].Caption = "Mã loại hàng hóa";

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
                //float price = float.Parse(txtGia.Text);
                //int amount = int.Parse(txtSoLuong.Text);
                //DateTime mfg_date = Convert.ToDateTime(dpkNgaySanXuat.Value);
                //DateTime exp_date = Convert.ToDateTime(dpkNgayHetHan.Value);
                //float discount = float.Parse(txtGiamGia.Text);
                Product product = new Product(
                    name_product,
                    0,
                    0,
                    DateTime.Now,
                    DateTime.Now,
                    0,
                    1
                );
                ProductBus.Instance.InsertProduct(product);
                LoadAllProduct();
            }
            catch (Exception ex) {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }

       
    }
}