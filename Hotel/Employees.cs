using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.hotelDataSet.Employees);

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.hotelDataSet.Employees);
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            MainForm_Activated(sender, e);
        }

        private void Button_AddEmployee_Click(object sender, EventArgs e)
        {
            AddRab addRab = new AddRab();
            addRab.Show();
        }

        private void Button_DeleteEmployee_Click(object sender, EventArgs e)
        {
            DeleteRab deleteRab = new DeleteRab();
            deleteRab.Show();  
        }
    }
}
