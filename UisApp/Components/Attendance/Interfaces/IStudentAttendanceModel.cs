using Newtonsoft.Json;
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
        [JsonProperty("student")]
        StudentExtModel Student
        {
            get;
            set;
        }

        /// <summary>
        /// Состояние
        /// </summary>
        [JsonProperty("state")]
        AttendanceLogState State
        {
            get;
            set;
        }
    }
}
