using Newtonsoft.Json;
using System;
using UisApp.Helpers;
using UisApp.MVP;

namespace UisApp.Models
{
    internal interface ITaskModel : IModel
    {
        /// <summary>
        /// Название
        /// </summary>
        [JsonProperty("title")]
        string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Описание
        /// </summary>
        [JsonProperty("description")]
        string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Фото
        /// </summary>
        [JsonProperty("photo")]
        string Photo
        {
            get;
            set;
        }

        /// <summary>
        /// Ссылка на тест
        /// </summary>
        [JsonProperty("test")]
        string Test
        {
            get;
            set;
        }

        /// <summary>
        /// Дата начала
        /// </summary>
        [JsonProperty("begin")]
        [JsonConverter(typeof(CustomDateConverter))]
        DateTime Begin
        {
            get;
            set;
        }

        /// <summary>
        /// Дедлайн
        /// </summary>
        [JsonProperty("deadline")]
        [JsonConverter(typeof(CustomDateConverter))]
        DateTime Deadline
        {
            get;
            set;
        }
    }
}