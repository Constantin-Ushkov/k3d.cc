using k3d.CC.ViewModel.Impl.Factory;
using k3d.Common.Diagnostics;

namespace k3d.CC.ViewModel.Impl.MainView.Actions
{
    internal class MainViewAction : ViewModelAction
    {
        public MainViewAction(IViewModelFactory factory, IMainViewInternal view) : base(factory)
        {
            Assert.Argument.IsNotNull(view, nameof(view));
            _view = view;
        }

        protected readonly IMainViewInternal _view;
    }
}
