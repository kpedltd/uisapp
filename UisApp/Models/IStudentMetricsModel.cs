using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Helpers;
using UisApp.MVP;

namespace UisApp.Models
{
    interface IStudentMetricsModel : IModel
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
