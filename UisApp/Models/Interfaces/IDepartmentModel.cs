using Newtonsoft.Json;
using UisApp.MVP;

namespace UisApp.Models
{
    internal interface IDepartmentModel : IModel
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