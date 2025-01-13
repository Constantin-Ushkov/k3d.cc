using k3d.CC.Data.Impl.FS.User;
using k3d.CC.Data.Interface;
using k3d.Logging.Interface;

namespace k3d.CC.Data.Impl.FS
{
    internal interface IDataFactoryInternal: IDataFactory
    {
        IUserManager CreateUserManager(ILogger log, string usersFolder);
    }
}
