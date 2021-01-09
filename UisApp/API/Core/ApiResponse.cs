using UisApp.API.Interfaces;
using UisApp.MVP;

namespace UisApp.API.Core
{
    internal class ApiResponse<T> : IApiResponse<T>
        where T : IModel
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

        public T data
        {
            get;
            set;
        }

        public ApiResponse()
        {
        }
    }
}