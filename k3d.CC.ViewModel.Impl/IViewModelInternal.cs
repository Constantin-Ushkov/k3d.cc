using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal class ViewModelEventArgs : EventArgs
    {
        public IViewModelInternal ViewModel { get; }

        public ViewModelEventArgs(IViewModelInternal viewModel)
        {
            ViewModel = viewModel;
        }
    }

    internal interface IViewModelInternal: IViewModel2
    {
        event EventHandler<ViewModelEventArgs>? Shown;
        event EventHandler<ViewModelEventArgs>? Hidden;
    }
}
