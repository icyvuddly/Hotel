using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class AddRab : Form
    {
        public AddRab()
        {
            InitializeComponent();
        }

        private void Button_AddEmployee_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    context.Employees.Add(new Employee(textBox1.Text,textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToDecimal(textBox5.Text)));
                    context.SaveChanges();
                    MessageBox.Show("Запись добавлена!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Не все данные внесены! Внесите данные заново.");
                }

            }

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                   "Уверены, что хотите выйти?",
                   "Предупреждение",
                   MessageBoxButtons.OKCancel
           );
            if (result == DialogResult.OK)
                Close();
        }
    }
}
