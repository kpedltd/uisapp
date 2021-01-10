using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UisApp.Components.Attendance.Interfaces;
using UisApp.API.Providers;
using UisApp.Models;

namespace UisApp.Components.Attendance
{
    public partial class AttendanceView : UserControl, IUisComponent, IAttendanceView
    {
        /// <summary>
        /// Предметы
        /// </summary>
        private IList<SubjectExtModel> Subjects;

        /// <summary>
        /// Группы
        /// </summary>
        private IList<GroupExtModel> Groups;

        /// <summary>
        /// Время занятий
        /// </summary>
        private IList<ScheduleExtModel> ScheduleTimes;

        /// <summary>
        /// Посещаемость студентов
        /// </summary>
        public IList<StudentAttendanceModel> StudentsAttendance
        {
            get;
            set;
        }

        /// <summary>
        /// Презентер
        /// </summary>
        public IAttendancePresenter Presenter
        {
            get;
            set;
        }

        public AttendanceView()
        {
            InitializeComponent();
            GetSubjects();

        }

        /// <summary>
        /// Привязать презентер
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="requiresInitialState"></param>
        public void AttachToPresenter(IAttendancePresenter presenter, bool requiresInitialState)
        {
            if (presenter == null)
            {
                throw new ArgumentNullException(nameof(presenter));
            }

            DetatchFromPresenter();

            Presenter = presenter;
            Presenter.ConnectView(this, requiresInitialState);
        }

        /// <summary>
        /// Отвязать презентер
        /// </summary>
        public void DetatchFromPresenter()
        {
            lock (this)
            {
                if (Presenter != null)
                {
                    Presenter.DisconnectView(this);
                    Presenter = null;
                }
            }
        }


        public void Update(IAttendanceModel model)
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        /// Получить предметы
        /// </summary>
        private void GetSubjects()
        {
            Subjects = LecturerProvider.GetSubjects();
            for(int i = 0;i < Subjects.Count;i++)
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
            timeComboBox.Items.Clear();
            timeComboBox.SelectedText = "";

            Groups = SubjectProvider.GetGroups(Subjects[comboBox.SelectedIndex].Id);
            for (int i = 0; i < Groups.Count; i++)
            {
                groupComboBox.Items.Add(Groups[i].Name);
            }

            if(Groups.Count > 0)
            {
                groupComboBox.Enabled = true;
                dateTimePicker.Enabled = false;
                timeComboBox.Enabled = false;

                groupComboBox.SelectedIndex = 0;
            }
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = true;

            timeComboBox.Items.Clear();
            timeComboBox.Enabled = false;
            timeComboBox.SelectedText = "";
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;

            if(dateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                return;
            }

            ScheduleDayOfWeek scheduleDayOfWeek = (ScheduleDayOfWeek)((int)(dateTimePicker.Value.DayOfWeek) - 1);

            ScheduleTimes = ScheduleProvider.GetScheduleEntry(
                Groups[groupComboBox.SelectedIndex].Id,
                Subjects[subjectComboBox.SelectedIndex].Id,
                scheduleDayOfWeek);

            for (int i = 0; i < ScheduleTimes.Count; i++)
            {
                timeComboBox.Items.Add(ScheduleTimes[i].Time.ToString("HH;mm"));
            }

            if (ScheduleTimes.Count > 0)
            {
                timeComboBox.SelectedIndex = 0;

                timeComboBox.Enabled = true;
            }
        }

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillStudentAttendance();
        }

        private void FillStudentAttendance()
        {

        }
    }
}