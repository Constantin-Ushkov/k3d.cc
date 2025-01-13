using k3d.CC.Data.Interface;
using k3d.Common.Diagnostics;
using k3d.Logging.Interface;

namespace k3d.CC.Data.Impl.FS
{
    public class DataFactory
    {
        public DataFactory(IConfiguration configuration, ILogger log)
        {
            Assert.Argument.IsNotNull(configuration, nameof(configuration));
            Assert.Argument.IsNotNull(log, nameof(log));

            _configuration = configuration;
            _log = log;
        }

        public IDataProvider CreateDataProvider()
            => new Storage(_configuration, _log);

        private readonly ILogger _log;
        private readonly IConfiguration _configuration;
    }
}
