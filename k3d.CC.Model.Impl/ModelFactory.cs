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

        public IUserModel CreateUser(string name, string password1, string password2)
        {
            throw new NotImplementedException();
        }

        public IUserModel GetUser(string name, string password)
        {
            throw new NotImplementedException();
        }

        private readonly ILogger _log;
        private readonly IDataProvider _dataProvider;
    }
}
