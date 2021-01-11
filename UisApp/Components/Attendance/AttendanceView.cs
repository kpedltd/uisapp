using System;
using System.Collections.Generic;
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

            GetSubjects();
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

        /// <summary>
        /// Обновить
        /// </summary>
        /// <param name="model"></param>
        public void Update(IAttendanceModel model)
        {
            if(model.Date == dateTimePicker.Value.Date &&
                model.Schedule.Id == ScheduleTimes[timeComboBox.SelectedIndex].Id)
            {
                StudentsAttendance = model.Students;

                DisposeAttendancePanel();
                FillAttendance();
            }
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
                Presenter.SetSubject(Subjects[subjectComboBox.SelectedIndex]);
            }
        }

        private void SubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            DisposeAttendancePanel();

            groupComboBox.Items.Clear();
            timeComboBox.Items.Clear();
            timeComboBox.Text = "";

            Presenter.SetSubject(Subjects[comboBox.SelectedIndex]);

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
                Presenter.SetGroup(Groups[groupComboBox.SelectedIndex]);
            }
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            dateTimePicker.Enabled = true;

            DisposeAttendancePanel();

            timeComboBox.Items.Clear();
            timeComboBox.Enabled = false;
            timeComboBox.Text = "";

            Presenter.SetGroup(Groups[comboBox.SelectedIndex]);
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;

            if(dateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                return;
            }

            ScheduleDayOfWeek scheduleDayOfWeek = (ScheduleDayOfWeek)((int)(dateTimePicker.Value.DayOfWeek) - 1);

            Presenter.SetDate(dateTimePicker.Value.Date);

            ScheduleTimes = ScheduleProvider.GetScheduleEntry(
                Groups[groupComboBox.SelectedIndex].Id,
                Subjects[subjectComboBox.SelectedIndex].Id,
                scheduleDayOfWeek);

            timeComboBox.Enabled = false;
            timeComboBox.Items.Clear();
            timeComboBox.Text = "";
            for (int i = 0; i < ScheduleTimes.Count; i++)
            {
                timeComboBox.Items.Add(ScheduleTimes[i].Time.ToString("HH;mm"));
            }

            DisposeAttendancePanel();

            if (ScheduleTimes.Count > 0)
            {
                timeComboBox.Enabled = true;

                timeComboBox.SelectedIndex = 0;
                Presenter.SetScheduleEntry(ScheduleTimes[timeComboBox.SelectedIndex]);
            }
        }

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            Presenter.SetScheduleEntry(ScheduleTimes[comboBox.SelectedIndex]);

            StudentsAttendance = AttendanceProvider.GetAttendance(
                ScheduleTimes[comboBox.SelectedIndex].Id,
                dateTimePicker.Value.Date);

            DisposeAttendancePanel();

            Presenter.SetStudents(StudentsAttendance);
        }

        private void FillAttendance()
        {
            for (int i = 0; i < StudentsAttendance.Count; i++)
            {
                var item = new AttendanceItemView();
                item.Tag = StudentsAttendance[i];
                item.StateChanged += Item_StateChanged;
                item.Visible = true;

                item.SetStudentAttendance(StudentsAttendance[i]);

                attendancePanel.Controls.Add(item);
            }
        }

        private void DisposeAttendancePanel()
        {
            for(int i = 0;i < attendancePanel.Controls.Count;i++)
            {
                attendancePanel.Controls[i].Dispose();
            }
            attendancePanel.Controls.Clear();
        }

        private void Item_StateChanged(object sender, EventArgs e)
        {
            Presenter.ChangeStudentState(sender as StudentAttendanceModel);
        }
    }
}