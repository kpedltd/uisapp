using Newtonsoft.Json;
using UisApp.MVP;

namespace UisApp.Models
{
    internal interface IRatingLogModel : IModel
    {
        /// <summary>
        /// ИД студента
        /// </summary>
        [JsonProperty("studentId")]
        int StudentId
        {
            get;
            set;
        }

        /// <summary>
        /// Ид предмета
        /// </summary>
        [JsonProperty("subjectId")]
        int SubjectId
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
    }
}