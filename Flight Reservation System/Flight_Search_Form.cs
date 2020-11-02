using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    public partial class Flight_Search_Form : Form
    {
        AirlineDbEntities db;
        public Flight_Search_Form()
        {
            InitializeComponent();
            db = new AirlineDbEntities();
            BindDestination();
            BindSource();
        }

        private void BindDestination()
        {
            var items = db.Flight_Details.ToList();
            cmbBox_Destination.DataSource = items;
            cmbBox_Destination.DisplayMember = "Destination";
            //throw new NotImplementedException();
        }

        private void BindSource()
        {
            var items = db.Flight_Details.ToList();
            cmbBox_Source.DataSource = items;
            cmbBox_Source.DisplayMember = "source";
            //throw new NotImplementedException();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SearchFlight_Click(object sender, EventArgs e)
        {
            if (cmbBox_Source.Text != cmbBox_Destination.Text)
            {
                dgd_FlightInfo.DataSource = db.Flight_Details.Where(a => a.Source.Equals(cmbBox_Source.Text) && a.Destination.Equals(cmbBox_Destination.Text)).ToList();
            }
        }

        private void cmbBox_FlightClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
