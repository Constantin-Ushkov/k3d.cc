using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal abstract class ViewModel2 : IViewModel2
    {
        public abstract ViewType ViewType { get; }

        public virtual void OnClosing()
        {
        }

        public virtual void OnShown()
        {
        }
    }
}
