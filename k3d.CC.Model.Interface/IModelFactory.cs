
namespace k3d.CC.Model.Interface
{
    public interface IModelFactory
    {
        IUserModel Register(string name, string password1, string password2);
        IUserModel Login(string name, string password);

        IModel CreateModel(IUserModel user);
    }
}
