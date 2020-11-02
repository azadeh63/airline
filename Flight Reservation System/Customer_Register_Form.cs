using System;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    public partial class Customer_Register_Form : Form
    {
        AirlineDbEntities dq;
        public Customer_Register_Form()
        {
            InitializeComponent();
            dq = new AirlineDbEntities();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            /*
            txtBox_CustomerFirstName.Text = "";
            txtBox_CustomerLastName.Text = "";
            txtBox_CustomerEmail.Text = "";
            txtBox_CustomerPassword.Text = "";
            txtBox_CustomerPasswordConfirm.Text = "";
            cdr_CustomerBirthday.Value = DateTime.Now;
*/
        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CustomerSave_Click(object sender, EventArgs e)
        {
            Personal_Info pi = new Personal_Info();
            pi.FirstName = txtBox_CustomerFirstName.Text;
            pi.LastName = txtBox_CustomerLastName.Text;
            pi.Email = txtBox_CustomerEmail.Text;
            pi.Password = txtBox_CustomerPassword.Text;
            pi.BirthDate = Convert.ToDateTime(cdr_CustomerBirthday.Text);
            dq.Personal_Info.Add(pi);
            dq.SaveChanges();

            MessageBox.Show("Personal Information Saved");
        }

        private void Customer_Register_Form_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_CustomerFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
