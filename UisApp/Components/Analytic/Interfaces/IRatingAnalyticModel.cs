using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.Components.Analytic.Interfaces
{
    interface IRatingAnalyticModel
    {
        /// <summary>
        /// Оценка
        /// </summary>
        [JsonProperty("grade")]
        int Grade
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
