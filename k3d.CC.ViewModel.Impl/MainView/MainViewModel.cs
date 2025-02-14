using k3d.CC.ViewModel.Interface;
using k3d.CC.ViewModel.Interface.MainView;
using k3d.Common.Diagnostics;

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

        public MainViewModel(IViewModelFactoryInternal factory)
        {
            Assert.Argument.IsNotNull(factory, nameof(factory));

            _factory = factory;
            _logoutAction = _factory.CreateLogoutAction();
            _quitAction = _factory.CreateQuitAction();
        }

        public override void OnShown()
        {
            base.OnShown();
        }

        public override void OnClosing()
        {
            base.OnClosing();
        }

        public void ReportError(string message, Exception exception = null)
        {
            // _errorLogView.AddError(message, exception);
            // Error?.Invoke(this, args);

            throw new NotImplementedException();
        }

        private readonly IViewModelFactoryInternal _factory;
        private readonly IParameterLessViewActionInternal _logoutAction;
        private readonly IParameterLessViewActionInternal _quitAction;
    }
}
