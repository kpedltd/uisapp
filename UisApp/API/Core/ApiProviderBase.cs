using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Exceptions;
using UisApp.API.Interfaces;

namespace UisApp.API.Core
{
    abstract class ApiProviderBase
    {
        protected static IApiProvider _instance;

        /// <summary>
        /// Получить экземпляр провайдера
        /// </summary>
        /// <returns></returns>
        public static IApiProvider GetInstance()
        {
            if (_instance == null)
            {
                throw new ApiException("try get not initalized instance");
            }

            return _instance;
        }
    }
}
