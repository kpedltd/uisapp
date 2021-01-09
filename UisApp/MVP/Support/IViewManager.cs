using UisApp.MVP.Core;

namespace UisApp.MVP.Support
{
    public interface IViewManager<TViewContract, TPresenterContract>
        where TViewContract : IView<TViewContract, TPresenterContract>
        where TPresenterContract : IPresenter<TPresenterContract, TViewContract>
    {
        event PresenterEvent<TViewContract, TPresenterContract> BeforeviewConnect;

        event PresenterEvent<TViewContract, TPresenterContract> AfterviewConnect;

        event PresenterEvent<TViewContract, TPresenterContract> BeforeviewDisconnect;

        event PresenterEvent<TViewContract, TPresenterContract> AfterviewDisconnect;
    }
}