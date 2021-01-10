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
            set;
        }

        /// <summary>
        /// Группа
        /// </summary>
        GroupExtModel Group
        {
            get;
            set;
        }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// Студенты
        /// </summary>
        IList<StudentAttendanceModel> Students
        {
            get;
            set;
        }


    }
}
