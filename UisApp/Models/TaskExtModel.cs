using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.Models
{
    public class TaskExtModel : ITaskModel
    {
        /// <summary>
        /// ИД
        /// </summary>
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Название
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Фото
        /// </summary>
        public string Photo
        {
            get;
            set;
        }

        /// <summary>
        /// Ссылка на тест
        /// </summary>
        public string Test
        {
            get;
            set;
        }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime Begin
        {
            get;
            set;
        }

        /// <summary>
        /// Дедлайн
        /// </summary>
        public DateTime Deadline
        {
            get;
            set;
        }
    }
}
