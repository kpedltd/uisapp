using Newtonsoft.Json;
using UisApp.MVP;

namespace UisApp.Models
{
    internal enum SubjectCertification
    {
        exam,
        record,
        coursework
    }

    internal interface ISubjectModel : IModel
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