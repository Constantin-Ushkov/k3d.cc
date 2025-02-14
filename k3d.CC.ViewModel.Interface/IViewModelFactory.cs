using k3d.CC.ViewModel.Interface.MainView;

namespace k3d.CC.ViewModel.Interface
{
    public interface IViewModelFactory
    {
        // todo: delete those 2
        IUserViewModel CreateUserViewModel();
        IViewModel CreateViewModel(IUserViewModel user);

        IMainView CreateMainView();
    }
}
