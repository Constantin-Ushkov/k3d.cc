using k3d.CC.Model.Interface;
using k3d.CC.ViewModel.Interface;
using k3d.Logging.Interface;
using k3d.Common.Diagnostics;
using k3d.CC.ViewModel.Interface.MainView;
using k3d.CC.ViewModel.Impl.MainView;
using k3d.CC.ViewModel.Impl.MainView.Actions;
using k3d.CC.ViewModel.Impl.LoginView;

namespace k3d.CC.ViewModel.Impl
{
    public class ViewModelFactory: IViewModelFactoryInternal
    {
        public ViewModelFactory(ILogger log, IModelFactory modelFactory)
        {
            Assert.Argument.IsNotNull(log, nameof(log));
            Assert.Argument.IsNotNull(modelFactory, nameof(modelFactory));
            
            _log = log;
            _modelFactory = modelFactory;
        }

        public IUserViewModel CreateUserViewModel()
            => new UserViewModel(_log, _modelFactory);

        public IViewModel CreateViewModel(IUserViewModel userVm)
            => new ViewModel(_log, userVm, _modelFactory.CreateModel(userVm.GetUser()));

        public IMainView CreateMainView()
        {
            _mainView ??= new MainViewModel(this);
            return _mainView;
        }

        //
        // Explicit Implementation
        //

        IParameterLessViewActionInternal IViewModelFactoryInternal.CreateLogoutAction()
            => new LogoutAction(_mainView);

        IParameterLessViewActionInternal IViewModelFactoryInternal.CreateQuitAction()
            => new QuitAction(this, _mainView);

        IViewModelCollection IViewModelFactoryInternal.CreateViewModelCollection()
            => new ViewModelCollection();

        ILoginViewModelInternal IViewModelFactoryInternal.CreateLoginViewModel()
            => new LoginViewModel();

        private readonly ILogger _log;
        private readonly IModelFactory _modelFactory;
        private IMainViewInternal _mainView;
    }
}
