using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.Analytic.Interfaces;

namespace UisApp.Components.Analytic
{
    class AnalyticModel : IAnalyticModel
    {
        /// <summary>
        /// Посещаемость
        /// </summary>
        public IList<AttendanceAnalyticModel> Attendance
        {
            get;
            set;
        }

        /// <summary>
        /// Оценки
        /// </summary>
        public IList<RatingAnalyticModel> Rating
        {
            get;
            set;
        }
    }
}
