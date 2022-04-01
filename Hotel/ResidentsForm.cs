using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class ResidentsForm : Form
    {
        public ResidentsForm()
        {
            InitializeComponent();
        }

        private void ResidentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet1.Residents". При необходимости она может быть перемещена или удалена.
            this.residentsTableAdapter.Fill(this.hotelDataSet1.Residents);

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.residentsTableAdapter.Fill(this.hotelDataSet1.Residents);
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            MainForm_Activated(sender, e);
        }

        private void Button_AddResident_Click(object sender, EventArgs e)
        {
            AddResidentForm addResidentForm = new AddResidentForm();
            addResidentForm.Show();
        }

        private void DeleteResident_Click(object sender, EventArgs e)
        {
            DeleteResident button = new DeleteResident();
            button.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateResident updateResident = new UpdateResident();
            updateResident.Show(this);
        }
    }
}
