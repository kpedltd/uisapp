using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP.Core;

namespace UisApp.Components.StudyTask.Interfaces
{
    public interface IStudyTaskView : IView<IStudyTaskView, IStudyTaskPresenter>
    {
        /// <summary>
        /// Обновить модель
        /// </summary>
        /// <param name="model"></param>
        void Update(IStudyTaskModel model);
    }
}
