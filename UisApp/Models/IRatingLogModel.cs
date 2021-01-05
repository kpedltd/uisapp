using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP;

namespace UisApp.Models
{
    interface IRatingLogModel : IModel
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
