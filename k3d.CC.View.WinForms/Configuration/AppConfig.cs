using k3d.Common.Diagnostics;
using IDataConfiguration = k3d.CC.Data.Impl.FS.IConfiguration;

namespace k3d.CC.View.WinForms.Configuration
{
    internal class AppConfig: IApplicationConfiguration
    {
        public IDataConfiguration DataConfiguration { get; }

        public AppConfig(IDataConfiguration dataConfig)
        {
            Assert.Argument.IsNotNull(dataConfig, nameof(dataConfig));

            DataConfiguration = dataConfig;
        }

        public static IApplicationConfiguration FromAppConfig()
            => new AppConfig(DataConfig.FromAppConfig());
    }
}
