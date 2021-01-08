using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models;
using UisApp.MVP.Core;

namespace UisApp.Components.Profile.Interfaces
{
    public interface IProfileView : IView<IProfileView, IProfilePresenter>
    {
        void Update(ILecturerModel lecturerModel);
    }
}
