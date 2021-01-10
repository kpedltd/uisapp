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
        /// Студент
        /// </summary>
        [JsonProperty("studentId")]
        int StudentId
        {
            get;
            set;
        }

        /// <summary>
        /// Задание
        /// </summary>
        [JsonProperty("taskId")]
        int TaskId
        {
            get;
            set;
        }
    }
}