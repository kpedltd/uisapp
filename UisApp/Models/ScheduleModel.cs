using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Helpers;

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

    class ScheduleModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ScheduleDayOfWeek dayOfWeek
        {
            get;
            set;
        }

        [JsonConverter(typeof(CustomTimeConverter))]
        public DateTime time
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }

        public int year
        {
            get;
            set;
        }

        [JsonConverter(typeof(CustomDateConverter))]
        public ScheduleSemester semester
        {
            get;
            set;
        }

        public int subjectId
        {
            get;
            set;
        }

        public int  groupId
        {
            get;
            set;
        }
    }
}
