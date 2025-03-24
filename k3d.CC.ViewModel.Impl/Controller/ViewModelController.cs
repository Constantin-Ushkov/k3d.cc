using k3d.CC.Model.Interface;
using k3d.CC.ViewModel.Interface;
using k3d.CC.ViewModel.Interface.MainView;
using k3d.Logging.Interface;

namespace k3d.CC.ViewModel.Impl.Controller
{
    internal class ViewModelController : IControllerInternal
    {
        public event EventHandler<Interface.ErrorEventArgs>? Error;
        public event EventHandler<ShowViewEventArgs>? ShowView;
        public event EventHandler<ShowViewEventArgs>? ShowModalView;
        public event EventHandler? LoggedIn;
        public event EventHandler? LoggedOut;

        public IViewModelFactoryInternal Factory { get; }
        public IMainView MainView { get; }
        public IViewModelCollection Views { get; }

        public ViewModelController(ILogger logger, IModelFactory modelFactory)
        {
            Factory = new ViewModelFactory(logger, modelFactory);

            Views = Factory.CreateViewModelCollection();
            MainView = Factory.CreateMainView();
        }

        public void DisplayView<T>(bool modal) where T : class, IViewModelInternal
        {
            try
            {
                var view = Views.GetModel<T>();

                if (modal)
                {
                    ShowModalView?.Invoke(this, new ShowViewEventArgs(view));
                }
                else
                {
                    ShowView?.Invoke(this, new ShowViewEventArgs(view));
                }
            }
            catch (Exception ex)
            {
                ReportError($"Failed to display view of type {typeof(T).FullName}.", ex);
            }
        }

        public void ReportError(string message, Exception? exception = null)
        {
            throw new NotImplementedException();
        }
    }
}
