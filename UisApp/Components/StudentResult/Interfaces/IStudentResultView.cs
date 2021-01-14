using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP.Core;

namespace UisApp.Components.StudentResult.Interfaces
{
    public interface IStudentResultView : IView<IStudentResultView, IStudentResultPresenter>
    {
        /// <summary>
        /// Обновить модель
        /// </summary>
        /// <param name="model"></param>
        void Update(IResultModel model);
    }
}
