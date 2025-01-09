using k3d.CC.Model.Interface;
using k3d.CC.ViewModel.Interface;
using k3d.Logging.Interface;
using k3d.Common.Diagnostics;

namespace k3d.CC.ViewModel.Impl
{
    public class ViewModelFactory: IViewModelFactory
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

        private readonly ILogger _log;
        private readonly IModelFactory _modelFactory;
    }
}
