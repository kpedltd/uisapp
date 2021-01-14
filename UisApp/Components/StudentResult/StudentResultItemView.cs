using System;
using System.Windows.Forms;
using UisApp.API.Providers;
using UisApp.Components.Attendance;
using UisApp.Forms.ImageViewer;
using UisApp.Forms.StudentGradeForm;

namespace UisApp.Components.StudentResult
{
    public partial class StudentResultItemView : UserControl
    {
        public StudentResultItemView()
        {
            InitializeComponent();
        }

        public event EventHandler StateChanged;

        public void SetStudentResult(StudentResultModel model)
        {
            studentName.Text = $"{model.Student.LastName} {model.Student.FirstName} {model.Student.Patronymic}";
            taskNameLabel.Text = model.Task.Title;

            if(model.File == null)
            {
                imageButton.Visible = false;
            }
        }

        public void SetGrade(int grade)
        {
            //gradeSelector.Text = grade.ToString();
        }


        private void gradeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            StudentResultModel model = this.Tag as StudentResultModel;

            StateChanged?.Invoke(model, EventArgs.Empty);
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            var task = this.Tag as StudentResultModel;

            ImageViewer viewer = new ImageViewer();
            viewer.SetUrl(task.File);

            viewer.Show();
        }

        private void ResultInfoButton_Click(object sender, EventArgs e)
        {
            StudentGradeForm form = new StudentGradeForm();
            form.SetModel(this.Tag as StudentResultModel);
            form.StudentGraded += Form_StudentGraded;

            form.Show();
        }

        private void Form_StudentGraded(object sender, EventArgs e)
        {
            StudentResultModel model = sender as StudentResultModel;
            TaskResultProvider.GradeStudent(
                model.Student.Id,
                model.Task.Id,
                model.Grade);

            this.Parent.Controls.Remove(this);
        }
    }
}
