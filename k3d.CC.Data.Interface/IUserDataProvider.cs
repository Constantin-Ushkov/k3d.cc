
namespace k3d.CC.Data.Interface
{
    public interface IUserDataProvider
    {
        IUserData CreateUser(Guid id, string name, byte[] passwordHash);
        IUserData? GetUser(string name);
    }
}
