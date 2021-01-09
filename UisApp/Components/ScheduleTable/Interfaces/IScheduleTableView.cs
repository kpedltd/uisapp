using System.Collections.Generic;
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