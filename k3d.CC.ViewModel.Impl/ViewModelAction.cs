using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal abstract class ViewModelAction : IViewActionInternal
    {
        public IActiveProperty<bool> IsEnabled => _enabled;

        protected ViewModelAction(IViewModelFactoryInternal factory)
        {
            _enabled = factory?.CreateActiveProperty<bool>()
                ?? throw new ArgumentNullException(nameof(factory));
        }

        public void Enable(bool enabled)
            => _enabled.Value = enabled;

        private IActivePropertyInternal<bool> _enabled;
    }
}
