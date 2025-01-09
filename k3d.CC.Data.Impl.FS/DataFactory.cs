﻿using k3d.CC.Data.Interface;
using k3d.Common.Diagnostics;
using k3d.Logging.Interface;

namespace k3d.CC.Data.Impl.FS
{
    public class DataFactory
    {
        public DataFactory(ILogger log)
        {
            Assert.Argument.IsNotNull(log, nameof(log));
            _log = log;
        }

        public IDataProvider CreateDataProvider()
            => new DataProvider(_log);

        private readonly ILogger _log;
    }
}
