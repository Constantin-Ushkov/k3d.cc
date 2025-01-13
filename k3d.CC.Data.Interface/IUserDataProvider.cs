
namespace k3d.CC.Data.Interface
{
    public interface IUserDataProvider
    {
        IUserData CreateUser(string name, byte[] passwordHash);
        IUserData GetUser(string name);
    }
}
