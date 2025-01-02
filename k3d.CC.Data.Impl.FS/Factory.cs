using k3d.CC.Data.Interface;

namespace k3d.CC.Data.Impl.FS
{
    public class Factory
    {
        public static IDataProvider CreateDataProvider()
            => new DataProvider();
    }
}
