using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet3.Reservations". При необходимости она может быть перемещена или удалена.
            this.reservationsTableAdapter.Fill(this.hotelDataSet3.Reservations);
        }
        private void Button_AddEmployee_Click(object sender, System.EventArgs e)
        {
            AddReservation addReservation = new AddReservation();
            addReservation.Show(this);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ReservationForm_Load(this, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteReservation deleteReservation = new DeleteReservation();
            deleteReservation.Show(this);
        }
    }
}

