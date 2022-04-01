namespace Hotel
{
    partial class ResidentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet1 = new Hotel.HotelDataSet1();
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.hotelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residentsTableAdapter = new Hotel.HotelDataSet1TableAdapters.ResidentsTableAdapter();
            this.Button_AddResident = new System.Windows.Forms.Button();
            this.DeleteResident = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetBindingSource)).BeginInit();
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
            this.codePassportDataGridViewTextBoxColumn,
            this.surNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.residentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(784, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codePassportDataGridViewTextBoxColumn
            // 
            this.codePassportDataGridViewTextBoxColumn.DataPropertyName = "CodePassport";
            this.codePassportDataGridViewTextBoxColumn.HeaderText = "CodePassport";
            this.codePassportDataGridViewTextBoxColumn.Name = "codePassportDataGridViewTextBoxColumn";
            this.codePassportDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residentsBindingSource
            // 
            this.residentsBindingSource.DataMember = "Residents";
            this.residentsBindingSource.DataSource = this.hotelDataSet1;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelDataSetBindingSource
            // 
            this.hotelDataSetBindingSource.DataSource = this.hotelDataSet;
            this.hotelDataSetBindingSource.Position = 0;
            // 
            // residentsTableAdapter
            // 
            this.residentsTableAdapter.ClearBeforeFill = true;
            // 
            // Button_AddResident
            // 
            this.Button_AddResident.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_AddResident.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AddResident.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddResident.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_AddResident.Location = new System.Drawing.Point(9, 374);
            this.Button_AddResident.Margin = new System.Windows.Forms.Padding(0);
            this.Button_AddResident.Name = "Button_AddResident";
            this.Button_AddResident.Size = new System.Drawing.Size(171, 30);
            this.Button_AddResident.TabIndex = 2;
            this.Button_AddResident.Text = "Добавить";
            this.Button_AddResident.UseVisualStyleBackColor = false;
            this.Button_AddResident.Click += new System.EventHandler(this.Button_AddResident_Click);
            // 
            // DeleteResident
            // 
            this.DeleteResident.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteResident.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteResident.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteResident.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteResident.Location = new System.Drawing.Point(219, 374);
            this.DeleteResident.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteResident.Name = "DeleteResident";
            this.DeleteResident.Size = new System.Drawing.Size(171, 30);
            this.DeleteResident.TabIndex = 3;
            this.DeleteResident.Text = "Удалить";
            this.DeleteResident.UseVisualStyleBackColor = false;
            this.DeleteResident.Click += new System.EventHandler(this.DeleteResident_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(429, 374);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(723, 366);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(44, 38);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ResidentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 413);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DeleteResident);
            this.Controls.Add(this.Button_AddResident);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ResidentsForm";
            this.Text = "ResidentsForm";
            this.Load += new System.EventHandler(this.ResidentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hotelDataSetBindingSource;
        private HotelDataSet hotelDataSet;
        private HotelDataSet1 hotelDataSet1;
        private System.Windows.Forms.BindingSource residentsBindingSource;
        private HotelDataSet1TableAdapters.ResidentsTableAdapter residentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Button_AddResident;
        private System.Windows.Forms.Button DeleteResident;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RefreshButton;
    }
}