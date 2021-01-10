using Newtonsoft.Json;
using UisApp.MVP;

namespace UisApp.Models
{
    internal interface IFacultyModel : IModel
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