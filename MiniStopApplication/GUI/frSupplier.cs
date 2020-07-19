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
using System.IO;
using MiniStopApplication.BUS;

namespace MiniStopApplication.GUI
{
    public partial class frSupplier : DevExpress.XtraEditors.XtraForm
    {
        public frSupplier()
        {
            InitializeComponent();
            LoadAllSupplier();
        }
        int id_supplier = 0;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((OPF.ShowDialog() == DialogResult.OK))
            {
                picImage.Image = Image.FromFile(OPF.FileName);
            }
        }
        private void LoadAllSupplier()
        {
            try
            {
                gcSupplier.DataSource = SupplierBus.Instance.GetAllSupplier();
                gvSupplier.Columns[0].Caption = "Mã nhà cung cấp";
                gvSupplier.Columns[1].Caption = "Tên nhà cung cấp";
                gvSupplier.Columns[2].Caption = "Số điện thoại";
                gvSupplier.Columns[3].Caption = "Địa chỉ";
                gvSupplier.Columns[4].Caption = "Hình ảnh";
                gvSupplier.RowHeight = 60;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
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
                string name_supplier = txtTen.Text;
                string phone = txtSDT.Text;
                string address = txtDiaChi.Text;
                Supplier supplier = new Supplier(
                    name_supplier,
                    phone,
                    address,
                     toArray()
                    );
                SupplierBus.Instance.InsertSupplier(supplier);
                XtraMessageBox.Show("Thêm nhà cung cấp thành công!", "Thêm nhà cung cấp");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
            ResetInput();
            LoadAllSupplier();
        }

        private void ResetInput()
        {
            txtTen.Text = null;
            txtDiaChi.Text = null;
            txtSDT.Text = null;
            picImage.Image = null;
            id_supplier = 0;
        }

        private Array toArray()
        {
            MemoryStream pic = new MemoryStream();
            picImage.Image.Save(pic, picImage.Image.RawFormat);
            return pic.ToArray();
        }
        private void toImage(byte[] val)
        {
            MemoryStream picture = new MemoryStream(val);
            picImage.Image = Image.FromStream(picture);
        }

        private void gcSupplier_Click(object sender, EventArgs e)
        {
            if (gvSupplier.RowCount > 0)
            {
                id_supplier = int.Parse(gvSupplier.GetRowCellValue(gvSupplier.FocusedRowHandle, gvSupplier.Columns[0]).ToString());
                txtTen.Text = gvSupplier.GetRowCellValue(gvSupplier.FocusedRowHandle, gvSupplier.Columns[1]).ToString();
                txtSDT.Text = (gvSupplier.GetRowCellValue(gvSupplier.FocusedRowHandle, gvSupplier.Columns[2]).ToString());
                txtDiaChi.Text = (gvSupplier.GetRowCellValue(gvSupplier.FocusedRowHandle, gvSupplier.Columns[3]).ToString());
                byte[] pic;
                pic = (byte[])gvSupplier.GetRowCellValue(gvSupplier.FocusedRowHandle, gvSupplier.Columns[4]);
                toImage(pic);
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật nhà cung cấp này chứ!", "Cập nhật nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string name_supplier = txtTen.Text;
                    string phone = txtSDT.Text;
                    string address = txtDiaChi.Text;
                    Supplier supplier = new Supplier(
                        id_supplier,
                       name_supplier,
                       phone,
                       address,
                        toArray()
                   );
                    SupplierBus.Instance.UpdateSupplier(supplier);
                    XtraMessageBox.Show("Cập nhật nhà cung cấp thành công!", "Cập nhật nhà cung cấp");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex.Message);
                }
                ResetInput();
                LoadAllSupplier();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhà cung cấp này chứ!", "Xóa nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SupplierBus.Instance.DeleteSupplier(id_supplier);
                    XtraMessageBox.Show("Xóa nhà cung cấp thành công!", "Xóa nhà cung cấp");

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex.Message);
                }
                ResetInput();
                LoadAllSupplier();
            }
        }
    }
}