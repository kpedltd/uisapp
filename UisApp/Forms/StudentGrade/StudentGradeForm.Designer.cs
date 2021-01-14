namespace UisApp.Forms.StudentGradeForm
{
    partial class StudentGradeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGradeForm));
            this.upperBorder = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.gradeNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CanceldButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.upperBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNum)).BeginInit();
            this.SuspendLayout();
            // 
            // upperBorder
            // 
            this.upperBorder.Controls.Add(this.CloseButton);
            this.upperBorder.Controls.Add(this.label1);
            this.upperBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperBorder.Location = new System.Drawing.Point(0, 0);
            this.upperBorder.Name = "upperBorder";
            this.upperBorder.Size = new System.Drawing.Size(642, 34);
            this.upperBorder.TabIndex = 5;
            this.upperBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperBorder_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(608, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 34);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оценить задание студента";
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(12, 111);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(618, 164);
            this.commentBox.TabIndex = 6;
            // 
            // gradeNum
            // 
            this.gradeNum.Location = new System.Drawing.Point(12, 64);
            this.gradeNum.Name = "gradeNum";
            this.gradeNum.Size = new System.Drawing.Size(120, 20);
            this.gradeNum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оценка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Комментарий";
            // 
            // CanceldButton
            // 
            this.CanceldButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_delete_50px;
            this.CanceldButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CanceldButton.FlatAppearance.BorderSize = 0;
            this.CanceldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CanceldButton.Location = new System.Drawing.Point(524, 281);
            this.CanceldButton.Name = "CanceldButton";
            this.CanceldButton.Size = new System.Drawing.Size(50, 50);
            this.CanceldButton.TabIndex = 18;
            this.CanceldButton.UseVisualStyleBackColor = true;
            this.CanceldButton.Click += new System.EventHandler(this.CanceldButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_approval_50px;
            this.OkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OkButton.FlatAppearance.BorderSize = 0;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Location = new System.Drawing.Point(580, 281);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(50, 50);
            this.OkButton.TabIndex = 17;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // StudentGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(642, 342);
            this.Controls.Add(this.CanceldButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradeNum);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.upperBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentGradeForm";
            this.Text = "StudentGradeForm";
            this.upperBorder.ResumeLayout(false);
            this.upperBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel upperBorder;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.NumericUpDown gradeNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CanceldButton;
        private System.Windows.Forms.Button OkButton;
    }
}