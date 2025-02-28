using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl.LoginView
{
    internal class LoginViewModel : ViewModel2, ILoginViewModelInternal
    {
        public override ViewType ViewType => ViewType.Login;
    }
}
