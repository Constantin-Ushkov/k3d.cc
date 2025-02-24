using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal interface IViewModelCollection
    {
        void AddModel<T>(T viewModel) where T : IViewModel2;
        void AddModelFactory<T>(Func<T> factory) where T : IViewModel2;

        T GetModel<T>() where T : IViewModel2;
    }
}
