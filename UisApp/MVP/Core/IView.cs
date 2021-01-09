namespace UisApp.MVP.Core
{
    public interface IView<TViewContract, TPresenterContract>
       where TViewContract : IView<TViewContract, TPresenterContract>
       where TPresenterContract : IPresenter<TPresenterContract, TViewContract>
    {
        void AttachToPresenter(TPresenterContract presenter, bool requiresInitialState);

        void DetatchFromPresenter();

        TPresenterContract Presenter { get; }
    }
}