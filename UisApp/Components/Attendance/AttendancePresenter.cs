using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.Attendance.Interfaces;
using UisApp.MVP.Support;

namespace UisApp.Components.Attendance
{
    class AttendancePresenter : PresenterBase<IAttendancePresenter, IAttendanceView>, IAttendancePresenter
    {
        IAttendanceModel Model;

        protected override IAttendancePresenter GetPresenterEndpoint()
        {
            return this;
        }

        protected override void RefreshView(IAttendanceView viewInstance)
        {
            if (viewInstance == null)
            {
                throw new ArgumentNullException(nameof(viewInstance));
            }

            viewInstance.Update(Model);
        }
    }
}
