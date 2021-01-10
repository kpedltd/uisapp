﻿using System.Windows.Forms;
using UisApp.API.Providers;
using UisApp.Components.Attendance;
using UisApp.Components.Profile;
using UisApp.Components.ScheduleTable;

namespace UisApp
{
    public partial class MainForm : Form
    {
        private void InitializeInternalComponents()
        {
            InitializeProfile();
            InitializeScheduleTable();
            InitializeAttendanceLog();
        }

        private void InitializeProfile()
        {
            var profileModel = LecturerProvider.GetMe();
            ProfilePresenter presenter = new ProfilePresenter(profileModel);

            var profileView = new ProfileView();
            compContainer.AttachView(profileView);

            profileView.AttachToPresenter(presenter, true);

            profileButton.Tag = profileView;
        }

        private void InitializeScheduleTable()
        {
            var scheduleModel = ScheduleTableProvider.GetLecturerSchedule();
            ScheduleTablePresenter presenter = new ScheduleTablePresenter(scheduleModel);

            var scheduleView = new ScheduleTableView();
            compContainer.AttachView(scheduleView);

            scheduleView.AttachToPresenter(presenter, true);

            scheduleButton.Tag = scheduleView;
        }

        private void InitializeAttendanceLog()
        {
            //var scheduleModel = ScheduleTableProvider.GetLecturerSchedule();
            //ScheduleTablePresenter presenter = new ScheduleTablePresenter(scheduleModel);

            var attendanceView = new AttendanceView();
            compContainer.AttachView(attendanceView);

            //scheduleView.AttachToPresenter(presenter, true);

            attendanceButton.Tag = attendanceView;
        }
    }
}