using Newtonsoft.Json;
using System;
using UisApp.Helpers;
using UisApp.MVP;

namespace UisApp.Models
{
    public interface IStudentModel : IModel
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
    }
}