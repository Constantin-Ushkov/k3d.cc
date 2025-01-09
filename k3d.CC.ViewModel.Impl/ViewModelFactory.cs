using k3d.CC.Model.Interface;
using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    public class ViewModelFactory: IViewModelFactory
    {
        public ViewModelFactory(IModelFactory modelFactory)
            => _modelFactory = modelFactory;

        public IUserViewModel CreateUserViewModel()
            => new UserViewModel(_modelFactory);

        public IViewModel CreateViewModel(IUserViewModel userVm)
            => new ViewModel(userVm, _modelFactory.CreateModel(userVm.GetUser()));

        private readonly IModelFactory _modelFactory;
    }
}
