using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.Attendance.Interfaces;
using UisApp.Models;
using UisApp.MVP.Support;

namespace UisApp.Components.Attendance
{
    class AttendancePresenter : PresenterBase<IAttendancePresenter, IAttendanceView>, IAttendancePresenter
    {
        IAttendanceModel Model;

        public AttendancePresenter(IAttendanceModel model)
        {
            Model = model;

            Model.StudentsUpdated += Model_StudentsUpdated;
        }

        protected override IAttendancePresenter GetPresenterEndpoint()
        {
            return this;
        }

        protected override void RefreshView(IAttendanceView viewInstance)
        {
            if (viewInstance == null)
            {
                throw new ArgumentNullException(nameof(viewInstance));
            }

            viewInstance.Update(Model);
        }

        private void Model_StudentsUpdated(object sender, EventArgs e)
        {
            Model = sender as IAttendanceModel;
            lock (views)
            {
                views
                .ToList()
                .ForEach((x) =>
                {
                    x.Update(Model);
                });
            }
        }

        /// <summary>
        /// Установить предмет
        /// </summary>
        /// <param name="model"></param>
        public void SetSubject(SubjectExtModel model)
        {
            Model.SetSubject(model);
        }

        /// <summary>
        /// Установить группу
        /// </summary>
        /// <param name="model"></param>
        public void SetGroup(GroupExtModel model)
        {
            Model.SetGroup(model);
        }

        /// <summary>
        /// Установить запись расписания
        /// </summary>
        /// <param name="schedule"></param>
        public void SetScheduleEntry(ScheduleExtModel schedule)
        {
            Model.SetScheduleEntry(schedule);
        }

        /// <summary>
        /// Установить дату
        /// </summary>
        /// <param name="date"></param>
        public void SetDate(DateTime date)
        {
            Model.SetDate(date);
        }

        /// <summary>
        /// Установить студентов
        /// </summary>
        /// <param name="students"></param>
        public void SetStudents(IList<StudentAttendanceModel> students)
        {
            Model.SetStudents(students);
        }

        /// <summary>
        /// Изменинить состояние посещения для студента
        /// </summary>
        /// <param name="student"></param>
        public void ChangeStudentState(StudentAttendanceModel student)
        {
            Model.ChangeStudentState(student);
        }
    }
}
