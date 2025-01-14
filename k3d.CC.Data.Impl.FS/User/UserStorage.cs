using k3d.CC.Data.Interface;
using k3d.Common.Diagnostics;

namespace k3d.CC.Data.Impl.FS.User
{
    internal class UserStorage: IUserStorage
    {
        private static class Constants
        {
            public const string UserFileName = "user";
        }

        public Guid ID => _dto.Id;

        public string Name
        {
            get => _dto.Name;
            set => _dto.Name = value;
        }

        public byte[] PasswordHash
        {
            get => _dto.PasswordHash;
            set => _dto.PasswordHash = value;
        }

        public UserStorage(UserDto dto)
        {
            Assert.Argument.IsNotNull(dto, nameof(dto));
            _dto = dto;
        }

        public void Persist()
            => _dto.WriteToFile();

        public void Dispose()
        {
        }

        public static IUserStorage Create(string baseFolder, Guid id, string userName, byte[] passwordHash)
        {
            var userFolderName = UserNameToFolder(userName);
            var userFolderPath = Path.Combine(baseFolder, userFolderName);

            if (Directory.Exists(userFolderPath))
            {
                throw new DataException("Failed to create user. "
                    + $"User with the same name ({userName}) does already exists.");
            }

            Directory.CreateDirectory(userFolderPath);

            var dto = new UserDto(Path.Combine(userFolderPath, Constants.UserFileName), id, userName, passwordHash);

            dto.WriteToFile();

            return new UserStorage(dto);
        }

        public static IUserStorage? Open(string baseFolder, string userName)
        {
            var userFolderName = UserNameToFolder(userName);
            var userFolderPath = Path.Combine(baseFolder, userFolderName);
            var userFilePath = Path.Combine(userFolderPath, Constants.UserFileName);

            if (!File.Exists(userFilePath))
            {
                return null;
            }

            return new UserStorage(UserDto.ReadFromFile(userFilePath));
        }

        private static string UserNameToFolder(string userName)
            => Uri.EscapeDataString(userName);

        private static string FolderToUserName(string folder)
            => Uri.UnescapeDataString(folder);

        private readonly UserDto _dto;
    }
}
