using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.Models
{
    public class StudentExtModel : IStudentModel
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
        /// Имя
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Patronymic
        {
            get;
            set;
        }
    }
}
