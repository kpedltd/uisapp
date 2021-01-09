using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using UisApp.Models;

namespace UisApp.Components.ScheduleTable.Interfaces
{
    public interface IScheduleDayModel
    {
        /// <summary>
        /// День недели
        /// </summary>
        [JsonProperty("day")]
        [JsonConverter(typeof(StringEnumConverter))]
        ScheduleDayOfWeek DayOfWeek
        {
            get;
            set;
        }

        /// <summary>
        /// Список записей
        /// </summary>
        [JsonProperty("subjects")]
        IList<ScheduleRecordModel> Records
        {
            get;
            set;
        }
    }
}