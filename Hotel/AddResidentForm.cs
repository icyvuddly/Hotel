using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class AddResidentForm : Form
    {
        public AddResidentForm()
        {
            InitializeComponent();
        }

        private void Button_AddResident_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text!="")
                {
                    context.Residents.Add(new Resident(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text), textBox6.Text, textBox7.Text));
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
