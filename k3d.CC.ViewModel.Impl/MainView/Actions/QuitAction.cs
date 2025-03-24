using k3d.CC.ViewModel.Impl.Factory;
using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl.MainView.Actions
{
    internal class QuitAction : MainViewAction, IParameterLessViewActionInternal
    {
        public QuitAction(Factory.IViewModelFactory factory, IMainViewInternal view)
            : base(factory, view)
        {
        }

        public void Enable(bool enabled)
        {
            IsEnabled.Value = enabled; // todo: fix me!
        }

        public void Invoke()
            => _view.Quit();
    }
}
