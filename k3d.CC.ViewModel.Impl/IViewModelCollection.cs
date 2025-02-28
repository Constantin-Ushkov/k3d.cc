using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal interface IViewModelCollection
    {
        IEnumerable<IViewModelInternal> ActiveViews { get; }

        void AddSingleton<T>(T viewModel) where T : class, IViewModelInternal;
        void AddFactory<T>(Func<IViewModelInternal> factory) where T : class, IViewModelInternal;

        T GetModel<T>() where T : class, IViewModelInternal;
    }
}
