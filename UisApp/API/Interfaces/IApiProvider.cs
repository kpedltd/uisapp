using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using UisApp.MVP;

namespace UisApp.API.Interfaces
{
    internal interface IApiResponse<T>
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
    internal interface IApiProvider
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
        IApiResponse<T> GetRequest<T>(string uri, NameValueCollection nvc);

        /// <summary>
        /// Post запрос
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="nvc"></param>
        /// <returns></returns>
        IApiResponse<T> PostRequest<T>(string uri, NameValueCollection nvc);


        /// <summary>
        /// Отправить файл
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri"></param>
        /// <param name="nvc"></param>
        /// <param name="paramFileStream"></param>
        /// <param name="paramFileBytes"></param>
        void SendFile(string uri, NameValueCollection nvc, byte[] paramFileBytes);
    }
}