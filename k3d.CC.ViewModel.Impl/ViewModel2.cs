using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal abstract class ViewModel2 : IViewModel2
    {
        public event EventHandler<ShowViewEventArgs>? ShowView;
        public event EventHandler<ShowViewEventArgs>? ShowModalView;

        public abstract ViewType ViewType { get; }

        public virtual void OnClosing()
        {
        }

        public virtual void OnShown()
        {
        }

        protected void DiplayView(IViewModel2 viewModel)
            => ShowView?.Invoke(this, new ShowViewEventArgs(viewModel));

        protected void DisplayModalView(IViewModel2 viewModel)
            => ShowModalView?.Invoke(this, new ShowViewEventArgs(viewModel));
    }
}
