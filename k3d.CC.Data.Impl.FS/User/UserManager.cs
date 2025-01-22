using k3d.CC.Data.Interface;
using k3d.Common.Diagnostics;
using k3d.Logging.Interface;

namespace k3d.CC.Data.Impl.FS.User
{
    internal class UserManager : IUserManager
    {
        public UserManager(ILogger log, string baseFolder)
        {
            Assert.Argument.IsNotNull(log, nameof(log));
            Assert.Argument.IsNotNullOrEmpty(baseFolder, nameof(baseFolder));

            _log = log;
            _baseFolder = baseFolder;
        }

        public IUserData CreateUser(Guid id, string name, byte[] passwordHash)
        {
            var user = UserStorage.Create(_baseFolder, id, name, passwordHash);

            CacheUser(user);

            return user;
        }

        public IUserData? GetUser(string name)
        {
            var user = GetUserFromCache(name);

            if (user is not null)
            {
                return user;
            }

            user = GetUserFromDisk(name);

            if (user is not null)
            {
                CacheUser(user);
            }

            return user;
        }

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            lock (_usersSyncObject)
            {
                foreach (var user in _users.Values)
                {
                    user.Dispose();
                }
            }

            _disposed = true;
        }

        private IUserStorage? GetUserFromCache(string name)
        {
            lock (_usersSyncObject)
            {
                return _users.TryGetValue(name, out var user) ? user : null;
            }
        }

        private void CacheUser(IUserStorage user)
        {
            lock (_usersSyncObject)
            {
                if (_users.ContainsKey(user.Name))
                {
                    throw new DataException(
                        $"Failed to cache user. User with name '{user.Name}' is already cached.");
                }

                user.NameChanged += (sender, args) =>
                {
                    lock (_usersSyncObject)
                    {
                        _users.Remove(args.OldName);
                        _users.Add(user.Name, user);
                    }
                };

                _users.Add(user.Name, user);
            }
        }

        private IUserStorage? GetUserFromDisk(string name)
            => UserStorage.Open(_baseFolder, name);

        private bool _disposed;
        private readonly ILogger _log;
        private readonly string _baseFolder;
        private readonly object _usersSyncObject = new();
        private readonly Dictionary<string, IUserStorage> _users = [];
    }
}
