using UisApp.Models;
using UisApp.MVP.Core;

namespace UisApp.Components.Profile.Interfaces
{
    public interface IProfileView : IView<IProfileView, IProfilePresenter>
    {
        void Update(ILecturerModel lecturerModel);
    }
}