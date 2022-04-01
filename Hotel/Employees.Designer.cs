namespace Hotel
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.employeesTableAdapter = new Hotel.HotelDataSetTableAdapters.EmployeesTableAdapter();
            this.Button_AddEmployee = new System.Windows.Forms.Button();
            this.Button_DeleteEmployee = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-9, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(781, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            this.surNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Button_AddEmployee
            // 
            this.Button_AddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AddEmployee.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_AddEmployee.Location = new System.Drawing.Point(21, 359);
            this.Button_AddEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.Button_AddEmployee.Name = "Button_AddEmployee";
            this.Button_AddEmployee.Size = new System.Drawing.Size(171, 30);
            this.Button_AddEmployee.TabIndex = 1;
            this.Button_AddEmployee.Text = "Добавить";
            this.Button_AddEmployee.UseVisualStyleBackColor = false;
            this.Button_AddEmployee.Click += new System.EventHandler(this.Button_AddEmployee_Click);
            // 
            // Button_DeleteEmployee
            // 
            this.Button_DeleteEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_DeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_DeleteEmployee.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DeleteEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_DeleteEmployee.Location = new System.Drawing.Point(225, 359);
            this.Button_DeleteEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.Button_DeleteEmployee.Name = "Button_DeleteEmployee";
            this.Button_DeleteEmployee.Size = new System.Drawing.Size(171, 30);
            this.Button_DeleteEmployee.TabIndex = 2;
            this.Button_DeleteEmployee.Text = "Удалить";
            this.Button_DeleteEmployee.UseVisualStyleBackColor = false;
            this.Button_DeleteEmployee.Click += new System.EventHandler(this.Button_DeleteEmployee_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(714, 351);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(44, 38);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 398);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.Button_DeleteEmployee);
            this.Controls.Add(this.Button_AddEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HotelDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Button_AddEmployee;
        private System.Windows.Forms.Button Button_DeleteEmployee;
        private System.Windows.Forms.Button RefreshButton;
    }
}