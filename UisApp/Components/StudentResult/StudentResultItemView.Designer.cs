namespace UisApp.Components.StudentResult
{
    partial class StudentResultItemView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageButton = new System.Windows.Forms.Button();
            this.resultInfoButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(723, 96);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.taskNameLabel);
            this.panel1.Controls.Add(this.studentName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 87);
            this.panel1.TabIndex = 0;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.taskNameLabel.Location = new System.Drawing.Point(20, 51);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(151, 20);
            this.taskNameLabel.TabIndex = 1;
            this.taskNameLabel.Text = "Название задания";
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.studentName.Location = new System.Drawing.Point(20, 16);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(194, 20);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "Фамилия Имя Отчество";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imageButton);
            this.panel2.Controls.Add(this.resultInfoButton);
            this.panel2.Location = new System.Drawing.Point(581, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 87);
            this.panel2.TabIndex = 1;
            // 
            // imageButton
            // 
            this.imageButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_image_50px;
            this.imageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton.FlatAppearance.BorderSize = 0;
            this.imageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageButton.Location = new System.Drawing.Point(12, 16);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(50, 50);
            this.imageButton.TabIndex = 6;
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // resultInfoButton
            // 
            this.resultInfoButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_checked_checkbox_50px;
            this.resultInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resultInfoButton.FlatAppearance.BorderSize = 0;
            this.resultInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultInfoButton.Location = new System.Drawing.Point(73, 16);
            this.resultInfoButton.Name = "resultInfoButton";
            this.resultInfoButton.Size = new System.Drawing.Size(50, 50);
            this.resultInfoButton.TabIndex = 5;
            this.resultInfoButton.UseVisualStyleBackColor = true;
            this.resultInfoButton.Click += new System.EventHandler(this.ResultInfoButton_Click);
            // 
            // StudentResultItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StudentResultItemView";
            this.Size = new System.Drawing.Size(727, 99);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Button resultInfoButton;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Label taskNameLabel;
    }
}
