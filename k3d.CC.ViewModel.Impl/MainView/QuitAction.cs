using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl.MainView
{
    internal class QuitAction : MainViewAction, IParameterLessViewActionInternal
    {
        public QuitAction(IViewModelFactoryInternal factory, IMainViewInternal view)
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
