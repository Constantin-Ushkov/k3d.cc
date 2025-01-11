using k3d.CC.Data.Interface;
using k3d.CC.Model.Interface;
using k3d.Common.Diagnostics;
using k3d.Logging.Interface;

namespace k3d.CC.Model.Impl
{
    public class ModelFactory: IModelFactory
    {
        public ModelFactory(ILogger log, IDataProvider dataProvider)
        {
            Assert.Argument.IsNotNull(log, nameof(log));
            Assert.Argument.IsNotNull(dataProvider, nameof(dataProvider));

            _log = log;
            _dataProvider = dataProvider;
        }

        public IModel CreateModel(IUserModel user)
            => new Model(_dataProvider, user);

        public IUserModel Register(string name, string password1, string password2)
            => UserModel.Register(_dataProvider, name, password1, password2);

        public IUserModel Login(string name, string password)
            => UserModel.Login(_dataProvider, name, password);

        private readonly ILogger _log;
        private readonly IDataProvider _dataProvider;
    }
}
