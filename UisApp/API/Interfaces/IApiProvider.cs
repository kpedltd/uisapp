using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP;

namespace UisApp.API.Interfaces
{
    interface IApiResponse<T>
        where T : IModel
    {
        bool status
        {
            get;
            set;
        }

        string error
        {
            get;
            set;
        }

        string token
        {
            get;
            set;
        }

        T data
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Интерфейса обеспечения взаимодействия с сервером
    /// </summary>
    interface IApiProvider
    {
        /// <summary>
        /// Хост
        /// </summary>
        string Host
        {
            get;
            set;
        }

        /// <summary>
        /// Токен сессии клиента на стороне сервера для идентификации
        /// </summary>
        string sToken
        {
            get;
        }


        /// <summary>
        /// Подключиться
        /// </summary>
        /// <param name="sHost"></param>
        IApiResponse<IModel> Connect(string login, string password);

        /// <summary>
        /// Отключиться
        /// </summary>
        void Disconnect();

        /// <summary>
        /// Get Запрос
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        IApiResponse<T> GetRequest<T>(string uri)
            where T : IModel;

        /// <summary>
        /// Post запрос
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="nvc"></param>
        /// <returns></returns>
        IApiResponse<T> PostRequest<T>(string uri, NameValueCollection nvc)
            where T : IModel;
    }
}
