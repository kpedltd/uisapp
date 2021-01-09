using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP.Core;

namespace UisApp.Components.ScheduleTable.Interfaces
{
    public interface IScheduleTableView : IView<IScheduleTableView, IScheduleTablePresenter>
    {
        /// <summary>
        /// Записи расписания
        /// </summary>
        IList<ScheduleDayModel> Records
        {
            get;
            set;
        }

        void Update(IScheduleTableModel lecturerModel);
    }
}
