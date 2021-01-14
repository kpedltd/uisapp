using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models;
using UisApp.MVP;

namespace UisApp.Components.StudentResult.Interfaces
{
    interface IStudentResultModel : IModel
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

        /// <summary>
        /// Задача
        /// </summary>
        [JsonProperty("task")]
        StudentTaskModel Task
        {
            get;
            set;
        }

        /// <summary>
        /// Студент
        /// </summary>
        [JsonProperty("student")]
        StudentExtModel Student
        {
            get;
            set;
        }
    }
}
