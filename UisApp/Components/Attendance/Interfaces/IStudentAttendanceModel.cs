using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models;
using UisApp.MVP;

namespace UisApp.Components.Attendance.Interfaces
{
    public interface IStudentAttendanceModel : IModel
    {
        /// <summary>
        /// Студент
        /// </summary>
        StudentExtModel Student
        {
            get;
            set;
        }

        /// <summary>
        /// Состояние
        /// </summary>
        AttendanceLogState State
        {
            get;
            set;
        }
    }
}
