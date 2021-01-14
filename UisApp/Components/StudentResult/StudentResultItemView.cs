using System;
using System.Windows.Forms;
using UisApp.Components.Attendance;

namespace UisApp.Components.StudentResult
{
    public partial class StudentResultItemView : UserControl
    {
        private bool NoiseStart;

        public StudentResultItemView()
        {
            InitializeComponent();

            NoiseStart = true;
        }

        public event EventHandler StateChanged;

        public void SetStudentRating(StudentResultModel model)
        {
            //studentName.Text = $"{model.Student.LastName} {model.Student.FirstName} {model.Student.Patronymic}";
            //if(model.Grade != 0)
            //{
            //    gradeSelector.Text = model.Grade.ToString();
            //}
            //else
            //{
            //    NoiseStart = false;
            //}
        }

        public void SetGrade(int grade)
        {
            //gradeSelector.Text = grade.ToString();
        }


        private void gradeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(NoiseStart)
            {
                NoiseStart = false;
                return;
            }

            CheckBox checkBox = sender as CheckBox;
            StudentResultModel model = this.Tag as StudentResultModel;

            //model.Grade = Int32.Parse(gradeSelector.Text);

            StateChanged?.Invoke(model, EventArgs.Empty);
        }
    }
}
