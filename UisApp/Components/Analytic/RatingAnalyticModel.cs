using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.Analytic.Interfaces;

namespace UisApp.Components.Analytic
{
    class RatingAnalyticModel : IRatingAnalyticModel
    {
        /// <summary>
        /// Оценка
        /// </summary>
        public int Grade
        {
            get;
            set;
        }

        /// <summary>
        /// Количество
        /// </summary>
        public int Count
        {
            get;
            set;
        }
    }
}
