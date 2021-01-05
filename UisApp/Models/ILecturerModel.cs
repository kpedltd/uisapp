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
    interface ILecturerModel : IModel
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
        /// ИД кафедры
        /// </summary>
        [JsonProperty("departmentId")]
        int DepartmentId
        {
            get;
            set;
        }

        /// <summary>
        /// ИД кафедры, если зав. кафедры
        /// </summary>
        [JsonProperty("headId")]
        int HeadId
        {
            get;
            set;
        }

        /// <summary>
        /// ИД группы, если кураторы
        /// </summary>
        [JsonProperty("curatorId")]
        int CuratorId
        {
            get;
            set;
        }

        /// <summary>
        /// ИД факультета, если декан
        /// </summary>
        [JsonProperty("deanId")]
        int DeanId
        {
            get;
            set;
        }
    }
}
