using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel
{
    public partial class DeleteReservation : Form
    {
        public DeleteReservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                   "Уверены, что хотите выйти?",
                   "Предупреждение",
                   MessageBoxButtons.OKCancel
           );
            if (result == DialogResult.OK)
                Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var roomId = Convert.ToInt32(textBox1.Text);
                Reservation reservation = context.Reservations.Find(roomId);
                context.Reservations.Remove(reservation);
                context.SaveChanges();
                string sql = @"Server=(localdb)\mssqllocaldb;Database=Hotel;Trusted_Connection=True;";
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    string Status = "Свободная";
                    var query = $"Update Rooms set Status = N'{Status}' where Id = {reservation.RoomId}";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Close();
                }
            }
        }
    }
}
