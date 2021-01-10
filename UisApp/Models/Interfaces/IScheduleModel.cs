using Newtonsoft.Json;
using System;
using UisApp.Helpers;
using UisApp.MVP;

namespace UisApp.Models
{
    public enum ScheduleDayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Count
    }

    public enum ScheduleSemester
    {
        spring,
        autumn
    }

    public interface IScheduleModel : IModel
    {
        /// <summary>
        /// Время
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(CustomTimeConverter))]
        DateTime Time
        {
            get;
            set;
        }

        /// <summary>
        /// Место проведения
        /// </summary>
        [JsonProperty("location")]
        string Location
        {
            get;
            set;
        }

        /// <summary>
        /// Предмет
        /// </summary>
        [JsonProperty("subjectName")]
        string SubjectName
        {
            get;
            set;
        }

        /// <summary>
        /// Имя группы
        /// </summary>
        [JsonProperty("groupName")]
        string GroupName
        {
            get;
            set;
        }
    }
}