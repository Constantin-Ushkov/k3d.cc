using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal interface IActivePropertyInternal<T>: IActiveProperty<T>
    {
        new T? Value { get; set; }
    }
}
