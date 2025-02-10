using k3d.CC.ViewModel.Interface;
using k3d.CC.ViewModel.Interface.MainView;

namespace k3d.CC.ViewModel.Impl.MainView
{
    internal class MainViewModel : ViewModel2, IMainView
    {
        public event EventHandler<Interface.ErrorEventArgs>? Error;
        public event EventHandler<ShowViewEventArgs>? ShowView;
        public event EventHandler<ShowViewEventArgs>? ShowModalView;
        public event EventHandler? LoggedIn;
        public event EventHandler? LoggedOut;

        public override ViewType ViewType => ViewType.Main;

        public IParameterLessViewAction LogOutAction => _logoutAction;
        public IParameterLessViewAction QuitAction => _quitAction;

        public MainViewModel()
        {
            // _logoutAction = _factory.Actions.CreateMainViewLogoutAction();
        }

        public void ReportError(string message, Exception exception = null)
        {
            // _errorLogView.AddError(message, exception);
            // Error?.Invoke(this, args);

            throw new NotImplementedException();
        }

        private readonly IParameterLessViewActionInternal _logoutAction;
        private readonly IParameterLessViewActionInternal _quitAction;
    }
}
