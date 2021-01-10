using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Components.Attendance;

namespace UisApp.API.Providers
{
    static class AttendanceProvider
    {
        /// <summary>
        /// Получить посещаемость
        /// </summary>
        /// <param name="scheduleId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static IList<StudentAttendanceModel> GetAttendance(int scheduleId, DateTime date)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("scheduleId", scheduleId.ToString());
            nvc.Add("date", date.ToString("yyyy-mm-dd"));

            var api = ApiProviderBase.GetInstance();
            IApiResponse<IList<StudentAttendanceModel>> response = api.GetRequest<IList<StudentAttendanceModel>>(UriResource.lecturer_subjects, nvc);

            var result = response.data as IList<StudentAttendanceModel>;
            return result;
        }
    }
}
