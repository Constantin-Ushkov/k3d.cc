
using k3d.CC.Model.Interface;

namespace k3d.CC.ViewModel.Interface
{
    public interface IUserViewModel: IDisposable
    {
        event EventHandler? LoggedIn;
        event EventHandler? LoggedOut;
        event EventHandler<UserModelChangedEventArgs>? Changed;
        event EventHandler? Registered;
        event EventHandler<ErrorEventArgs>? Error;

        void Register(string name, string password1, string password2);
        IUserModel GetUser();
        
        void Login(string name, string password);
        void Logout();

        void Rename(string newName, string password);
        void ChangePassword(string currentPassword, string newPassword, string newPasswordRepeat);
        void Delete();
    }
}
