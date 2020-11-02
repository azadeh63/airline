using System;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    public partial class Customer_Login_Form : Form
    {
        public Customer_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_CustomerExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CustomerLogin_Click(object sender, EventArgs e)
        {
            Customer_Register_Form customer_register_form = new Customer_Register_Form();
            customer_register_form.ShowDialog();
        }

        private void Customer_Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
