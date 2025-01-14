
namespace k3d.CC.Data.Impl.FS.User
{
    internal class UserDto
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string File { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = [];

        public UserDto(string file, Guid id, string name, byte[] passwordHash)
        {
            File = file;
            Id = id;
            Name = name;
            PasswordHash = passwordHash;
        }

        public void WriteToFile()
        {
            //
        }

        public static UserDto ReadFromFile(string file)
        {
            //
        }
    }
}
