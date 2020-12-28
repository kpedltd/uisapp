using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models.Interfaces;

namespace UisApp.API.Interfaces
{
    interface IApiResponse
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

        IModel data
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
        IApiResponse Connect(string login, string password);

        /// <summary>
        /// Put запрос
        /// </summary>
        /// <param name="uri">Адрес запроса</param>
        /// <param name="model">Модель</param>
        /// <param name="values">Параметры</param>
        /// <returns>JSON</returns>
        string Put(string uri, IModel model, Dictionary<string, string> values);

        /// <summary>
        /// Get запрос
        /// </summary>
        /// <param name="uri">Адрес запроса</param>
        /// <param name="model">Модель</param>
        /// <returns>JSON</returns>
        string Get(string uri, IModel model);

        /// <summary>
        /// Delete запрос
        /// </summary>
        /// <param name="uri">Адрес запроса</param>
        /// <param name="model">Модель</param>
        /// <returns>JSON</returns>
        string Delete(string uri, IModel model);

        /// <summary>
        /// Post запрос
        /// </summary>
        /// <param name="uri">Адрес запроса</param>
        /// <param name="model">Модель</param>
        /// <param name="values">Параметры</param>
        /// <returns>JSON</returns>
        string Post(string uri, IModel model, Dictionary<string, string> values);

        /// <summary>
        /// Отключиться
        /// </summary>
        void Disconnect();
    }
}
