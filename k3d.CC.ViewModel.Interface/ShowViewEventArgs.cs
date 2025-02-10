
namespace k3d.CC.ViewModel.Interface
{
    public class ShowViewEventArgs: EventArgs
    {
        public IViewModel2 ViewModel { get; }

        public ShowViewEventArgs(IViewModel2 viewModel)
        {
            ViewModel = viewModel;
        }
    }
}
