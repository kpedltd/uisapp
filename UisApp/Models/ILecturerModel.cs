using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Helpers;
using UisApp.MVP;

namespace UisApp.Models
{
    public interface ILecturerModel : IModel
    {
        /// <summary>
        /// Имя
        /// </summary>
        [JsonProperty("firstName")]
        string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        [JsonProperty("lastName")]
        string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        [JsonProperty("patronymic")]
        string Patronymic
        {
            get;
            set;
        }

        /// <summary>
        /// Дата рождения
        /// </summary>
        [JsonProperty("dateOfBirth")]
        [JsonConverter(typeof(CustomDateConverter))]
        DateTime DateOfBirth
        {
            get;
            set;
        }

        /// <summary>
        /// Ссылка на фото
        /// </summary>
        [JsonProperty("photo")]
        string Photo
        {
            get;
            set;
        }

        /// <summary>
        /// Биография
        /// </summary>
        [JsonProperty("biography")]
        string Biography
        {
            get;
            set;
        }

        /// <summary>
        /// Имя кафедры
        /// </summary>
        [JsonProperty("department")]
        string DepartmentName
        {
            get;
            set;
        }

        /// <summary>
        /// Имя факультета
        /// </summary>
        [JsonProperty("faculty")]
        string FacultyName
        {
            get;
            set;
        }
    }
}
