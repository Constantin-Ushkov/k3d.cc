
namespace k3d.CC.Model.Interface
{
    public interface IUserModel
    {
        Guid Id { get; }
        string Name { get; }
        byte[] PasswordHash { get; }

        void Logout();
    }
}
