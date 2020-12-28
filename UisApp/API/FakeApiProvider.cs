using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Interfaces;
using UisApp.Models.Interfaces;

namespace UisApp.API
{
    class FakeApiProvider : IApiProvider
    {
        public string sToken => throw new NotImplementedException();

        public string Delete(string uri, IModel model)
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public string Get(string uri, IModel model)
        {
            throw new NotImplementedException();
        }

        public string Post(string uri, IModel model, Dictionary<string, string> values)
        {
            throw new NotImplementedException();
        }

        public string Put(string uri, IModel model, Dictionary<string, string> values)
        {
            throw new NotImplementedException();
        }

        public IApiResponse Connect(string login, string password)
        {
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.status = true;

            return apiResponse;
        }
    }
}
