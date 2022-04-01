using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class UpdateResident : Form
    {
        public static List<Resident> residents = new List<Resident>();
        public static Resident resident = new Resident();
        public UpdateResident()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string StringConnection = @"Server=(localdb)\mssqllocaldb;Database=Hotel;Trusted_Connection=True;";
            string query = "select * from Residents";
            using (SqlConnection connection = new SqlConnection(StringConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    residents.Add(new Resident(reader.GetInt32(0), reader.GetString(1),
                                reader.GetString(2), reader.GetString(3),
                                reader.GetString(4), reader.GetInt32(5),
                                reader.GetString(6), reader.GetString(7)));
                }
                reader.Close();
                connection.Close();
            }

            using (MyDbContext context = new MyDbContext())
            {
                var TextId = Convert.ToInt32(textBox1.Text);
                resident = context.Residents.Find(TextId);
                if (resident == null)
                {
                    MessageBox.Show("Строки с таким Id не найдено! Введите Id заново!");
                    textBox1.ReadOnly = false;
                }
                else
                {
                    textBox2.Text = resident.CodePassport;
                    textBox3.Text = resident.SurName;
                    textBox4.Text = resident.Name;
                    textBox5.Text = resident.Patronymic;
                    textBox6.Text = Convert.ToString(resident.Age);
                    textBox7.Text = resident.Gender;
                    textBox8.Text = resident.Number;
                    textBox1.ReadOnly = true;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                   "Уверены, что хотите выйти?",
                   "Предупреждение",
                   MessageBoxButtons.OKCancel
           );
            if (result == DialogResult.OK)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                
                resident.Id = Convert.ToInt32(textBox1.Text);
                resident.CodePassport = textBox2.Text;
                resident.SurName = textBox3.Text;
                resident.Name = textBox4.Text;
                resident.Patronymic = textBox5.Text;
                resident.Age = Convert.ToInt32(textBox6.Text);
                resident.Gender = textBox7.Text;
                resident.Number = textBox8.Text;
                var res = context.Residents.Find(resident.Id);
                context.Residents.Remove(res);
                context.Residents.Add(resident);
                context.SaveChanges();
                MessageBox.Show("Данные обновлены!");
                Close();
            }
        }
    }
}
