using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using UisApp.MVP;

namespace UisApp.Components.ScheduleTable.Interfaces
{
    public interface IScheduleTableModel : IModel
    {
        /// <summary>
        /// Событие обновления данных
        /// </summary>
        event EventHandler Updated;

        /// <summary>
        /// Записи расписания
        /// </summary>
        [JsonProperty("records")]
        IList<ScheduleDayModel> Records
        {
            get;
            set;
        }
    }
}