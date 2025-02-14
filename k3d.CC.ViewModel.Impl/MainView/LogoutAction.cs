using k3d.CC.ViewModel.Interface;
using k3d.Common.Diagnostics;

namespace k3d.CC.ViewModel.Impl.MainView
{
    internal class LogoutAction : IParameterLessViewActionInternal // ViewAction (enabled)
    {
        public IActiveProperty<bool> IsEnabled => throw new NotImplementedException();

        public LogoutAction(IMainViewInternal view)
        {
            Assert.Argument.IsNotNull(view, nameof(view));
            _view = view;
        }

        public void Enable(bool enabled)
        {
            throw new NotImplementedException();
        }

        public void Invoke()
            => _view.Logout();

        private readonly IMainViewInternal _view;
    }
}
