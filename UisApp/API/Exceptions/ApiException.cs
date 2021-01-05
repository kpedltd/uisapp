using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.API.Exceptions
{
    class ApiException : Exception
    {
        public override string Message
        {
            get;
        }

        public ApiException(string message)
        {
            this.Message = message;
        }
    }
}
