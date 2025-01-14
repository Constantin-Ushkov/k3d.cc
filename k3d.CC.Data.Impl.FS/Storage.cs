﻿using k3d.CC.Data.Impl.FS.User;
using k3d.CC.Data.Interface;
using k3d.Common.Diagnostics;
using k3d.Logging.Interface;

namespace k3d.CC.Data.Impl.FS
{
    internal sealed class Storage: IDataProvider
    {
        #region Explicit IDataProvider Impl

        IUserDataProvider IDataProvider.Users => Users;

        #endregion // Explicit IDataProvider Impl

        public IUserManager Users { get; }

        public Storage(IConfiguration configuration, ILogger log)
        {
            Assert.Argument.IsNotNull(configuration, nameof(configuration));
            Assert.Argument.IsNotNull(log, nameof(log));

            _configuration = configuration;
            _log = log;

            Users = new UserManager(_log, Path.Combine(_configuration.BaseFolder, Constants.Folders.Users));
        }

        public IUserData CreateUser()
        {
            throw new NotImplementedException();
        }

        public IUserData GetUser(string name)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            Users.Dispose();

            _disposed = true;
        }

        private bool _disposed;
        private readonly ILogger _log;
        private readonly IConfiguration _configuration;
    }
}
