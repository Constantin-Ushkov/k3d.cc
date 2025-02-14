using k3d.CC.Data.Impl.FS;
using k3d.CC.Model.Impl;
using k3d.CC.View.WinForms.Configuration;
using k3d.CC.ViewModel.Impl;

namespace k3d.CC.View.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var config = AppConfig.FromExeConfigFile();
            var logging = Logging.Impl.Factory.CreateLoggingService();

            var dataFactory = new DataFactory(config.DataConfiguration, logging.Loggers.GetLogger("data", ""));
            var storage = dataFactory.CreateDataProvider();

            var hasher = new SHA256Hasher();
            var modelFactory = new ModelFactory(logging.Loggers.GetLogger("model", ""), storage, hasher);
            var viewModelFactory = new ViewModelFactory(logging.Loggers.GetLogger("view-model", ""), modelFactory);

            Application.Run(new MainForm(viewModelFactory.CreateMainView()));
        }
    }
}