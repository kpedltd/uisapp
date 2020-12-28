using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Helpers;
using UisApp.Models.Interfaces;

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

    class AttendanceLogModel : IModel
    {
        /// <summary>
        /// Состояние (Посещено/Пропущено)
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AttendanceLogState state
        {
            get;
            set;
        }

        /// <summary>
        /// Дата предмета
        /// </summary>
        [JsonConverter(typeof(CustomDateConverter))]
        public DateTime date
        {
            get;
            set;
        }

        /// <summary>
        /// Номер записи в расписании
        /// </summary>
        public int scheduleId
        {
            get;
            set;
        }

        /// <summary>
        /// Номер студента
        /// </summary>
        public int studentId
        {
            get;
            set;
        }
        

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
