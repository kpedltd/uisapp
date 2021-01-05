using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP;

namespace UisApp.Models
{
    interface IGroupModel : IModel
    {
        /// <summary>
        /// Имя группы
        /// </summary>
        [JsonProperty("name")]
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Ид образовательной программы
        /// </summary>
        [JsonProperty("eduProgramId")]
        int EduProgramId
        {
            get;
            set;
        }
    }
}
