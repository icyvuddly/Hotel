using System;

using System.Windows.Forms;

namespace Hotel
{
    public partial class DeleteResident : Form
    {
        public DeleteResident()
        {
            InitializeComponent();
        }

        private void Button_DeleteRab_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var ID = Convert.ToInt32(textBox1.Text);
                Resident resident = context.Residents.Find(ID);
                context.Residents.Remove(resident);
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
