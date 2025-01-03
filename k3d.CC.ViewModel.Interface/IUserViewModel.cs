
namespace k3d.CC.ViewModel.Interface
{
    public interface IUserViewModel
    {
        event EventHandler LoggedIn;
        event EventHandler LoggedOut;
        event EventHandler Changed;
        // event Error; ???
        
        void Login(string name, string password);
        void Logout();

        void Delete();
        void Update(string? newName, string? newPassword1, string? newPassword2);
    }
}
