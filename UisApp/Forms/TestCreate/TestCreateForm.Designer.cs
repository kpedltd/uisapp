namespace UisApp.Forms.TestCreate
{
    partial class TestCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCreateForm));
            this.upperBorder = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.questionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.completeButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addQuestuion = new System.Windows.Forms.Button();
            this.testTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mark_threeNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.mark_fourNumber = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.mark_fiveNumber = new System.Windows.Forms.NumericUpDown();
            this.upperBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark_threeNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark_fourNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark_fiveNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // upperBorder
            // 
            this.upperBorder.Controls.Add(this.CloseButton);
            this.upperBorder.Controls.Add(this.label1);
            this.upperBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperBorder.Location = new System.Drawing.Point(0, 0);
            this.upperBorder.Name = "upperBorder";
            this.upperBorder.Size = new System.Drawing.Size(795, 34);
            this.upperBorder.TabIndex = 5;
            this.upperBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperBorder_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(761, 0);
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
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание теста";
            // 
            // questionPanel
            // 
            this.questionPanel.AutoScroll = true;
            this.questionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.questionPanel.Location = new System.Drawing.Point(186, 67);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(609, 476);
            this.questionPanel.TabIndex = 6;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.treeView.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeView.Location = new System.Drawing.Point(4, 67);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(176, 476);
            this.treeView.TabIndex = 17;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // completeButton
            // 
            this.completeButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_checked_100px;
            this.completeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.completeButton.FlatAppearance.BorderSize = 0;
            this.completeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeButton.Location = new System.Drawing.Point(186, 34);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(30, 30);
            this.completeButton.TabIndex = 20;
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackgroundImage = global::UisApp.Properties.Resources.icons8_cancel_100px;
            this.removeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(33, 34);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(30, 30);
            this.removeButton.TabIndex = 19;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addQuestuion
            // 
            this.addQuestuion.BackgroundImage = global::UisApp.Properties.Resources.icons8_add_100px;
            this.addQuestuion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addQuestuion.FlatAppearance.BorderSize = 0;
            this.addQuestuion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addQuestuion.Location = new System.Drawing.Point(6, 34);
            this.addQuestuion.Name = "addQuestuion";
            this.addQuestuion.Size = new System.Drawing.Size(30, 30);
            this.addQuestuion.TabIndex = 18;
            this.addQuestuion.UseVisualStyleBackColor = true;
            this.addQuestuion.Click += new System.EventHandler(this.AddQuestuion_Click);
            // 
            // testTime
            // 
            this.testTime.Location = new System.Drawing.Point(693, 40);
            this.testTime.Name = "testTime";
            this.testTime.Size = new System.Drawing.Size(90, 20);
            this.testTime.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(564, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Время на тест:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(228, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "На 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mark_threeNumber
            // 
            this.mark_threeNumber.Location = new System.Drawing.Point(277, 39);
            this.mark_threeNumber.Name = "mark_threeNumber";
            this.mark_threeNumber.Size = new System.Drawing.Size(44, 20);
            this.mark_threeNumber.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(327, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "На 4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mark_fourNumber
            // 
            this.mark_fourNumber.Location = new System.Drawing.Point(376, 39);
            this.mark_fourNumber.Name = "mark_fourNumber";
            this.mark_fourNumber.Size = new System.Drawing.Size(44, 20);
            this.mark_fourNumber.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(426, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "На 5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mark_fiveNumber
            // 
            this.mark_fiveNumber.Location = new System.Drawing.Point(475, 40);
            this.mark_fiveNumber.Name = "mark_fiveNumber";
            this.mark_fiveNumber.Size = new System.Drawing.Size(44, 20);
            this.mark_fiveNumber.TabIndex = 27;
            // 
            // TestCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(795, 549);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mark_fiveNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mark_fourNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mark_threeNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testTime);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addQuestuion);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.questionPanel);
            this.Controls.Add(this.upperBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestCreateForm";
            this.Text = "TestCreateForm";
            this.upperBorder.ResumeLayout(false);
            this.upperBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark_threeNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark_fourNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark_fiveNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel upperBorder;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel questionPanel;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button addQuestuion;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.NumericUpDown testTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown mark_threeNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown mark_fourNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown mark_fiveNumber;
    }
}