using System.Windows.Forms;
using UisApp.API.Providers;
using UisApp.Components.Analytic;
using UisApp.Components.Attendance;
using UisApp.Components.Profile;
using UisApp.Components.Rating;
using UisApp.Components.ScheduleTable;
using UisApp.Components.StudentResult;
using UisApp.Components.StudyTask;

namespace UisApp
{
    public partial class MainForm : Form
    {
        private void InitializeInternalComponents()
        {
            InitializeProfile();
            InitializeScheduleTable();
            InitializeAttendanceLog();
            InitializeRatingLog();
            InitializeStudyTask();
            InitializeStudentResult();
            InitializeAnalytics();
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
            var scheduleModel = ScheduleProvider.GetLecturerSchedule();
            ScheduleTablePresenter presenter = new ScheduleTablePresenter(scheduleModel);

            var scheduleView = new ScheduleTableView();
            compContainer.AttachView(scheduleView);

            scheduleView.AttachToPresenter(presenter, true);

            scheduleButton.Tag = scheduleView;
        }

        private void InitializeAttendanceLog()
        {
            var attendanceModel = new AttendanceModel();
            AttendancePresenter presenter = new AttendancePresenter(attendanceModel);

            var attendanceView = new AttendanceView();
            compContainer.AttachView(attendanceView);

            attendanceView.AttachToPresenter(presenter, true);

            attendanceButton.Tag = attendanceView;
        }

        private void InitializeRatingLog()
        {
            var ratingLogModel = new RatingModel();
            RatingPresenter presenter = new RatingPresenter(ratingLogModel);

            var ratingView = new RatingView();
            compContainer.AttachView(ratingView);

            ratingView.AttachToPresenter(presenter, true);

            ratingButton.Tag = ratingView;
        }

        private void InitializeStudyTask()
        {
            var studyTaskModel = new StudyTaskModel();
            StudyTaskPresenter presenter = new StudyTaskPresenter(studyTaskModel);

            var studyTaskView = new StudyTaskView();
            compContainer.AttachView(studyTaskView);

            studyTaskView.AttachToPresenter(presenter, true);

            taskButton.Tag = studyTaskView;
        }

        private void InitializeStudentResult()
        {
            var resultModel = new ResultModel();
            StudentResultPresenter presenter = new StudentResultPresenter(resultModel);

            var studentResultView = new StudentResultView();
            compContainer.AttachView(studentResultView);

            studentResultView.AttachToPresenter(presenter, true);

            checkButton.Tag = studentResultView;
        }

        private void InitializeAnalytics()
        {
            var analyticView = new AnalyticView();
            compContainer.AttachView(analyticView);

            analyticButton.Tag = analyticView;
        }
    }
}