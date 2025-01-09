using k3d.CC.Data.Interface;
using k3d.CC.Model.Interface;

namespace k3d.CC.Model.Impl
{
    public class ModelFactory: IModelFactory
    {
        public ModelFactory(IModelDataProvider dataProvider)
        {
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

        private IModelDataProvider _dataProvider;
    }
}
