namespace UisApp.Components.Profile
{
    partial class ProfileView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.biographtValue = new System.Windows.Forms.Label();
            this.biographyLabel = new System.Windows.Forms.Label();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.PictureBox();
            this.dateValue = new System.Windows.Forms.Label();
            this.depValue = new System.Windows.Forms.Label();
            this.facultValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // biographtValue
            // 
            this.biographtValue.AutoSize = true;
            this.biographtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biographtValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.biographtValue.Location = new System.Drawing.Point(34, 239);
            this.biographtValue.MaximumSize = new System.Drawing.Size(500, 0);
            this.biographtValue.Name = "biographtValue";
            this.biographtValue.Size = new System.Drawing.Size(0, 24);
            this.biographtValue.TabIndex = 34;
            // 
            // biographyLabel
            // 
            this.biographyLabel.AutoSize = true;
            this.biographyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biographyLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.biographyLabel.Location = new System.Drawing.Point(231, 176);
            this.biographyLabel.Name = "biographyLabel";
            this.biographyLabel.Size = new System.Drawing.Size(115, 24);
            this.biographyLabel.TabIndex = 33;
            this.biographyLabel.Text = "Биография:";
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.facultyLabel.Location = new System.Drawing.Point(231, 122);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(111, 24);
            this.facultyLabel.TabIndex = 32;
            this.facultyLabel.Text = "Факультет:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.departmentLabel.Location = new System.Drawing.Point(231, 98);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(95, 24);
            this.departmentLabel.TabIndex = 31;
            this.departmentLabel.Text = "Кафедра:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dateLabel.Location = new System.Drawing.Point(231, 74);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(160, 24);
            this.dateLabel.TabIndex = 30;
            this.dateLabel.Text = "Дата рождения: ";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fullnameLabel.Location = new System.Drawing.Point(229, 22);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(316, 31);
            this.fullnameLabel.TabIndex = 29;
            this.fullnameLabel.Text = "Имя Фамилия Отчество";
            // 
            // photo
            // 
            this.photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photo.Image = global::UisApp.Properties.Resources.customer;
            this.photo.InitialImage = null;
            this.photo.Location = new System.Drawing.Point(27, 22);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(172, 178);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo.TabIndex = 28;
            this.photo.TabStop = false;
            this.photo.Click += new System.EventHandler(this.Photo_Click);
            // 
            // dateValue
            // 
            this.dateValue.AutoSize = true;
            this.dateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dateValue.Location = new System.Drawing.Point(397, 74);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(0, 24);
            this.dateValue.TabIndex = 35;
            // 
            // depValue
            // 
            this.depValue.AutoSize = true;
            this.depValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.depValue.Location = new System.Drawing.Point(332, 98);
            this.depValue.Name = "depValue";
            this.depValue.Size = new System.Drawing.Size(0, 24);
            this.depValue.TabIndex = 36;
            // 
            // facultValue
            // 
            this.facultValue.AutoSize = true;
            this.facultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.facultValue.Location = new System.Drawing.Point(348, 122);
            this.facultValue.Name = "facultValue";
            this.facultValue.Size = new System.Drawing.Size(0, 24);
            this.facultValue.TabIndex = 37;
            // 
            // ProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.facultValue);
            this.Controls.Add(this.depValue);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.biographtValue);
            this.Controls.Add(this.biographyLabel);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.photo);
            this.Name = "ProfileView";
            this.Size = new System.Drawing.Size(580, 489);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label biographtValue;
        private System.Windows.Forms.Label biographyLabel;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Label dateValue;
        private System.Windows.Forms.Label depValue;
        private System.Windows.Forms.Label facultValue;
    }
}
