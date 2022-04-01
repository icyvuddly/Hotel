using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel
{
    public partial class AddReservation : Form
    {
        public AddReservation()
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

        private void Button_AddReservation_Click(object sender, EventArgs e)
        {
            string sql = @"Server=(localdb)\mssqllocaldb;Database=Hotel;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string Status = "Забронирована";
                string Status1 = "Свободная";
                List<Room> room = new List<Room>();
                Reservation reservation = new Reservation();
                reservation.ResidentId = Convert.ToInt32(textBox1.Text);
                reservation.RoomId = Convert.ToInt32(textBox2.Text);
                reservation.EmployeeId = Convert.ToInt32(textBox3.Text);
                reservation.ReservationPeriod = Convert.ToInt32(textBox4.Text);
                var query = $"select * from Rooms where Id={reservation.RoomId} and Status = N'{Status1}'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    room.Add(new Room(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetDecimal(4)));
                reader.Close();
                
                    if (room.Count == 0)
                    {
                        MessageBox.Show("Комнаты с таким Id не найдено, либо она уже забронирована. Добавление записи отменено!");
                        conn.Close();
                        Close();
                    }
                    else
                    {
                        foreach (Room r1 in room)
                        {
                            reservation.TotalCost = reservation.ReservationPeriod * r1.Cost;
                        }
                        using (MyDbContext context = new MyDbContext())
                        {

                            context.Reservations.Add(reservation);
                            context.SaveChanges();
                            query = $"Update Rooms set Status = N'{Status}' where Id = {reservation.RoomId}";
                            cmd.CommandText = query;
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Запись добавлена.");
                            Close();
                        }
                    }  
            }

        }
    }
}
