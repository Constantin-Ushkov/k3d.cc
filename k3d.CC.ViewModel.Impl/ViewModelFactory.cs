using k3d.CC.Model.Interface;
using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    public class ViewModelFactory: IViewModelFactory
    {
        public ViewModelFactory(IModelFactory modelFactory)
        {
            _modelFactory = modelFactory;
            _model = modelFactory.CreateModel(); // todo: user
        }

        public IUserViewModel CreateUserViewModel()
            => throw new NotImplementedException();

        public IViewModel CreateViewModel(IUserViewModel user)
            => new ViewModel(model);

        private readonly IModelFactory _modelFactory;
        private readonly IModel _model;
    }
}
