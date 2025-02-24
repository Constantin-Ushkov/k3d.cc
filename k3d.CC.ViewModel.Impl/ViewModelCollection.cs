using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal class ViewModelCollection : IViewModelCollection
    {
        public void AddModel<T>(T viewModel) where T : IViewModel2
        {
            //
        }

        public void AddModelFactory<T>(Func<T> factory) where T : IViewModel2
        {
            //
        }

        public T GetModel<T>() where T : IViewModel2
        {
            throw new NotImplementedException();
        }
    }
}
