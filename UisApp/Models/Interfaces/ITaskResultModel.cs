using Newtonsoft.Json;
using UisApp.MVP;

namespace UisApp.Models
{
    internal interface ITaskResultModel : IModel
    {
        /// <summary>
        /// Ссылка на файл с ответом на задание
        /// </summary>
        [JsonProperty("file")]
        string File
        {
            get;
            set;
        }

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
        /// Комментарий преподавателя
        /// </summary>
        [JsonProperty("comment")]
        string Comment
        {
            get;
            set;
        }
    }
}