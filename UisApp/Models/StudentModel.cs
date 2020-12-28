using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Helpers;

namespace UisApp.Models
{
    class StudentModel
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

        public int departmentId
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
