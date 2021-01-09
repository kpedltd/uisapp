namespace UisApp.MVP.Support
{
    public delegate void PresenterEvent<TViewContract, TPresenterContract>(TPresenterContract sender, TViewContract view);
}