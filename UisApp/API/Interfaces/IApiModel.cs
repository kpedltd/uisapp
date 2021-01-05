using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.API.Interfaces
{
    interface IApiModel
    {
        /// <summary>
        /// Put запрос
        /// </summary>
        void Update();

        /// <summary>
        /// Get запрос
        /// </summary>
        void Get();

        /// <summary>
        /// Delete запрос
        /// </summary>
        void Delete();

        /// <summary>
        /// Post запрос
        /// </summary>
        void Add();
    }
}
