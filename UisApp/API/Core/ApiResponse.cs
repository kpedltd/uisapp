using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Interfaces;
using UisApp.MVP;

namespace UisApp.API.Core
{
    class ApiResponse : IApiResponse
    {
        public bool status
        {
            get;
            set;
        }

        public string error
        {
            get;
            set;
        }

        public string token
        {
            get;
            set;
        }

        public IModel data
        {
            get;
            set;
        }

        public ApiResponse() { }
    }
}
