
namespace k3d.CC.ViewModel.Interface
{
    public interface IViewModel2
    {
        ViewType ViewType { get; }

        void OnShown();
        void OnClosing();
    }
}
