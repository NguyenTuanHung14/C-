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
using MiniStopApplication.DTO;
using MiniStopApplication.BUS;

namespace MiniStopApplication.GUI
{
    public partial class frCategory : DevExpress.XtraEditors.XtraForm
    {
        public frCategory()
        {
            InitializeComponent();
            LoadAllProduct();

        }
        int id_productType = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string name_productType = txtTen.Text;

                Categories category = new Categories(
                  name_productType
                );
                CategoryBus.Instance.InsertCategory(category);

                LoadAllProduct();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
            ResetInput();
        }

        private void ResetInput()
        {
            txtTen.Text = null;
            id_productType = 0;
        }

        private void LoadAllProduct()
        {
            gcCategory.DataSource = CategoryBus.Instance.GetAllProductType();
            gvCategory.Columns[0].Caption = "Mã loại sản phẩm ";
            gvCategory.Columns[1].Caption = "Tên loại sản phẩm";
        }

        private void gcCategory_Click(object sender, EventArgs e)
        {
            if (gvCategory.RowCount > 0) {
                id_productType = int.Parse(gvCategory.GetRowCellValue(gvCategory.FocusedRowHandle, gvCategory.Columns[0]).ToString());
                txtTen.Text = (gvCategory.GetRowCellValue(gvCategory.FocusedRowHandle, gvCategory.Columns[1]).ToString());
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa loại sản phẩm này chứ!", "Xóa loại sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    CategoryBus.Instance.DeleteCategory(id_productType);
                    XtraMessageBox.Show("Xóa loại sản phẩm thành công!", "Xóa loại sản phẩm");
                    LoadAllProduct();

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex.Message);
                }
                ResetInput();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}