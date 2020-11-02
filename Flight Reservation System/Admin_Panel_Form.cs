using System;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    public partial class Admin_Panel_Form : Form
    {
        AirlineDbEntities db;

        public Admin_Panel_Form()
        {
            InitializeComponent();
            db = new AirlineDbEntities();

        }

        private void groupBox_Booking_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox_Book_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbBox_FlightClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cdr_FlightDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Panel_Form_Load(object sender, EventArgs e)
        {
            cdr_FlightDateTime.Format = DateTimePickerFormat.Custom;
            cdr_FlightDateTime.CustomFormat = "dd/MM/yyyy hh : mm : ss";
            cmbBox_FlightClass.SelectedIndex = 0;
        }

        private void txtBox_Source_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddFlightInfo_Click(object sender, EventArgs e)
        {

            Flight_Details fd = new Flight_Details();
            fd.Flight_ID = txtBox_FlightId.Text;
            fd.Source = txtBox_Source.Text;
            fd.Destination = txtBox_Destination.Text;
            fd.Departure_DateTime = Convert.ToDateTime(cdr_FlightDateTime.Text);
            fd.Price = Convert.ToInt32(txtBox_FlightPrice.Text);
            fd.Flight_Class = cmbBox_FlightClass.Text;
            fd.Capacity = Convert.ToInt32(txtBox_Capacity.Text);
            db.Flight_Details.Add(fd);
            db.SaveChanges();

            MessageBox.Show("Flight added");
        }
    }
}
