using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Providers;
using UisApp.Components.Attendance.Interfaces;
using UisApp.Models;

namespace UisApp.Components.Attendance
{
    public class AttendanceModel : IAttendanceModel
    {
        /// <summary>
        /// Предмет
        /// </summary>
        public SubjectExtModel Subject
        {
            get;
            private set;
        }

        /// <summary>
        /// Группа
        /// </summary>
        public GroupExtModel Group
        {
            get;
            private set;
        }

        /// <summary>
        /// Запись расписания
        /// </summary>
        public ScheduleExtModel Schedule
        {
            get;
            private set;
        }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date
        {
            get;
            private set;
        }

        /// <summary>
        /// Студенты
        /// </summary>
        public IList<StudentAttendanceModel> Students
        {
            get;
            private set;
        }


        /// <summary>
        /// Событие обновления студентов
        /// </summary>
        public event EventHandler StudentsUpdated;

        /// <summary>
        /// Установить предмет
        /// </summary>
        /// <param name="model"></param>
        public void SetSubject(SubjectExtModel model)
        {
            Subject = model;
        }

        /// <summary>
        /// Установить группу
        /// </summary>
        /// <param name="model"></param>
        public void SetGroup(GroupExtModel model)
        {
            Group = model;
        }

        /// <summary>
        /// Установить запись расписания
        /// </summary>
        /// <param name="schedule"></param>
        public void SetScheduleEntry(ScheduleExtModel schedule)
        {
            Schedule = schedule;
        }

        /// <summary>
        /// Установить студентов
        /// </summary>
        /// <param name="students"></param>
        public void SetStudents(IList<StudentAttendanceModel> students)
        {
            Students = students;
            if(students.Count == 0)
            {
                Students = AttendanceProvider.CreateEntries(Group.Id, Schedule.Id, Date);
            }

            StudentsUpdated?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Установить дату
        /// </summary>
        /// <param name="date"></param>
        public void SetDate(DateTime date)
        {
            Date = date;
        }

        /// <summary>
        /// Изменинить состояние посещения для студента
        /// </summary>
        /// <param name="student"></param>
        public void ChangeStudentState(StudentAttendanceModel student)
        {
            AttendanceProvider.ChangeState(
                student.Student.Id,
                Schedule.Id,
                Date,
                student.State);
        }
    }
}
