using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP;

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
        IApiResponse Connect(string login, string password);

        /// <summary>
        /// Отключиться
        /// </summary>
        void Disconnect();
    }
}
