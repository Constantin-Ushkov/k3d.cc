using k3d.Common.Diagnostics;
using k3d.CC.Data.Interface;
using k3d.CC.Model.Interface;

namespace k3d.CC.Model.Impl
{
    internal class UserModel : IUserModel
    {
        public Guid Id => _data.ID;
        public string Name => _data.Name;
        public byte[] PasswordHash => _data.PasswordHash;

        public UserModel(IUserData data)
        {
            Assert.Argument.IsNotNull(data, nameof(data));
            _data = data;
        }

        public void Logout()
        {
            // todo: do anything?
        }

        // todo: replace with something none-static
        public static IUserModel Register(IDataProvider storage, IHashingProvider hasher, string name, string password1, string password2)
        {
            if (storage.Users.GetUser(name) is not null)
            {
                throw new ModelException($"Failed to register. User with name {name} is already exists.");
            }

            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                throw new ModelException($"Failed to register. Password should not be empty.");
            }

            if (password1 != password2)
            {
                throw new ModelException($"Failed to register. Password missmatch.");
            }

            var data = storage.Users.CreateUser(name, hasher.GetHash(password1));
            data.Persist();

            return new UserModel(data);
        }

        public static IUserModel Login(IDataProvider storage, IHashingProvider hasher, string name, string password)
        {
            var data = storage.Users.GetUser(name);

            if (data is null)
            {
                throw new ModelException($"Failed to login. User with name {name} was not found.");
            }

            if (!data.PasswordHash.SequenceEqual(hasher.GetHash(password)))
            {
                throw new ModelException("Failed to login. Password missmatch.");
            }

            return new UserModel(data);
        }

        private readonly IUserData _data;
    }
}
