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
    class ScheduleExtModel : IModel
    {
        /// <summary>
        /// ИД
        /// </summary>
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Время
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(CustomTimeConverter))]
        public DateTime Time
        {
            get;
            set;
        }
    }
}
