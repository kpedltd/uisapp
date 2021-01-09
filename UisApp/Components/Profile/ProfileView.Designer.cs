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
            this.departmentLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.PictureBox();
            this.dateValue = new System.Windows.Forms.Label();
            this.depValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.facultValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.openPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // biographtValue
            // 
            this.biographtValue.AutoSize = true;
            this.biographtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biographtValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.biographtValue.Location = new System.Drawing.Point(124, 0);
            this.biographtValue.MaximumSize = new System.Drawing.Size(600, 0);
            this.biographtValue.Name = "biographtValue";
            this.biographtValue.Size = new System.Drawing.Size(0, 24);
            this.biographtValue.TabIndex = 34;
            // 
            // biographyLabel
            // 
            this.biographyLabel.AutoSize = true;
            this.biographyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biographyLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.biographyLabel.Location = new System.Drawing.Point(3, 0);
            this.biographyLabel.Name = "biographyLabel";
            this.biographyLabel.Size = new System.Drawing.Size(115, 24);
            this.biographyLabel.TabIndex = 33;
            this.biographyLabel.Text = "Биография:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.departmentLabel.Location = new System.Drawing.Point(3, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(110, 24);
            this.departmentLabel.TabIndex = 31;
            this.departmentLabel.Text = "Кафедра:   ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dateLabel.Location = new System.Drawing.Point(3, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(155, 24);
            this.dateLabel.TabIndex = 30;
            this.dateLabel.Text = "Дата рождения:";
            // 
            // photo
            // 
            this.photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photo.Image = global::UisApp.Properties.Resources.customer;
            this.photo.InitialImage = null;
            this.photo.Location = new System.Drawing.Point(27, 22);
            this.photo.Margin = new System.Windows.Forms.Padding(27, 22, 3, 3);
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
            this.dateValue.Location = new System.Drawing.Point(164, 0);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(0, 24);
            this.dateValue.TabIndex = 35;
            // 
            // depValue
            // 
            this.depValue.AutoSize = true;
            this.depValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.depValue.Location = new System.Drawing.Point(119, 0);
            this.depValue.MaximumSize = new System.Drawing.Size(400, 0);
            this.depValue.Name = "depValue";
            this.depValue.Size = new System.Drawing.Size(0, 24);
            this.depValue.TabIndex = 36;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(205, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(519, 240);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.fullnameLabel);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(516, 55);
            this.flowLayoutPanel5.TabIndex = 36;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fullnameLabel.Location = new System.Drawing.Point(3, 0);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(316, 31);
            this.fullnameLabel.TabIndex = 29;
            this.fullnameLabel.Text = "Имя Фамилия Отчество";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dateLabel);
            this.flowLayoutPanel2.Controls.Add(this.dateValue);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 64);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(516, 34);
            this.flowLayoutPanel2.TabIndex = 30;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.departmentLabel);
            this.flowLayoutPanel3.Controls.Add(this.depValue);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 104);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(516, 49);
            this.flowLayoutPanel3.TabIndex = 31;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.facultyLabel);
            this.flowLayoutPanel4.Controls.Add(this.facultValue);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 159);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(516, 70);
            this.flowLayoutPanel4.TabIndex = 32;
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.facultyLabel.Location = new System.Drawing.Point(3, 0);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(111, 24);
            this.facultyLabel.TabIndex = 32;
            this.facultyLabel.Text = "Факультет:";
            // 
            // facultValue
            // 
            this.facultValue.AutoSize = true;
            this.facultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.facultValue.Location = new System.Drawing.Point(120, 0);
            this.facultValue.MaximumSize = new System.Drawing.Size(400, 0);
            this.facultValue.Name = "facultValue";
            this.facultValue.Size = new System.Drawing.Size(0, 24);
            this.facultValue.TabIndex = 37;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.biographyLabel);
            this.flowLayoutPanel6.Controls.Add(this.biographtValue);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(27, 268);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(697, 199);
            this.flowLayoutPanel6.TabIndex = 39;
            // 
            // openPhotoDialog
            // 
            this.openPhotoDialog.FileName = "openFileDialog1";
            this.openPhotoDialog.Filter = "Изображения (*.PNG;*.JPG)|*.PNG;*.JPG";
            // 
            // ProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.photo);
            this.Name = "ProfileView";
            this.Size = new System.Drawing.Size(762, 489);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label biographtValue;
        private System.Windows.Forms.Label biographyLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Label dateValue;
        private System.Windows.Forms.Label depValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Label facultValue;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.OpenFileDialog openPhotoDialog;
    }
}
