using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models.Interfaces;

namespace UisApp.Models
{
    enum EduProgramType
    {
        /// <summary>
        /// Очная
        /// </summary>
        fulltime,

        /// <summary>
        /// Заочная
        /// </summary>
        parttime
    }

    class EduProgramModel : IModel
    {
        /// <summary>
        /// Название
        /// </summary>
        public string name
        {
            get;
            set;
        }

        /// <summary>
        /// Код программы
        /// </summary>
        public string code
        {
            get;
            set;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public EduProgramType type
        {
            get;
            set;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
