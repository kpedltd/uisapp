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
        /// Студент
        /// </summary>
        [JsonProperty("student")]
        StudentExtModel Student
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
