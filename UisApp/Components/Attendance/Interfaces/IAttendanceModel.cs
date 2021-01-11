using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models;

namespace UisApp.Components.Attendance.Interfaces
{
    public interface IAttendanceModel
    {
        /// <summary>
        /// Предмет
        /// </summary>
        SubjectExtModel Subject
        {
            get;
        }

        /// <summary>
        /// Группа
        /// </summary>
        GroupExtModel Group
        {
            get;
        }

        /// <summary>
        /// Запись расписания
        /// </summary>
        ScheduleExtModel Schedule
        {
            get;
        }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime Date
        {
            get;
        }

        /// <summary>
        /// Студенты
        /// </summary>
        IList<StudentAttendanceModel> Students
        {
            get;
        }

        /// <summary>
        /// Установить предмет
        /// </summary>
        /// <param name="model"></param>
        void SetSubject(SubjectExtModel model);

        /// <summary>
        /// Установить группу
        /// </summary>
        /// <param name="model"></param>
        void SetGroup(GroupExtModel model);

        /// <summary>
        /// Установить запись расписания
        /// </summary>
        /// <param name="schedule"></param>
        void SetScheduleEntry(ScheduleExtModel schedule);

        /// <summary>
        /// Установить дату
        /// </summary>
        /// <param name="date"></param>
        void SetDate(DateTime date);

        /// <summary>
        /// Установить студентов
        /// </summary>
        /// <param name="students"></param>
        void SetStudents(IList<StudentAttendanceModel> students);

        /// <summary>
        /// Изменинить состояние посещения для студента
        /// </summary>
        /// <param name="student"></param>
        void ChangeStudentState(StudentAttendanceModel student);

        /// <summary>
        /// Событие обновления студентов
        /// </summary>
        event EventHandler StudentsUpdated;
    }
}
