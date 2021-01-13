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
            this.addQuestuion = new System.Windows.Forms.Button();
            this.upperBorder.SuspendLayout();
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
            this.questionPanel.Location = new System.Drawing.Point(182, 32);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(609, 476);
            this.questionPanel.TabIndex = 6;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.treeView.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeView.Location = new System.Drawing.Point(0, 32);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(176, 476);
            this.treeView.TabIndex = 17;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // addQuestuion
            // 
            this.addQuestuion.BackgroundImage = global::UisApp.Properties.Resources.icons8_add_50px1;
            this.addQuestuion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addQuestuion.FlatAppearance.BorderSize = 0;
            this.addQuestuion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addQuestuion.Location = new System.Drawing.Point(11, 514);
            this.addQuestuion.Name = "addQuestuion";
            this.addQuestuion.Size = new System.Drawing.Size(50, 50);
            this.addQuestuion.TabIndex = 18;
            this.addQuestuion.UseVisualStyleBackColor = true;
            this.addQuestuion.Click += new System.EventHandler(this.AddQuestuion_Click);
            // 
            // TestCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(795, 570);
            this.Controls.Add(this.addQuestuion);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.questionPanel);
            this.Controls.Add(this.upperBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestCreateForm";
            this.Text = "TestCreateForm";
            this.upperBorder.ResumeLayout(false);
            this.upperBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upperBorder;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel questionPanel;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button addQuestuion;
    }
}