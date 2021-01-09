using Newtonsoft.Json;
using UisApp.MVP;

namespace UisApp.Models
{
    internal interface IGroupModel : IModel
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