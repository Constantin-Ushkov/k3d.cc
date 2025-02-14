using k3d.CC.ViewModel.Interface.MainView;

namespace k3d.CC.ViewModel.Impl.MainView
{
    internal interface IMainViewInternal: IMainView
    {
        void Quit();
        void Logout();
    }
}
