using System.Collections.Generic;
using System.Collections.Specialized;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Components.ScheduleTable;
using UisApp.Components.ScheduleTable.Interfaces;
using UisApp.Models;

namespace UisApp.API.Providers
{
    internal static class ScheduleProvider
    {
        /// <summary>
        /// Получить расписание преподавателя
        /// </summary>
        /// <returns></returns>
        public static IScheduleTableModel GetLecturerSchedule()
        {
            var api = ApiProviderBase.GetInstance();
            IApiResponse<ScheduleTableModel> response = api.GetRequest<ScheduleTableModel>(UriResource.lecturer_schedule, null);

            var result = response.data as ScheduleTableModel;
            return result;
        }

        /// <summary>
        /// Получить расписание для конкретных ключей
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="subjectId"></param>
        /// <param name="dayOfWeek"></param>
        /// <returns></returns>
        public static IList<ScheduleExtModel> GetScheduleEntry(int groupId, int subjectId, ScheduleDayOfWeek dayOfWeek)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("groupId", groupId.ToString());
            nvc.Add("subjectId", subjectId.ToString());
            nvc.Add("dayOfWeek", dayOfWeek.ToString());

            var api = ApiProviderBase.GetInstance();
            IApiResponse<IList<ScheduleExtModel>> response = api.GetRequest<IList<ScheduleExtModel>>(UriResource.concrete_schedule, nvc);

            var result = response.data as IList<ScheduleExtModel>;

            return result;
        }
    }
}