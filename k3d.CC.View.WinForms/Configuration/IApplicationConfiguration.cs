using IDataConfiguration = k3d.CC.Data.Impl.FS.IConfiguration;

namespace k3d.CC.View.WinForms.Configuration
{
    internal interface IApplicationConfiguration
    {
        IDataConfiguration DataConfiguration { get; }

        void SaveToFile(string file);
    }
}
