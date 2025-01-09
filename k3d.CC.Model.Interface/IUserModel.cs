
namespace k3d.CC.Model.Interface
{
    public interface IUserModel
    {
        Guid Id { get; }
        string Name { get; }
        string PasswordHash { get; }

        void Logout();
    }
}
