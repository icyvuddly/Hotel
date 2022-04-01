using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet2.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.hotelDataSet2.Rooms);
            dataGridView1.Columns[1].HeaderText = "Номер";
            dataGridView1.Columns[2].HeaderText = "Тип";
            dataGridView1.Columns[3].HeaderText = "Статус";
            dataGridView1.Columns[4].HeaderText = "Цена за сутки $";

        }
    }
}
