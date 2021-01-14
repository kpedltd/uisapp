using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP;

namespace UisApp.Components.StudentResult.Interfaces
{
    public interface IStudentTaskModel : IModel
    {
        /// <summary>
        /// ИД
        /// </summary>
        [JsonProperty("Id")]
        int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Название
        /// </summary>
        [JsonProperty("title")]
        string Title
        {
            get;
            set;
        }
    }
}
