
namespace k3d.CC.Data.Interface
{
    public interface IUserDataProvider
    {
        IUserData CreateUser();
        IUserData GetUser(string name);
    }
}
