using k3d.CC.Data.Interface;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace k3d.CC.Data.Impl.FS.User
{
    internal class UserDto
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = [];

        [JsonIgnore]
        public string File { get; set; } = string.Empty;

        public UserDto(string file, Guid id, string name, byte[] passwordHash)
        {
            File = file;
            Id = id;
            Name = name;
            PasswordHash = passwordHash;
        }

        public UserDto()
        {
        }

        public void WriteToFile()
        {
            var json = JsonSerializer.Serialize(this,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            System.IO.File.WriteAllText(File, json);
        }

        public static UserDto ReadFromFile(string file)
        {
            var json = System.IO.File.ReadAllText(file);

            var dto = JsonSerializer.Deserialize<UserDto>(json)
                ?? throw new DataException($"Failed to deserialize {nameof(UserDto)}.");

            dto.File = file;

            return dto;
        }
    }
}
