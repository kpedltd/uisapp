using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models;

namespace UisApp.Components.Analytic.Interfaces
{
    interface IAttendanceAnalyticModel
    {
        /// <summary>
        /// Состояние
        /// </summary>
        [JsonProperty("state")]
        AttendanceLogState State
        {
            get;
            set;
        }

        /// <summary>
        /// Количество
        /// </summary>
        [JsonProperty("count")]
        int Count
        {
            get;
            set;
        }
    }
}
