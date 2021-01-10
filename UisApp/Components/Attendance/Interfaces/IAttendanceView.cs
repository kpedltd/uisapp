using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP.Core;

namespace UisApp.Components.Attendance.Interfaces
{
    public interface IAttendanceView : IView<IAttendanceView, IAttendancePresenter>
    {
        void Update(IAttendanceModel model);
    }
}
