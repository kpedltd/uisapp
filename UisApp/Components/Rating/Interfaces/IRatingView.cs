using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.MVP.Core;

namespace UisApp.Components.Rating.Interfaces
{
    public interface IRatingView : IView<IRatingView, IRatingPresenter>
    {
        /// <summary>
        /// Обновить модель
        /// </summary>
        /// <param name="model"></param>
        void Update(IRatingModel model);
    }
}
