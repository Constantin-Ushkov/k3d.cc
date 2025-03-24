using k3d.CC.ViewModel.Interface.MainView;

namespace k3d.CC.ViewModel.Interface
{
    public interface IViewModelController
    {
        event EventHandler<ErrorEventArgs>? Error;
        event EventHandler<ShowViewEventArgs>? ShowView;
        event EventHandler<ShowViewEventArgs>? ShowModalView;

        event EventHandler? LoggedIn;
        event EventHandler? LoggedOut;

        IMainView MainView { get; }
    }
}
