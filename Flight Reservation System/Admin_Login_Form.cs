using System;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    public partial class Admin_Login_Form : Form
    {
        public Admin_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_AdminExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            Admin_Panel_Form admin_panel_form = new Admin_Panel_Form();
            admin_panel_form.ShowDialog();
        }


    }
}
