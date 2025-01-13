using IDataConfiguration = k3d.CC.Data.Impl.FS.IConfiguration;

namespace k3d.CC.View.WinForms.Configuration
{
    internal class DataConfig : IDataConfiguration
    {
        public string BaseFolder => throw new NotImplementedException();

        public static IDataConfiguration FromAppConfig()
        {
        }
    }
}
