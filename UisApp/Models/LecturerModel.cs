using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Helpers;

namespace UisApp.Models
{
    class LecturerModel
    {
        public string firstName
        {
            get;
            set;
        }

        public string lastName
        {
            get;
            set;
        }

        public string patronymic
        {
            get;
            set;
        }

        [JsonConverter(typeof(CustomDateConverter))]
        public DateTime dateOfBirth
        {
            get;
            set;
        }

        public string photo
        {
            get;
            set;
        }

        public string biography
        {
            get;
            set;
        }

        public int departmentId
        {
            get;
            set;
        }

        public int headId
        {
            get;
            set;
        }

        public int curatorId
        {
            get;
            set;
        }

        public int deanId
        {
            get;
            set;
        }
    }
}
