using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Core;
using UisApp.API.Interfaces;

namespace UisApp.API
{
    class FakeApiProvider : ApiProviderBase, IApiProvider
    {
        /// <summary>
        /// Получить экземпляр провайдера
        /// </summary>
        /// <returns></returns>
        public static IApiProvider MakeInstance(string sHost)
        {
            if (_instance == null)
            {
                _instance = new FakeApiProvider(sHost);
            }

            return _instance;
        }

        public string Host
        {
            get;
            set;
        }

        private FakeApiProvider(string sHost)
        {
            Host = sHost;
        }

        public string sToken => "fake";

        public void Disconnect()
        {
            return;
        }

        public IApiResponse Connect(string login, string password)
        {
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.status = true;

            return apiResponse;
        }
    }
}
