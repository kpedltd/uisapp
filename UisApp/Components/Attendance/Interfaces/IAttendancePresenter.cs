using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models;
using UisApp.MVP.Core;

namespace UisApp.Components.Attendance.Interfaces
{
    public interface IAttendancePresenter : IPresenter<IAttendancePresenter, IAttendanceView>
    {

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
    }
}
