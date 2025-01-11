namespace k3d.CC.Data.Interface
{
    public interface IDataProvider
    {
        IUserData CreateUser();
        IUserData GetUser(string name);
    }
}
