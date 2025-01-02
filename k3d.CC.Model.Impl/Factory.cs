using k3d.CC.Data.Interface;
using k3d.CC.Model.Interface;

namespace k3d.CC.Model.Impl
{
    public class Factory
    {
        public static IModel CreateModel(IDataProvider dataProvider)
            => new Model(dataProvider);
    }
}
