using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.ScheduleTable.Interfaces;
using UisApp.Models;

namespace UisApp.Components.ScheduleTable
{
    public class ScheduleDayModel : IScheduleDayModel
    {
        /// <summary>
        /// День недели
        /// </summary>
        public ScheduleDayOfWeek DayOfWeek
        {
            get;
            set;
        }

        /// <summary>
        /// Список записей
        /// </summary>
        public IList<ScheduleRecordModel> Records
        {
            get;
            set;
        }
    }
}
