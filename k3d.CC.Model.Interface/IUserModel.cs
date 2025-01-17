
namespace k3d.CC.Model.Interface
{
    public interface IUserModel
    {
        event EventHandler<UserModelChangedEventArgs>? Changed;

        Guid Id { get; }
        string Name { get; }
        byte[] PasswordHash { get; }

        void Logout();
        void Rename(string newName, string password);
        void ChangePassword(string newPassword, string newPasswordRepeat, string oldPassword);
    }
}
