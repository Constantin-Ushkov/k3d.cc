
namespace k3d.CC.ViewModel.Interface
{
    public interface IViewModelFactory
    {
        IUserViewModel CreateUserViewModel();
        IViewModel CreateViewModel(IUserViewModel user);
    }
}
