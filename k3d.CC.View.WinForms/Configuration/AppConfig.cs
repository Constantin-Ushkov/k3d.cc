using k3d.Common.Diagnostics;
using System.Text.Json;
using IDataConfiguration = k3d.CC.Data.Impl.FS.IConfiguration;

namespace k3d.CC.View.WinForms.Configuration
{
    internal class AppConfig: IApplicationConfiguration
    {
        internal class Dto
        {
            public DataConfig.Dto DataConfig { get; set; }
        }

        public IDataConfiguration DataConfiguration { get; }

        public AppConfig(Dto dto)
        {
            Assert.Argument.IsNotNull(dto, nameof(dto));

            _dto = dto;

            DataConfiguration = new DataConfig(dto.DataConfig);
        }

        public void SaveToFile(string file)
        {
            var json = JsonSerializer.Serialize(_dto,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(file, json);
        }

        public static IApplicationConfiguration FromExeConfigFile()
        {
            var path = System.Environment.ProcessPath + ".cfg";

            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Configuration file ({path}) was not found.");
            }

            var text = File.ReadAllText(path);
            var dto = JsonSerializer.Deserialize<Dto>(text);

            if (dto is null)
            {
                throw new ControlCenterException($"Failed to deserialize {nameof(Dto)}.");
            }

            return new AppConfig(dto);
        }

        public static IApplicationConfiguration CreateDefault()
        {
            var dto = new Dto
            {
                DataConfig = DataConfig.Dto.CreateDefault()
            };

            return new AppConfig(dto);
        }

        private readonly Dto _dto;
    }
}
