namespace UisApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.upperBorder = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.hideButton = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.taskButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.ratingButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.attendanceButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.profileButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.compContainer = new UisApp.Components.UisComponentsContainer();
            this.upperBorder.SuspendLayout();
            this.itemsPanel.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperBorder
            // 
            this.upperBorder.Controls.Add(this.panel4);
            this.upperBorder.Controls.Add(this.button8);
            this.upperBorder.Controls.Add(this.button7);
            this.upperBorder.Controls.Add(this.label1);
            this.upperBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperBorder.Location = new System.Drawing.Point(0, 0);
            this.upperBorder.Name = "upperBorder";
            this.upperBorder.Size = new System.Drawing.Size(800, 34);
            this.upperBorder.TabIndex = 3;
            this.upperBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperBorder_MouseMove);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(212, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 445);
            this.panel4.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Right;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.Location = new System.Drawing.Point(732, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 34);
            this.button8.TabIndex = 2;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(766, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 34);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Преподаватель ВУЗА";
            // 
            // itemsPanel
            // 
            this.itemsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.itemsPanel.Controls.Add(this.panel12);
            this.itemsPanel.Controls.Add(this.panel11);
            this.itemsPanel.Controls.Add(this.panel10);
            this.itemsPanel.Controls.Add(this.panel9);
            this.itemsPanel.Controls.Add(this.panel8);
            this.itemsPanel.Controls.Add(this.panel7);
            this.itemsPanel.Controls.Add(this.panel6);
            this.itemsPanel.Controls.Add(this.panel5);
            this.itemsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemsPanel.Location = new System.Drawing.Point(0, 34);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(220, 489);
            this.itemsPanel.TabIndex = 26;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label17);
            this.panel12.Controls.Add(this.hideButton);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 420);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(220, 60);
            this.panel12.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label17.Location = new System.Drawing.Point(60, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 24);
            this.label17.TabIndex = 5;
            this.label17.Text = "Скрыть";
            // 
            // hideButton
            // 
            this.hideButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_close_pane_50px_1;
            this.hideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideButton.FlatAppearance.BorderSize = 0;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.Location = new System.Drawing.Point(4, 6);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(50, 50);
            this.hideButton.TabIndex = 4;
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 360);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(220, 60);
            this.panel11.TabIndex = 35;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label15);
            this.panel10.Controls.Add(this.checkButton);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 300);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(220, 60);
            this.panel10.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label15.Location = new System.Drawing.Point(60, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 24);
            this.label15.TabIndex = 5;
            this.label15.Text = "Проверка заданий";
            // 
            // checkButton
            // 
            this.checkButton.BackgroundImage = global::UisApp.Properties.Resources.result;
            this.checkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkButton.FlatAppearance.BorderSize = 0;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.Location = new System.Drawing.Point(4, 6);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(50, 50);
            this.checkButton.TabIndex = 4;
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label14);
            this.panel9.Controls.Add(this.taskButton);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 240);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(220, 60);
            this.panel9.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label14.Location = new System.Drawing.Point(60, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 24);
            this.label14.TabIndex = 5;
            this.label14.Text = "Задания";
            // 
            // taskButton
            // 
            this.taskButton.BackgroundImage = global::UisApp.Properties.Resources.task;
            this.taskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.taskButton.FlatAppearance.BorderSize = 0;
            this.taskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskButton.Location = new System.Drawing.Point(4, 6);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(50, 50);
            this.taskButton.TabIndex = 4;
            this.taskButton.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.ratingButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 180);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(220, 60);
            this.panel8.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(60, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "Рейтинг";
            // 
            // ratingButton
            // 
            this.ratingButton.BackgroundImage = global::UisApp.Properties.Resources.rating;
            this.ratingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ratingButton.FlatAppearance.BorderSize = 0;
            this.ratingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ratingButton.Location = new System.Drawing.Point(4, 6);
            this.ratingButton.Name = "ratingButton";
            this.ratingButton.Size = new System.Drawing.Size(50, 50);
            this.ratingButton.TabIndex = 4;
            this.ratingButton.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.attendanceButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 120);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 60);
            this.panel7.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(60, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 24);
            this.label12.TabIndex = 5;
            this.label12.Text = "Посещаемость";
            // 
            // attendanceButton
            // 
            this.attendanceButton.BackgroundImage = global::UisApp.Properties.Resources.attendance;
            this.attendanceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attendanceButton.FlatAppearance.BorderSize = 0;
            this.attendanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendanceButton.Location = new System.Drawing.Point(4, 6);
            this.attendanceButton.Name = "attendanceButton";
            this.attendanceButton.Size = new System.Drawing.Size(50, 50);
            this.attendanceButton.TabIndex = 4;
            this.attendanceButton.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.scheduleButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 60);
            this.panel6.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(60, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "Расписание";
            // 
            // scheduleButton
            // 
            this.scheduleButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_schedule_50px;
            this.scheduleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scheduleButton.FlatAppearance.BorderSize = 0;
            this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleButton.Location = new System.Drawing.Point(4, 6);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(50, 50);
            this.scheduleButton.TabIndex = 4;
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.profileButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 60);
            this.panel5.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(60, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Профиль";
            // 
            // profileButton
            // 
            this.profileButton.BackgroundImage = global::UisApp.Properties.Resources.profile1;
            this.profileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Location = new System.Drawing.Point(4, 6);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(50, 50);
            this.profileButton.TabIndex = 4;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // compContainer
            // 
            this.compContainer.AutoSize = true;
            this.compContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compContainer.Location = new System.Drawing.Point(220, 34);
            this.compContainer.Name = "compContainer";
            this.compContainer.Size = new System.Drawing.Size(580, 489);
            this.compContainer.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.compContainer);
            this.Controls.Add(this.itemsPanel);
            this.Controls.Add(this.upperBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.upperBorder.ResumeLayout(false);
            this.upperBorder.PerformLayout();
            this.itemsPanel.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel upperBorder;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel itemsPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ratingButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button attendanceButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Timer timer;
        private Components.UisComponentsContainer compContainer;
    }
}