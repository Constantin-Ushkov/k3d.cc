using k3d.CC.ViewModel.Impl.Controller;
using k3d.CC.ViewModel.Impl.LoginView;
using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl.MainView
{
    internal class MainViewModel : ViewModel2, IMainViewInternal
    {
        public override ViewType ViewType => ViewType.Main;

        public IParameterLessViewAction LogOutAction => _logoutAction;
        public IParameterLessViewAction QuitAction => _quitAction;

        public MainViewModel(IControllerInternal controller)
            : base(controller)
        {
            _logoutAction = _controller.Factory.CreateLogoutAction(this);
            _quitAction = _controller.Factory.CreateQuitAction(this);
        }

        public override void OnShown()
        {
            base.OnShown();
            _controller.DisplayView<ILoginViewModelInternal>(true);
        }

        public override void OnClosing()
        {
            base.OnClosing();
        }

        void IMainViewInternal.Quit()
        {
            // probably shouldn't be here\action
            throw new NotImplementedException();
        }

        void IMainViewInternal.Logout()
        {
            // _userModel.Logout();
            throw new NotImplementedException();
        }

        private readonly IParameterLessViewActionInternal _logoutAction;
        private readonly IParameterLessViewActionInternal _quitAction;
    }
}
