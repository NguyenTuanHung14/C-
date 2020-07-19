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
using MiniStopApplication.BUS.BuilderPattern;

namespace MiniStopApplication.GUI
{
    public partial class frStaff : DevExpress.XtraEditors.XtraForm
    {
        public frStaff()
        {
            InitializeComponent();
        }

        private void frStaff_Load(object sender, EventArgs e)
        {
           
        }
        int id_employee = 0, id_position = 0;
        private void LoadAllEmployee()
        {
            try
            {
                gcNhanVien.DataSource = PersonBus.Instance.GetAllPerson();
                // gvNhanVien.Columns[0].Caption = "Mã nhân viên";
                gvNhanVien.Columns[1].Caption = "Họ tên ";
                gvNhanVien.Columns[2].Caption = "Số điện thoại";
                gvNhanVien.Columns[3].Caption = "Ngày sinh";
                gvNhanVien.Columns[4].Caption = "Địa chỉ";
                gvNhanVien.Columns[5].Caption = "Email";
                gvNhanVien.Columns[6].Caption = "Vị trí";
                gvNhanVien.Columns[7].Caption = "Trạng thái";

                // gvNhanVien.RowHeight = 120;
                /* txtSoLuong.Enabled = false;
                 dpkNgayHetHan.Enabled = false;
                 dpkNgaySanXuat.Enabled = false;
                 txtGia.Enabled = false;
                 txtGiamGia.Enabled = false;*/
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void gvNhanVien_Click(object sender, EventArgs e)
        {
           
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }
        private void ResetInput()
        {
            txtHoTen.Text = null;
            txtSDT.Text = null;
            txtQueQuan.Text = null;
            txtEmail.Text = null;
            dtpNgaySinh.Value = DateTime.Now;

            id_position = 0;

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật nhân vien!", "Cập nhật nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    try
            //    {
            //        string last_name = txtHoTen.Text;
            //        string address = txtQueQuan.Text;
            //        string phone = txtSDT.Text;
            //        string email = txtEmail.Text;
            //        DateTime birth_day = dtpNgaySinh.Value;
            //        int id_position = 0;

            //        Employee employee = new Employee(id_employee, last_name, phone, birth_day, address, email, id_position);

            //        EmployeeBus.Instance.UpdateEmployee(employee);
            //        XtraMessageBox.Show("Cập nhật nhân viên thành công!", "Cập nhật nhân viên");
            //        LoadAllEmployee();

            //    }
            //    catch (Exception ex)
            //    {
            //        XtraMessageBox.Show("Error: " + ex.Message);
            //    }
            //    ResetInput();
            //}
        }

     
        private void gcNhanVien_Click_1(object sender, EventArgs e)
        {
            if (gvNhanVien.RowCount > 0)
            {
                // id_employee = int.Parse(gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[0]).ToString());
                txtHoTen.Text = gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[1]).ToString();
                txtSDT.Text = (gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[2]).ToString());
                dtpNgaySinh.Value = DateTime.Parse(gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[3]).ToString());
                txtQueQuan.Text = (gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[4]).ToString());
                //txtEmail.Text = (gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[5]).ToString());
                string a = (gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[6]).ToString());
                //    txtChucVu.Text = (gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[7]).ToString());

                if (a == "97")
                {
                    txtChucVu.Text = "Quản lí";
                }
                else
                {
                    txtChucVu.Text = "Nhân viên";
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

            try
            {
                string last_name = txtHoTen.Text;
                string address = txtQueQuan.Text;
                string phone = txtSDT.Text;
                string email = txtEmail.Text;
                DateTime birth_day = dtpNgaySinh.Value;
                PersionDirector persionDirector = new PersionDirector();
                PersonBuilder employeeBuilder = new EmployeeBuilder();
                employeeBuilder
                    .BuildAddress(address)
                    .BuildFullName(last_name)
                    .BuildEamil(email)
                    .BuildPhone(phone)
                    .BuildPosition(1)
                    .BuildBirthDate(birth_day);

                PersonBus.Instance.InsertPerson(employeeBuilder.getPerson());
                LoadAllEmployee();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
            ResetInput();
        }

        private void frStaff_Load_1(object sender, EventArgs e)
        {
            LoadAllEmployee();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        { 

            //DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhân viên này chứ!", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    try
            //    {
            //        //  string tinhtrang = "Disable";
            //        Employee employee = new Employee(id_employee);

            //        EmployeeBus.Instance.DeleteEmployee(id_employee);
            //        XtraMessageBox.Show("Xóa nhân viên thành công!", "Xóa nhân viên");
            //        LoadAllEmployee();
            //        /* EmployeeBus.Instance.DeleteEmployee(id_employee);
            //             LoadAllEmployee();*/

            //    }
            //    catch (Exception ex)
            //    {
            //        XtraMessageBox.Show("Error: " + ex.Message);
            //    }
            //    ResetInput();
            //}
        }
    }
}