using Newtonsoft.Json;
using System;
using UisApp.Helpers;
using UisApp.MVP;

namespace UisApp.Models
{
    internal interface IStudentMetricsModel : IModel
    {
        [JsonProperty("date")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        DateTime Date
        {
            get;
            set;
        }

        [JsonProperty("studentId")]
        int StudentId
        {
            get;
            set;
        }
    }
}