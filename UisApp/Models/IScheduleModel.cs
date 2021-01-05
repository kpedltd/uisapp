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
    enum ScheduleDayOfWeek
    {
        Friday,
        Monday,
        Saturday,
        Sunday,
        Thursday,
        Tuesday,
        Wedndesday
    }

    enum ScheduleSemester
    {
        spring,
        autumn
    }

    interface IScheduleModel : IModel
    {
        [JsonProperty("dayOfWeek")]
        [JsonConverter(typeof(StringEnumConverter))]
        ScheduleDayOfWeek DayOfWeek
        {
            get;
            set;
        }

        [JsonProperty("time")]
        [JsonConverter(typeof(CustomTimeConverter))]
        DateTime Time
        {
            get;
            set;
        }

        [JsonProperty("location")]
        string Location
        {
            get;
            set;
        }

        [JsonProperty("year")]
        int Year
        {
            get;
            set;
        }

        [JsonProperty("semester")]
        [JsonConverter(typeof(CustomDateConverter))]
        ScheduleSemester Semester
        {
            get;
            set;
        }

        [JsonProperty("subjectId")]
        int SubjectId
        {
            get;
            set;
        }

        [JsonProperty("groupId")]
        int GroupId
        {
            get;
            set;
        }
    }
}
