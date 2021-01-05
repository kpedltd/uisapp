using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP;

namespace UisApp.Models
{
    enum SubjectCertification
    {
        exam,
        record,
        coursework
    }

    interface ISubjectModel : IModel
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
        /// ИД преподавателя
        /// </summary>
        [JsonProperty("lecturerId")]
        int LecturerId
        {
            get;
            set;
        }

        /// <summary>
        /// Вид аттестации
        /// </summary>
        [JsonProperty("certification")]
        SubjectCertification Certification
        {
            get;
            set;
        }
    }
}
