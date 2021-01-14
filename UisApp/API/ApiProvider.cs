using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using UisApp.API.Core;
using UisApp.API.Exceptions;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.MVP;

namespace UisApp.API
{
    internal class ApiProvider : ApiProviderBase, IApiProvider, IDisposable
    {
        /// <summary>
        /// Получить экземпляр провайдера
        /// </summary>
        /// <returns></returns>
        public static IApiProvider MakeInstance(string sHost)
        {
            if (_instance == null)
            {
                _instance = new ApiProvider(sHost);
            }

            return _instance;
        }

        /// <summary>
        /// Экземпляр подключения
        /// </summary>
        public HttpClient connection
        {
            get;
            private set;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        private ApiProvider(string sHost)
        {
            Host = sHost;

            connection = new HttpClient();
            connection.BaseAddress = new Uri(sHost);
            connection.DefaultRequestHeaders.Accept.Clear();
            connection.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            connection.Timeout = TimeSpan.FromSeconds(2);
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
        /// Хост
        /// </summary>
        public string Host
        {
            get;
            set;
        }

        /// <summary>
        /// Подключиться
        /// </summary>
        /// <param name="sHost"></param>
        public IApiResponse<IModel> Connect(string login, string password)
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
            ApiResponse<IModel> data = JsonConvert.DeserializeObject<ApiResponse<IModel>>(result);
            if (!data.status)
            {
                throw new ApiException(data.error);
            }

            this.sToken = data.token;

            return data;
        }

        /// <summary>
        /// Отключиться
        /// </summary>
        public void Disconnect()
        {
            var queryParams = new NameValueCollection()
            {
                { "secret_token", sToken }
            };

            string query = UriResource.logout + ToQueryString(queryParams);

            HttpResponseMessage response = connection.PostAsync(
                query, null).GetAwaiter().GetResult();

            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;
            ApiResponse<IModel> data = JsonConvert.DeserializeObject<ApiResponse<IModel>>(result);
            if (!data.status)
            {
                throw new ApiException(data.error);
            }
        }

        /// <summary>
        /// Разрушение объекта
        /// </summary>
        public void Dispose()
        {
            this.Disconnect();
        }

        public static string ToQueryString(NameValueCollection nvc)
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

        public IApiResponse<T> GetRequest<T>(string uri, NameValueCollection nvc)
        {
            if(nvc == null)
            {
                nvc = new NameValueCollection();
            }

            nvc.Add("secret_token", sToken);

            string query = uri + ToQueryString(nvc);

            HttpResponseMessage response = connection.GetAsync(
                query).GetAwaiter().GetResult();

            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;
            ApiResponse<T> data = JsonConvert.DeserializeObject<ApiResponse<T>>(result);
            if(!data.status)
            {
                throw new ApiException(data.error);
            }

            return data;
        }

        public IApiResponse<T> PostRequest<T>(string uri, NameValueCollection nvc)
        {
            if (nvc == null)
            {
                nvc = new NameValueCollection();
            }

            nvc.Add("secret_token", sToken);

            string query = uri + ToQueryString(nvc);

            HttpResponseMessage response = connection.PostAsync(
                query, null).GetAwaiter().GetResult();

            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;
            ApiResponse<T> data = JsonConvert.DeserializeObject<ApiResponse<T>>(result);
            if (!data.status)
            {
                throw new ApiException(data.error);
            }

            return data;
        }

        /// <summary>
        /// Отправить файл
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri"></param>
        /// <param name="nvc"></param>
        /// <param name="paramFileBytes"></param>
        public void SendFile(string uri, NameValueCollection nvc, byte[] paramFileBytes)
        {
            nvc.Add("secret_token", sToken);
            string query = uri + ToQueryString(nvc);

            HttpContent bytesContent = new ByteArrayContent(paramFileBytes);
            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(bytesContent, "file", "file");

                var response = connection.PostAsync(query, formData).GetAwaiter().GetResult();

                response.EnsureSuccessStatusCode();
            }
        }
    }
}