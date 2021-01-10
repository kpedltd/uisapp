using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.Attendance.Interfaces;
using UisApp.Models;

namespace UisApp.Components.Attendance
{
    public class StudentAttendanceModel : IStudentAttendanceModel
    {
        /// <summary>
        /// Студент
        /// </summary>
        public StudentExtModel Student
        {
            get;
            set;
        }

        /// <summary>
        /// Состояние
        /// </summary>
        public AttendanceLogState State
        {
            get;
            set;
        }
    }
}
