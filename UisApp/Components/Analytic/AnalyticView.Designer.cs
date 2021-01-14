namespace UisApp.Components.Analytic
{
    partial class AnalyticView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ratingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.attendanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.attendanceChart);
            this.panel2.Controls.Add(this.ratingChart);
            this.panel2.Location = new System.Drawing.Point(5, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 421);
            this.panel2.TabIndex = 3;
            // 
            // ratingChart
            // 
            this.ratingChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ratingChart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.ratingChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.ratingChart.BorderlineWidth = 2;
            this.ratingChart.BorderSkin.BackColor = System.Drawing.Color.White;
            this.ratingChart.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.ratingChart.BorderSkin.BorderWidth = 2;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.White;
            this.ratingChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            legend2.ForeColor = System.Drawing.SystemColors.HighlightText;
            legend2.HeaderSeparatorColor = System.Drawing.Color.White;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.ratingChart.Legends.Add(legend2);
            this.ratingChart.Location = new System.Drawing.Point(7, 52);
            this.ratingChart.Name = "ratingChart";
            this.ratingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.EmptyPointStyle.BackImageTransparentColor = System.Drawing.Color.White;
            series2.EmptyPointStyle.BackSecondaryColor = System.Drawing.Color.White;
            series2.EmptyPointStyle.BorderColor = System.Drawing.Color.White;
            series2.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series2.LabelForeColor = System.Drawing.SystemColors.HighlightText;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.MarkerColor = System.Drawing.Color.White;
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ShadowColor = System.Drawing.Color.White;
            series2.YValuesPerPoint = 2;
            this.ratingChart.Series.Add(series2);
            this.ratingChart.Size = new System.Drawing.Size(358, 300);
            this.ratingChart.TabIndex = 3;
            this.ratingChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.subjectComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupComboBox);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 60);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Учебный предмет";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(12, 31);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(177, 21);
            this.subjectComboBox.TabIndex = 7;
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.SubjectComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(197, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Группа";
            // 
            // groupComboBox
            // 
            this.groupComboBox.Enabled = false;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(201, 31);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(177, 21);
            this.groupComboBox.TabIndex = 0;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox_SelectedIndexChanged);
            // 
            // attendanceChart
            // 
            this.attendanceChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.attendanceChart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.attendanceChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.attendanceChart.BorderlineWidth = 2;
            this.attendanceChart.BorderSkin.BackColor = System.Drawing.Color.White;
            this.attendanceChart.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.attendanceChart.BorderSkin.BorderWidth = 2;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.attendanceChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            legend1.ForeColor = System.Drawing.SystemColors.HighlightText;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.attendanceChart.Legends.Add(legend1);
            this.attendanceChart.Location = new System.Drawing.Point(371, 52);
            this.attendanceChart.Name = "attendanceChart";
            this.attendanceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.EmptyPointStyle.BackImageTransparentColor = System.Drawing.Color.White;
            series1.EmptyPointStyle.BackSecondaryColor = System.Drawing.Color.White;
            series1.EmptyPointStyle.BorderColor = System.Drawing.Color.White;
            series1.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.SystemColors.HighlightText;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ShadowColor = System.Drawing.Color.White;
            series1.YValuesPerPoint = 2;
            this.attendanceChart.Series.Add(series1);
            this.attendanceChart.Size = new System.Drawing.Size(358, 300);
            this.attendanceChart.TabIndex = 4;
            this.attendanceChart.Text = "attendanceChart";
            // 
            // AnalyticView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AnalyticView";
            this.Size = new System.Drawing.Size(762, 494);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ratingChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ratingChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart attendanceChart;
    }
}
