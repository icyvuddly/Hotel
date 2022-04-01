using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class DeleteRab : Form
    {
        public DeleteRab()
        {
            InitializeComponent();
        }

        private void Button_DeleteRab_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var ID = Convert.ToInt32(textBox1.Text);
                Employee employee = context.Employees.Find(ID);
                context.Employees.Remove(employee);
                context.SaveChanges();
                MessageBox.Show("Строка удалена!");
                Close();
            }
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
    }
}
