namespace UisApp.Components.StudyTask
{
    partial class TaskItemView
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addTestButton = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.showImageButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addTestButton);
            this.panel1.Controls.Add(this.editTaskButton);
            this.panel1.Controls.Add(this.deleteTaskButton);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.showImageButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 84);
            this.panel1.TabIndex = 0;
            // 
            // addTestButton
            // 
            this.addTestButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_survey_50px;
            this.addTestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTestButton.FlatAppearance.BorderSize = 0;
            this.addTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTestButton.Location = new System.Drawing.Point(540, 15);
            this.addTestButton.Name = "addTestButton";
            this.addTestButton.Size = new System.Drawing.Size(50, 50);
            this.addTestButton.TabIndex = 13;
            this.addTestButton.UseVisualStyleBackColor = true;
            this.addTestButton.Click += new System.EventHandler(this.AddTestButton_Click);
            // 
            // editTaskButton
            // 
            this.editTaskButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_create_50px;
            this.editTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editTaskButton.FlatAppearance.BorderSize = 0;
            this.editTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTaskButton.Location = new System.Drawing.Point(596, 15);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(50, 50);
            this.editTaskButton.TabIndex = 10;
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.EditTaskButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_delete_bin_50px;
            this.deleteTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteTaskButton.FlatAppearance.BorderSize = 0;
            this.deleteTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTaskButton.Location = new System.Drawing.Point(652, 15);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(50, 50);
            this.deleteTaskButton.TabIndex = 9;
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dateLabel.Location = new System.Drawing.Point(138, 41);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 24);
            this.dateLabel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Срок сдачи:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.titleLabel.Location = new System.Drawing.Point(15, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(97, 24);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Название";
            // 
            // showImageButton
            // 
            this.showImageButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_image_50px;
            this.showImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showImageButton.FlatAppearance.BorderSize = 0;
            this.showImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showImageButton.Location = new System.Drawing.Point(484, 17);
            this.showImageButton.Name = "showImageButton";
            this.showImageButton.Size = new System.Drawing.Size(50, 50);
            this.showImageButton.TabIndex = 5;
            this.showImageButton.UseVisualStyleBackColor = true;
            this.showImageButton.Click += new System.EventHandler(this.ShowImageButton_Click);
            // 
            // TaskItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.panel1);
            this.Name = "TaskItemView";
            this.Size = new System.Drawing.Size(727, 87);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showImageButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button addTestButton;
    }
}
