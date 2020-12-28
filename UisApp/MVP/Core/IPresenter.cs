using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.MVP.Core
{
    public interface IPresenter<TPresenterContract, TViewContract>
        where TPresenterContract : IPresenter<TPresenterContract, TViewContract>
        where TViewContract : IView<TViewContract, TPresenterContract>
    {
        void ConnectView(TViewContract viewInstance, bool requiresState);

        void DisconnectView(TViewContract viewInstance);
    }
}
