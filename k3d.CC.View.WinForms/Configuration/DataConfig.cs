using IDataConfiguration = k3d.CC.Data.Impl.FS.IConfiguration;

namespace k3d.CC.View.WinForms.Configuration
{
    internal class DataConfig : IDataConfiguration
    {
        public class Dto
        {
            public string BaseFolder { get; set; } = string.Empty;

            public static Dto CreateDefault()
                => new Dto();
        }

        public string BaseFolder => _dto.BaseFolder;

        public DataConfig(Dto dto)
        {
            _dto = dto;
        }

        private readonly Dto _dto;
    }
}
