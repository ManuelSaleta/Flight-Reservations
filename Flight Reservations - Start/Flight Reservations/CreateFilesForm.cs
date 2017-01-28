using Reservation_Library;
using System;
using System.Windows.Forms;


namespace FlightReservationGui
{
    public partial class CreateFilesForm : Form
    {
        FlightFactory factory = new FlightFactory();

        public CreateFilesForm()
        {
            InitializeComponent();
        }

        private void btnDisplayFlights_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "flights.xml";
            frm.ShowDialog();
        }

        private void btnCreateFlights_Click(object sender, EventArgs e)
        {

        }

        private void CreateFilesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
