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
    public partial class frAddMember : DevExpress.XtraEditors.XtraForm
    {
        public frAddMember()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void frAddMember_Load(object sender, EventArgs e)
        {

        }
        private void bttCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = new Member(
                    txtHoTen.Text,
                    txtSDT.Text,
                    txtEmail.Text
                    );
                MemberBus.Instance.InsertMember(member);
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
           
        }
    }
}