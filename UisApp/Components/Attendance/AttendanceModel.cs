using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            set;
        }

        /// <summary>
        /// Группа
        /// </summary>
        public GroupExtModel Group
        {
            get;
            set;
        }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// Студенты
        /// </summary>
        public IList<StudentAttendanceModel> Students
        {
            get;
            set;
        }
    }
}
