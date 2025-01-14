using System.Configuration;
using IDataConfiguration = k3d.CC.Data.Impl.FS.IConfiguration;

namespace k3d.CC.View.WinForms.Configuration
{
    internal class DataConfig : IDataConfiguration
    {
        private static class Constants
        {
            public const string Prefix = "Data";
            public const string BaseFolder = "BaseFolder";
        }

        public string BaseFolder { get; private set; }

        public DataConfig(string baseFolder)
        {
            BaseFolder = baseFolder;
        }

        public static IDataConfiguration FromAppConfig()
            => new DataConfig(ConfigurationManager.AppSettings[$"{Constants.Prefix}.{Constants.BaseFolder}"]!);
    }
}
