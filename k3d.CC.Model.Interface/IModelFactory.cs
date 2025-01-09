
namespace k3d.CC.Model.Interface
{
    public interface IModelFactory
    {
        IUserModel CreateUser(string name, string password1, string password2);
        IUserModel GetUser(string name, string password);

        IModel CreateModel(IUserModel user);
    }
}
