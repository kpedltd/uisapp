using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.MVP;

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

        public IApiResponse<IModel> Connect(string login, string password)
        {
            ApiResponse<IModel> apiResponse = new ApiResponse<IModel>();
            apiResponse.status = true;

            return apiResponse;
        }


        public IApiResponse<T> GetRequest<T>(string uri) 
            where T : IModel
        {
            throw new NotImplementedException();
        }

        public IApiResponse<T> PostRequest<T>(string uri, NameValueCollection nvc) 
            where T : IModel
        {
            throw new NotImplementedException();
        }
    }
}
