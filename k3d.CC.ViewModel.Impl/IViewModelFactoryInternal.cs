using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal interface IViewModelFactoryInternal: IViewModelFactory
    {
        IActivePropertyInternal<T> CreateActiveProperty<T>();

        IParameterLessViewActionInternal CreateLogoutAction();
        IParameterLessViewActionInternal CreateQuitAction();
    }
}
