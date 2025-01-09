
using k3d.CC.Model.Interface;

namespace k3d.CC.ViewModel.Interface
{
    public interface IUserViewModel
    {
        event EventHandler? LoggedIn;
        event EventHandler? LoggedOut;
        event EventHandler? Changed;
        event EventHandler? UserCreated;
        event EventHandler<ErrorEventArgs>? Error;

        void CreateUser(string name, string password1, string password2);
        IUserModel GetUser();
        
        void Login(string name, string password);
        void Logout();

        void Delete();
        void Update(string? newName, string? newPassword1, string? newPassword2);
    }
}
