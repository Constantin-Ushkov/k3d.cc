
namespace k3d.CC.ViewModel.Interface
{
    public interface IActiveProperty<T>
    {
        event EventHandler<ActivePropertyChangedEventArgs<T>> Changed;

        T Value { get; set; }
        bool IsReadOnly { get; }
    }
}
