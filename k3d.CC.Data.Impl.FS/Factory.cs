using k3d.CC.Data.Interface;

namespace k3d.CC.Data.Impl.FS
{
    public class Factory
    {
        public static IModelDataProvider CreateDataProvider()
            => new DataProvider();
    }
}
