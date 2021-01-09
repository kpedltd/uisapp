using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.ScheduleTable.Interfaces;

namespace UisApp.Components.ScheduleTable
{
    public class ScheduleTableModel : IScheduleTableModel
    {
        /// <summary>
        /// Событие обновления данных
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Записи расписания
        /// </summary>
        public IList<ScheduleDayModel> Records
        {
            get;
            set;
        }

        public ScheduleTableModel()
        {

        }
    }
}
