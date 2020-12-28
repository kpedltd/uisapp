using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Helpers;

namespace UisApp.Models
{
    class TaskModel
    {
        public string descirption
        {
            get;
            set;
        }

        public string photo
        {
            get;
            set;
        }

        public string test
        {
            get;
            set;
        }

        [JsonConverter(typeof(CustomDateConverter))]
        public DateTime begin
        {
            get;
            set;
        }

        [JsonConverter(typeof(CustomDateConverter))]
        public DateTime deadline
        {
            get;
            set;
        }

        public int subjectId
        {
            get;
            set;
        }

        public int groupId
        {
            get;
            set;
        }
    }
}
