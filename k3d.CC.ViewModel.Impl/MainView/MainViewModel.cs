using k3d.CC.ViewModel.Impl.LoginView;
using k3d.CC.ViewModel.Interface;
using k3d.Common.Diagnostics;

namespace k3d.CC.ViewModel.Impl.MainView
{
    internal class MainViewModel : ViewModel2, IMainViewInternal
    {
        public event EventHandler<Interface.ErrorEventArgs>? Error;
        public event EventHandler? LoggedIn;
        public event EventHandler? LoggedOut;

        public override ViewType ViewType => ViewType.Main;

        public IParameterLessViewAction LogOutAction => _logoutAction;
        public IParameterLessViewAction QuitAction => _quitAction;

        public MainViewModel(IViewModelFactoryInternal factory)
        {
            Assert.Argument.IsNotNull(factory, nameof(factory));

            _factory = factory;

            _viewModels = _factory.CreateViewModelCollection();
            _logoutAction = _factory.CreateLogoutAction();
            _quitAction = _factory.CreateQuitAction();

            // todo: allso add this\main view?
            _viewModels.AddSingleton(_factory.CreateLoginViewModel());
        }

        public override void OnShown()
        {
            base.OnShown();

            // todo: show login view
            // ShowModalView(_views.Get<ILoginView>());
            // 

            // todo: how to make this global?
            DisplayModalView(_viewModels.GetModel<ILoginViewModelInternal>());
        }

        public override void OnClosing()
        {
            base.OnClosing();
        }

        public void ReportError(string message, Exception? exception = null)
        {
            // todo: _errorLogView.AddError(message, exception);
            Error?.Invoke(this, new Interface.ErrorEventArgs(message, exception));
        }

        void IMainViewInternal.Quit()
        {
            throw new NotImplementedException();
        }

        void IMainViewInternal.Logout()
        {
            // _userModel.Logout();
            throw new NotImplementedException();
        }

        private readonly IViewModelFactoryInternal _factory;
        private readonly IParameterLessViewActionInternal _logoutAction;
        private readonly IParameterLessViewActionInternal _quitAction;
        private readonly IViewModelCollection _viewModels;
    }
}
