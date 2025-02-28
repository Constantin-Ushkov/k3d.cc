using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal abstract class ViewModel2 : IViewModelInternal
    {
        public event EventHandler<ShowViewEventArgs>? ShowView;
        public event EventHandler<ShowViewEventArgs>? ShowModalView;

        public event EventHandler<ViewModelEventArgs>? Shown;
        public event EventHandler<ViewModelEventArgs>? Hidden;

        public abstract ViewType ViewType { get; }

        public virtual void OnClosing()
            => NotifyHidden();

        public virtual void OnShown()
            => NotifyShown();

        protected void DiplayView(IViewModel2 viewModel)
            => ShowView?.Invoke(this, new ShowViewEventArgs(viewModel));

        protected void DisplayModalView(IViewModel2 viewModel)
            => ShowModalView?.Invoke(this, new ShowViewEventArgs(viewModel));

        protected void NotifyShown()
            => Shown?.Invoke(this, new ViewModelEventArgs(this));

        protected void NotifyHidden()
            => Hidden?.Invoke(this, new ViewModelEventArgs(this));
    }
}
