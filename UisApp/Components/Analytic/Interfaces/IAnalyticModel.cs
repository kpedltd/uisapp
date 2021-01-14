using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.Components.Analytic.Interfaces
{
    interface IAnalyticModel
    {
        /// <summary>
        /// Посещаемость
        /// </summary>
        [JsonProperty("attendance")]
        IList<AttendanceAnalyticModel> Attendance
        {
            get;
            set;
        }

        /// <summary>
        /// Оценки
        /// </summary>
        [JsonProperty("rating")]
        IList<RatingAnalyticModel> Rating
        {
            get;
            set;
        }
    }
}
