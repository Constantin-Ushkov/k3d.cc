namespace k3d.CC.ViewModel.Interface.MainView
{
    public interface IMainView : IViewModel2
    {
        IParameterLessViewAction LogOutAction { get; }
        IParameterLessViewAction QuitAction { get; }
    }
}
