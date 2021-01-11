using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UisApp.Components.Attendance
{
    public partial class AttendanceItemView : UserControl
    {
        public AttendanceItemView()
        {
            InitializeComponent();
        }

        public event EventHandler StateChanged;

        public void SetStudentAttendance(StudentAttendanceModel model)
        {
            studentName.Text = $"{model.Student.LastName} {model.Student.FirstName} {model.Student.Patronymic}";
            visitBox.Checked = model.State == Models.AttendanceLogState.visited;
        }

        public void SetState(Models.AttendanceLogState state)
        {
            visitBox.Checked = state == Models.AttendanceLogState.visited;
        }

        private void VisitBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            StudentAttendanceModel model = this.Tag as StudentAttendanceModel;

            model.State = checkBox.Checked ? Models.AttendanceLogState.visited : Models.AttendanceLogState.skiped;

            StateChanged?.Invoke(model, EventArgs.Empty);
        }
    }
}
