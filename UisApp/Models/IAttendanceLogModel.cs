using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Helpers;
using UisApp.MVP;

namespace UisApp.Models
{
    enum AttendanceLogState
    {
        /// <summary>
        /// Посещено
        /// </summary>
        visited,

        /// <summary>
        /// Пропущено
        /// </summary>
        skiped
    }

    interface IAttendanceLogModel : IModel
    {
        /// <summary>
        /// Состояние (Посещено/Пропущено)
        /// </summary>
        [JsonProperty("state")]
        [JsonConverter(typeof(StringEnumConverter))]
        AttendanceLogState State
        {
            get;
            set;
        }

        /// <summary>
        /// Дата предмета
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(CustomDateConverter))]
        DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// Номер записи в расписании
        /// </summary>
        [JsonProperty("scheduleId")]
        int ScheduleId
        {
            get;
            set;
        }

        /// <summary>
        /// Номер студента
        /// </summary>
        [JsonProperty("studentId")]
        int StudentId
        {
            get;
            set;
        }
    }
}
