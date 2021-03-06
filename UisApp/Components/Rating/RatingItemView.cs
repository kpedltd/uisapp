﻿using System;
using System.Windows.Forms;
using UisApp.Components.Attendance;

namespace UisApp.Components.Rating
{
    public partial class RatingItemView : UserControl
    {
        private bool NoiseStart;

        public RatingItemView()
        {
            InitializeComponent();

            NoiseStart = true;
        }

        public event EventHandler StateChanged;

        public void SetStudentRating(StudentRatingModel model)
        {
            studentName.Text = $"{model.Student.LastName} {model.Student.FirstName} {model.Student.Patronymic}";
            if(model.Grade != 0)
            {
                gradeSelector.Text = model.Grade.ToString();
            }
            else
            {
                NoiseStart = false;
            }
        }

        public void SetGrade(int grade)
        {
            gradeSelector.Text = grade.ToString();
        }


        private void gradeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(NoiseStart)
            {
                NoiseStart = false;
                return;
            }

            CheckBox checkBox = sender as CheckBox;
            StudentRatingModel model = this.Tag as StudentRatingModel;

            model.Grade = Int32.Parse(gradeSelector.Text);

            StateChanged?.Invoke(model, EventArgs.Empty);
        }
    }
}
