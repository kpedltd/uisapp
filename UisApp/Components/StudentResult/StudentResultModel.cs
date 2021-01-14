using Newtonsoft.Json;
using UisApp.Components.StudentResult.Interfaces;
using UisApp.Models;

namespace UisApp.Components.StudentResult
{
    public class StudentResultModel : IStudentResultModel
    {
        /// <summary>
        /// Ссылка на файл с ответом на задание
        /// </summary>
        [JsonProperty("file")]
        public string File
        {
            get;
            set;
        }

        /// <summary>
        /// Оценка
        /// </summary>
        [JsonProperty("grade")]
        public int Grade
        {
            get;
            set;
        }

        /// <summary>
        /// Комментарий преподавателя
        /// </summary>
        [JsonProperty("comment")]
        public string Comment
        {
            get;
            set;
        }

        /// <summary>
        /// Задача
        /// </summary>
        [JsonProperty("task")]
        public StudentTaskModel Task
        {
            get;
            set;
        }

        /// <summary>
        /// Студент
        /// </summary>
        [JsonProperty("student")]
        public StudentExtModel Student
        {
            get;
            set;
        }
    }
}
