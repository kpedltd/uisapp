using System;

namespace UisApp.API.Exceptions
{
    internal class ApiException : Exception
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