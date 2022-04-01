using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEmployee_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
        }

        private void ButtonResidents_Click(object sender, EventArgs e)
        {
            ResidentsForm residentsForm = new ResidentsForm();
            residentsForm.Show();
        }

        private void ButtonRooms_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.Show();
        }

        private void ButtonReservation_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show();
        }
    }
}
