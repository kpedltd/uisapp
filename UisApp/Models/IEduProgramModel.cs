using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UisApp.MVP;

namespace UisApp.Models
{
    internal enum EduProgramType
    {
        /// <summary>
        /// Очная
        /// </summary>
        fulltime,

        /// <summary>
        /// Заочная
        /// </summary>
        parttime
    }

    internal interface IEduProgramModel : IModel
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
        /// Код программы
        /// </summary>
        [JsonProperty("code")]
        string Code
        {
            get;
            set;
        }

        /// <summary>
        /// Тип обучения
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        EduProgramType Type
        {
            get;
            set;
        }
    }
}