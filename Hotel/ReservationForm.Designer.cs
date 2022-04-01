namespace Hotel
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet3 = new Hotel.HotelDataSet3();
            this.reservationsTableAdapter = new Hotel.HotelDataSet3TableAdapters.ReservationsTableAdapter();
            this.Button_AddEmployee = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.residentIdDataGridViewTextBoxColumn,
            this.roomIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.reservationPeriodDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(828, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residentIdDataGridViewTextBoxColumn
            // 
            this.residentIdDataGridViewTextBoxColumn.DataPropertyName = "ResidentId";
            this.residentIdDataGridViewTextBoxColumn.HeaderText = "ResidentId";
            this.residentIdDataGridViewTextBoxColumn.Name = "residentIdDataGridViewTextBoxColumn";
            this.residentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "RoomId";
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            this.roomIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservationPeriodDataGridViewTextBoxColumn
            // 
            this.reservationPeriodDataGridViewTextBoxColumn.DataPropertyName = "ReservationPeriod";
            this.reservationPeriodDataGridViewTextBoxColumn.HeaderText = "ReservationPeriod";
            this.reservationPeriodDataGridViewTextBoxColumn.Name = "reservationPeriodDataGridViewTextBoxColumn";
            this.reservationPeriodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "Reservations";
            this.reservationsBindingSource.DataSource = this.hotelDataSet3;
            // 
            // hotelDataSet3
            // 
            this.hotelDataSet3.DataSetName = "HotelDataSet3";
            this.hotelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // Button_AddEmployee
            // 
            this.Button_AddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AddEmployee.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_AddEmployee.Location = new System.Drawing.Point(9, 378);
            this.Button_AddEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.Button_AddEmployee.Name = "Button_AddEmployee";
            this.Button_AddEmployee.Size = new System.Drawing.Size(93, 29);
            this.Button_AddEmployee.TabIndex = 11;
            this.Button_AddEmployee.Text = "Добавить";
            this.Button_AddEmployee.UseVisualStyleBackColor = false;
            this.Button_AddEmployee.Click += new System.EventHandler(this.Button_AddEmployee_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(773, 378);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(38, 29);
            this.RefreshButton.TabIndex = 12;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(163, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.Button_AddEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataSet3 hotelDataSet3;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private HotelDataSet3TableAdapters.ReservationsTableAdapter reservationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Button_AddEmployee;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button button1;
    }
}