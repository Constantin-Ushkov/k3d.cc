using k3d.Common.Diagnostics;
using k3d.CC.Data.Interface;
using k3d.CC.Model.Interface;

namespace k3d.CC.Model.Impl
{
    internal class UserModel : IUserModel
    {
        public event EventHandler<UserModelChangedEventArgs>? Changed;

        public Guid Id => _data.ID;
        public string Name => _data.Name;
        public byte[] PasswordHash => _data.PasswordHash;

        public UserModel(IUserData data, IHashingProvider hasher)
        {
            Assert.Argument.IsNotNull(data, nameof(data));
            Assert.Argument.IsNotNull(hasher, nameof(hasher));

            _data = data;
            _hasher = hasher;
        }

        public void Logout()
        {
            // todo: do anything?
        }

        public void Rename(string newName, string password)
        {
            if (newName == _data.Name)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ModelException($"Failed to rename the user ({_data.Name} => {newName}). Name should not be empty.");
            }

            if (!IsValidPassword(password))
            {
                throw new ModelException($"Failed to rename the user ({_data.Name} => {newName}). Invalid password.");
            }

            _data.Rename(newName);

            Changed?.Invoke(this, new UserModelChangedEventArgs(UserModelField.Name));
        }

        public void ChangePassword(string newPassword, string newPasswordRepeat, string oldPassword)
        {
            if (newPassword == oldPassword)
            {
                return;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                throw new ModelException($"Failed to change password. Password can not be empty string.");
            }

            if (!IsValidPassword(oldPassword))
            {
                throw new ModelException($"Failed to change password. Invalid old password.");
            }

            if (newPassword != newPasswordRepeat)
            {
                throw new ModelException($"Failed to change password. Invalid new password.");
            }

            _data.PasswordHash = _hasher.GetHash(newPassword);
            _data.Persist();

            Changed?.Invoke(this, new UserModelChangedEventArgs(UserModelField.Password));
        }

        private bool IsValidPassword(string password)
            => _data.PasswordHash.SequenceEqual(_hasher.GetHash(password));

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

            var data = storage.Users.CreateUser(Guid.NewGuid(), name, hasher.GetHash(password1));
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
        private readonly IHashingProvider _hasher;
    }
}
