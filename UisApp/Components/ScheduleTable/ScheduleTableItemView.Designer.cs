namespace UisApp.Components.ScheduleTable
{
    partial class ScheduleTableItemView
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
            this.item = new System.Windows.Forms.Panel();
            this.locationLabel = new System.Windows.Forms.Label();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.subjectNameLabel = new System.Windows.Forms.Label();
            this.item.SuspendLayout();
            this.SuspendLayout();
            // 
            // item
            // 
            this.item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item.Controls.Add(this.locationLabel);
            this.item.Controls.Add(this.groupNameLabel);
            this.item.Controls.Add(this.subjectNameLabel);
            this.item.Location = new System.Drawing.Point(0, 0);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(194, 50);
            this.item.TabIndex = 4;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.locationLabel.Location = new System.Drawing.Point(3, 32);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(0, 13);
            this.locationLabel.TabIndex = 2;
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupNameLabel.Location = new System.Drawing.Point(3, 17);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(0, 13);
            this.groupNameLabel.TabIndex = 1;
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.AutoSize = true;
            this.subjectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.subjectNameLabel.Location = new System.Drawing.Point(3, 2);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(0, 13);
            this.subjectNameLabel.TabIndex = 0;
            // 
            // ScheduleTableItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.item);
            this.Name = "ScheduleTableItemView";
            this.Size = new System.Drawing.Size(194, 50);
            this.item.ResumeLayout(false);
            this.item.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel item;
        public System.Windows.Forms.Label subjectNameLabel;
        public System.Windows.Forms.Label groupNameLabel;
        public System.Windows.Forms.Label locationLabel;
    }
}
