using k3d.CC.ViewModel.Impl.LoginView;
using k3d.CC.ViewModel.Impl.MainView;

namespace k3d.CC.ViewModel.Impl.Factory
{
    internal interface IViewModelFactory
    {
        IActivePropertyInternal<T> CreateActiveProperty<T>();

        IMainViewInternal CreateMainView();
        IParameterLessViewActionInternal CreateLogoutAction(IMainViewInternal mainView);
        IParameterLessViewActionInternal CreateQuitAction(IMainViewInternal mainView);

        IViewModelCollection CreateViewModelCollection();

        ILoginViewModelInternal CreateLoginViewModel();
    }
}
