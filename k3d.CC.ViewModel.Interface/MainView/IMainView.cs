namespace k3d.CC.ViewModel.Interface.MainView
{
    public interface IMainView : IViewModel2
    {
        event EventHandler<ErrorEventArgs>? Error;
        event EventHandler<ShowViewEventArgs>? ShowView;
        event EventHandler<ShowViewEventArgs>? ShowModalView;

        event EventHandler? LoggedIn;
        event EventHandler? LoggedOut;

        IParameterLessViewAction LogOutAction { get; }
        IParameterLessViewAction QuitAction { get; }
        // IParameterLessViewAction ShowRenameUserDialogAction { get; } - just ShowView
        // IParameterLessViewAction ShowChangePasswordDialogAction { get; } - just ShowView

        void ReportError(string message, Exception? exception = null);
    }
}
