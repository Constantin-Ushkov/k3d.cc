﻿using k3d.CC.Data.Interface;
using k3d.Common.Diagnostics;
using k3d.Logging.Interface;

namespace k3d.CC.Data.Impl.FS
{
    internal class DataProvider: IDataProvider
    {
        public DataProvider(ILogger log)
        {
            Assert.Argument.IsNotNull(log, nameof(log));
            _log = log;
        }

        private readonly ILogger _log;
    }
}
