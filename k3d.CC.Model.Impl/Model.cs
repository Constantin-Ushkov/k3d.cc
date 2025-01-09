using k3d.CC.Data.Interface;
using k3d.CC.Model.Interface;

namespace k3d.CC.Model.Impl
{
    public class Model: IModel
    {
        public Model(IModelDataProvider dataProvider, IUserModel user)
        {
            // TODO: assert

            _dataProvider = dataProvider;
            _user = user;
        }

        private readonly IUserModel _user;
        private readonly IModelDataProvider _dataProvider;
    }
}
