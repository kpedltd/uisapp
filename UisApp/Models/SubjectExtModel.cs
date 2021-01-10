using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.Models
{
    public class SubjectExtModel : ISubjectModel
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
        public string Name
        {
            get;
            set;
        }
    }
}
