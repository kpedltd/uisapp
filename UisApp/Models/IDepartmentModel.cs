using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP;

namespace UisApp.Models
{
    interface IDepartmentModel : IModel
    {
        /// <summary>
        /// Название
        /// </summary>
        [JsonProperty("name")]
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Номер факультета
        /// </summary>
        [JsonProperty("facultyId")]
        int FacultyId
        {
            get;
            set;
        }
    }
}
