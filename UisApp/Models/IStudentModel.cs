using Newtonsoft.Json;
using System;
using UisApp.Helpers;
using UisApp.MVP;

namespace UisApp.Models
{
    internal interface IStudentModel : IModel
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
        /// ИД кафедры
        /// </summary>
        [JsonProperty("departmentId")]
        int DepartmentId
        {
            get;
            set;
        }

        /// <summary>
        /// ИД группы
        /// </summary>
        [JsonProperty("groupId")]
        int GroupId
        {
            get;
            set;
        }
    }
}