
namespace k3d.CC.ViewModel.Interface
{
    public class ActivePropertyChangedEventArgs<T>: EventArgs
    {
        public IActiveProperty<T> Property { get; }

        public ActivePropertyChangedEventArgs(IActiveProperty<T> property)
            => Property = property;
    }
}
