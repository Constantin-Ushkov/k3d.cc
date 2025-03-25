using k3d.CC.ViewModel.Impl.Controller;
using k3d.CC.ViewModel.Interface;
using k3d.Common.Diagnostics;

namespace k3d.CC.ViewModel.Impl
{
    internal abstract class ViewModel2 : IViewModelInternal
    {
        public event EventHandler<ViewModelEventArgs>? Shown;
        public event EventHandler<ViewModelEventArgs>? Hidden;

        public abstract ViewType ViewType { get; }

        protected ViewModel2(IControllerInternal controller)
        {
            Assert.Argument.IsNotNull(controller, nameof(controller));
            _controller = controller;
        }

        public virtual void OnClosing()
            => NotifyHidden();

        public virtual void OnShown()
            => NotifyShown();

        protected void NotifyShown()
            => Shown?.Invoke(this, new ViewModelEventArgs(this));

        protected void NotifyHidden()
            => Hidden?.Invoke(this, new ViewModelEventArgs(this));

        protected readonly IControllerInternal _controller;
    }
}
