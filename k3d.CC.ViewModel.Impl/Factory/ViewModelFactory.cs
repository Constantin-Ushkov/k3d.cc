using k3d.CC.Model.Interface;
using k3d.CC.ViewModel.Interface;
using k3d.Logging.Interface;
using k3d.Common.Diagnostics;
using k3d.CC.ViewModel.Interface.MainView;
using k3d.CC.ViewModel.Impl.MainView;
using k3d.CC.ViewModel.Impl.MainView.Actions;
using k3d.CC.ViewModel.Impl.LoginView;
using k3d.CC.ViewModel.Impl.Controller;

namespace k3d.CC.ViewModel.Impl.Factory
{
    internal class ViewModelFactory : IViewModelFactory
    {
        public ViewModelFactory(IControllerInternal controller, ILogger log, IModelFactory modelFactory)
        {
            Assert.Argument.IsNotNull(controller, nameof(controller));
            Assert.Argument.IsNotNull(log, nameof(log));
            Assert.Argument.IsNotNull(modelFactory, nameof(modelFactory));

            _controller = controller;
            _log = log;
            _modelFactory = modelFactory;
        }

        public IUserViewModel CreateUserViewModel()
            => new UserViewModel(_log, _modelFactory);

        public IViewModel CreateViewModel(IUserViewModel userVm)
            => new ViewModel(_log, userVm, _modelFactory.CreateModel(userVm.GetUser()));

        public IMainView CreateMainView()
            => new MainViewModel(this);

        public IParameterLessViewActionInternal CreateLogoutAction(IMainViewInternal mainView)
            => new LogoutAction(mainView);

        public IParameterLessViewActionInternal CreateQuitAction(IMainViewInternal mainView)
            => new QuitAction(this, mainView);

        public IViewModelCollection CreateViewModelCollection()
            => new ViewModelCollection();

        public ILoginViewModelInternal CreateLoginViewModel()
            => new LoginViewModel();

        public IActivePropertyInternal<T> CreateActiveProperty<T>()
            => new ActiveProperty<T>();

        private readonly IControllerInternal _controller;
        private readonly ILogger _log;
        private readonly IModelFactory _modelFactory;
    }
}
