using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using UisApp.API.Providers;
using UisApp.Components.Profile.Interfaces;
using UisApp.Helpers;
using UisApp.Models;

namespace UisApp.Components.Analytic
{
    public partial class AnalyticView : UserControl, IUisComponent
    {
        /// <summary>
        /// Модель
        /// </summary>
        AnalyticModel Model;

        /// <summary>
        /// Предметы
        /// </summary>
        private IList<SubjectExtModel> Subjects;

        /// <summary>
        /// Группы
        /// </summary>
        private IList<GroupExtModel> Groups;


        public AnalyticView()
        {
            InitializeComponent();
            GetSubjects();
        }

        /// <summary>
        /// Получить предметы
        /// </summary>
        private void GetSubjects()
        {
            Subjects = LecturerProvider.GetSubjects();
            for (int i = 0; i < Subjects.Count; i++)
            {
                subjectComboBox.Items.Add(Subjects[i].Name);
            }

            if (Subjects.Count > 0)
            {
                subjectComboBox.SelectedIndex = 0;
            }
        }

        private void SubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            groupComboBox.Items.Clear();
            ratingChart.Series[0].Points.Clear();
            attendanceChart.Series[0].Points.Clear();

            Groups = SubjectProvider.GetGroups(Subjects[comboBox.SelectedIndex].Id);
            for (int i = 0; i < Groups.Count; i++)
            {
                groupComboBox.Items.Add(Groups[i].Name);
            }

            if (Groups.Count > 0)
            {
                groupComboBox.Enabled = true;

                groupComboBox.SelectedIndex = 0;
            }
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            ratingChart.Series[0].Points.Clear();
            attendanceChart.Series[0].Points.Clear();

            Model = AnalyticProvider.Get(
                Subjects[subjectComboBox.SelectedIndex].Id,
                Groups[comboBox.SelectedIndex].Id);

            FillRating();
            FillAttendance();
        }

        private void FillRating()
        {
            for(int i = 0;i < Model.Rating.Count;i++)
            {
                ratingChart.Series[0].Points.AddY(Model.Rating[i].Count);
                if(Model.Rating[i].Grade == 0)
                {
                    ratingChart.Series[0].Points[i].LegendText = "Задолженность";
                }
                else
                {
                    ratingChart.Series[0].Points[i].LegendText = Model.Rating[i].Grade.ToString();
                }
            }
        }

        private void FillAttendance()
        {
            for (int i = 0; i < Model.Attendance.Count; i++)
            {
                attendanceChart.Series[0].Points.AddY(Model.Attendance[i].Count);
                attendanceChart.Series[0].Points[i].LegendText = EnumToString.GetStringValue(Model.Attendance[i].State);
            }
        }
    }
}