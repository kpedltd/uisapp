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
            this.studentName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(723, 63);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 55);
            this.panel1.TabIndex = 0;
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
            this.panel2.Controls.Add(this.resultInfoButton);
            this.panel2.Location = new System.Drawing.Point(581, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 55);
            this.panel2.TabIndex = 1;
            // 
            // resultInfoButton
            // 
            this.resultInfoButton.BackgroundImage = global::UisApp.Properties.Resources.about;
            this.resultInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resultInfoButton.FlatAppearance.BorderSize = 0;
            this.resultInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultInfoButton.Location = new System.Drawing.Point(43, 2);
            this.resultInfoButton.Name = "resultInfoButton";
            this.resultInfoButton.Size = new System.Drawing.Size(50, 50);
            this.resultInfoButton.TabIndex = 5;
            this.resultInfoButton.UseVisualStyleBackColor = true;
            // 
            // StudentResultItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StudentResultItemView";
            this.Size = new System.Drawing.Size(727, 67);
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
    }
}
