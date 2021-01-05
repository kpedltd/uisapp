using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP;

namespace UisApp.Models
{
    interface IFacultyModel : IModel
    {
        /// <summary>
        /// Название факультетаы
        /// </summary>
        [JsonProperty("name")]
        string Names
        {
            get;
            set;
        }
    }
}
