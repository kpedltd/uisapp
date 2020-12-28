using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Helpers;

namespace UisApp.Models
{
    class StudentMetricsModel
    {
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime date
        {
            get;
            set;
        }

        public int studentId
        {
            get;
            set;
        }
    }
}
