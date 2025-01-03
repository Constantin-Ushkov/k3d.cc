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

        public IModel CreateModel()
            => new Model(_dataProvider);

        private IModelDataProvider _dataProvider;
    }
}
