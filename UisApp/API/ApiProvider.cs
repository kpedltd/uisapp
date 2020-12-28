using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Models.Interfaces;
using System.Web;

namespace UisApp.API
{
    class ApiProvider : IApiProvider, IDisposable
    {
        private static ApiProvider _instance;

        /// <summary>
        /// Экземпляр подключения
        /// </summary>
        private HttpClient connection;

        /// <summary>
        /// Конструктор
        /// </summary>
        private ApiProvider(string sHost)
        {
            connection = new HttpClient();
            connection.BaseAddress = new Uri(sHost);
            connection.DefaultRequestHeaders.Accept.Clear();
            connection.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Токен сессии подключения
        /// </summary>
        public string sToken
        {
            get;
            private set;
        }

        /// <summary>
        /// Получить экземпляр провайдера
        /// </summary>
        /// <returns></returns>
        public static ApiProvider GetInstance(string sHost)
        {
            if (_instance == null)
            {
                _instance = new ApiProvider(sHost);
            }
            return _instance;
        }

        /// <summary>
        /// Подключиться
        /// </summary>
        /// <param name="sHost"></param>
        public IApiResponse Connect(string login, string password)
        {
            var queryParams = new NameValueCollection()
            {
                { "login", login },
                { "password", password }
            };

            string query = UriResource.auth + ToQueryString(queryParams);

            HttpResponseMessage response = connection.PostAsync(
                query, null).GetAwaiter().GetResult();

            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;
            ApiResponse data = JsonConvert.DeserializeObject<ApiResponse>(result);
            if(data.status)
            {
                this.sToken = data.token;
            }

            return data;
        }

        /// <summary>
        /// Put запрос
        /// </summary>
        /// <param name="uri">Адрес запроса</param>
        /// <param name="model">Модель</param>
        /// <param name="values">Параметры</param>
        /// <returns>JSON</returns>
        public string Put(string uri, IModel model, Dictionary<string, string> values)
        {
            return null;
        }

        /// <summary>
        /// Get запрос
        /// </summary>
        /// <param name="uri">Адрес запроса</param>
        /// <param name="model">Модель</param>
        /// <returns>JSON</returns>
        public string Get(string uri, IModel model)
        {
            return null;
        }

        /// <summary>
        /// Delete запрос
        /// </summary>
        /// <param name="uri">Адрес запроса</param>
        /// <param name="model">Модель</param>
        /// <returns>JSON</returns>
        public string Delete(string uri, IModel model)
        {
            return null;
        }

        /// <summary>
        /// Post запрос
        /// </summary>
        /// <param name="uri">Адрес запроса</param>
        /// <param name="model">Модель</param>
        /// <param name="values">Параметры</param>
        /// <returns>JSON</returns>
        public string Post(string uri, IModel model, Dictionary<string, string> values)
        {
            return null;
        }

        /// <summary>
        /// Отключиться
        /// </summary>
        public void Disconnect()
        {
            
        }

        /// <summary>
        /// Разрушение объекта
        /// </summary>
        public void Dispose()
        {
            this.Disconnect();
        }

        public string ToQueryString(NameValueCollection nvc)
        {
            StringBuilder sb = new StringBuilder("?");

            bool first = true;

            foreach (string key in nvc.AllKeys)
            {
                foreach (string value in nvc.GetValues(key))
                {
                    if (!first)
                    {
                        sb.Append("&");
                    }

                    sb.AppendFormat("{0}={1}", Uri.EscapeDataString(key), Uri.EscapeDataString(value));

                    first = false;
                }
            }

            return sb.ToString();
        }
    }

    class ApiResponse : IApiResponse
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

        public IModel data
        {
            get;
            set;
        }

        public ApiResponse() { }
    }

}
