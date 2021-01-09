using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Components.ScheduleTable;
using UisApp.Components.ScheduleTable.Interfaces;

namespace UisApp.API.Providers
{
    static class ScheduleTableProvider
    {
        public static IScheduleTableModel GetLecturerSchedule()
        {
            var api = ApiProviderBase.GetInstance();
            IApiResponse<ScheduleTableModel> response = api.GetRequest<ScheduleTableModel>(UriResource.lecturer_schedule);

            var result = response.data as ScheduleTableModel;
            return result;
        }
    }
}
