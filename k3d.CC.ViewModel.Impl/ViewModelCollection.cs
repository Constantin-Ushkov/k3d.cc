using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal class ViewModelCollection : IViewModelCollection
    {
        public IEnumerable<IViewModelInternal> ActiveViews => _activeViews;

        public void AddSingleton<T>(T viewModel) where T : class, IViewModelInternal
        {
            SetupHooks(viewModel);
            _singletons.Add(typeof(T), viewModel);
        }

        public void AddFactory<T>(Func<IViewModelInternal> factory) where T : class, IViewModelInternal
            => _factories.Add(typeof(T), factory);

        public T GetModel<T>() where T : class, IViewModelInternal
        {
            var type = typeof(T);

            if (_singletons.TryGetValue(type, out var model))
            {
                return model as T
                    ?? throw new ViewModelException($"Failed to retrieve view model of type {type.FullName}.");
            }

            if (_factories.TryGetValue(type, out var factory))
            {
                var vm = factory.Invoke()
                    ?? throw new ViewModelException($"Failed to construct view-model of type '{typeof(T)?.FullName}'.");

                SetupHooks(vm);

                return vm as T
                    ?? throw new ViewModelException($"Failed to cast created view-model to type '{typeof(T)?.FullName}'.");
            }
            else
            {
                throw new ViewModelException($"Failed to find a factory for view-model of type '{typeof(T)?.FullName}'.");
            }
        }

        private void SetupHooks(IViewModelInternal vm)
        {
            vm.Shown += (sender, args)
                => _activeViews.Add(args.ViewModel);

            vm.Hidden += (sender, args)
                => _activeViews.Remove(args.ViewModel);
        }

        private readonly Dictionary<Type, IViewModelInternal> _singletons = [];
        private readonly Dictionary<Type, Func<IViewModelInternal>> _factories = [];
        private readonly HashSet<IViewModelInternal> _activeViews = [];
    }
}
