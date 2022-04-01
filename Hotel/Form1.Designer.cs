namespace Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonEmployee = new System.Windows.Forms.Button();
            this.ButtonResidents = new System.Windows.Forms.Button();
            this.ButtonRooms = new System.Windows.Forms.Button();
            this.ButtonReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonEmployee
            // 
            this.ButtonEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEmployee.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonEmployee.Location = new System.Drawing.Point(70, 135);
            this.ButtonEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonEmployee.Name = "ButtonEmployee";
            this.ButtonEmployee.Size = new System.Drawing.Size(171, 30);
            this.ButtonEmployee.TabIndex = 0;
            this.ButtonEmployee.Text = "Сотрудники";
            this.ButtonEmployee.UseVisualStyleBackColor = false;
            this.ButtonEmployee.Click += new System.EventHandler(this.ButtonEmployee_Click);
            // 
            // ButtonResidents
            // 
            this.ButtonResidents.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonResidents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonResidents.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResidents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonResidents.Location = new System.Drawing.Point(70, 182);
            this.ButtonResidents.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonResidents.Name = "ButtonResidents";
            this.ButtonResidents.Size = new System.Drawing.Size(171, 30);
            this.ButtonResidents.TabIndex = 1;
            this.ButtonResidents.Text = "Постояльцы";
            this.ButtonResidents.UseVisualStyleBackColor = false;
            this.ButtonResidents.Click += new System.EventHandler(this.ButtonResidents_Click);
            // 
            // button3
            // 
            this.ButtonRooms.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonRooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonRooms.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRooms.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonRooms.Location = new System.Drawing.Point(70, 231);
            this.ButtonRooms.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRooms.Name = "ButtonRooms";
            this.ButtonRooms.Size = new System.Drawing.Size(171, 30);
            this.ButtonRooms.TabIndex = 2;
            this.ButtonRooms.Text = "Гостиничные номера";
            this.ButtonRooms.UseVisualStyleBackColor = false;
            this.ButtonRooms.Click += new System.EventHandler(this.ButtonRooms_Click);
            // 
            // button4
            // 
            this.ButtonReservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonReservation.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReservation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonReservation.Location = new System.Drawing.Point(70, 280);
            this.ButtonReservation.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonReservation.Name = "ButtonReservation";
            this.ButtonReservation.Size = new System.Drawing.Size(171, 30);
            this.ButtonReservation.TabIndex = 3;
            this.ButtonReservation.Text = "Бронь";
            this.ButtonReservation.UseVisualStyleBackColor = false;
            this.ButtonReservation.Click += new System.EventHandler(this.ButtonReservation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 395);
            this.Controls.Add(this.ButtonReservation);
            this.Controls.Add(this.ButtonRooms);
            this.Controls.Add(this.ButtonResidents);
            this.Controls.Add(this.ButtonEmployee);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonEmployee;
        private System.Windows.Forms.Button ButtonResidents;
        private System.Windows.Forms.Button ButtonRooms;
        private System.Windows.Forms.Button ButtonReservation;
    }
}

