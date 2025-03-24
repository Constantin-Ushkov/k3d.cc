using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal class ActiveProperty<T> : IActivePropertyInternal<T>
    {
        public event EventHandler<ActivePropertyChangedEventArgs<T>>? Changed;

        public T? Value
        {
            get => _value;
            set
            {
                _value = value;
                Changed?.Invoke(this, new ActivePropertyChangedEventArgs<T>(this));
            }
        }

        protected T? _value = default;
    }
}
