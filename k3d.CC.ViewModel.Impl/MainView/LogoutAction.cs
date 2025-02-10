using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl.MainView
{
    internal class LogoutAction : IParameterLessViewActionInternal
    {
        public IActiveProperty<bool> IsEnabled => throw new NotImplementedException();

        public void Enable(bool enabled)
        {
            throw new NotImplementedException();
        }
    }
}
