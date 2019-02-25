
using System.Net.Mime;
using System.Reflection.Metadata;

namespace Ribbon.Belove.Config.Reader
{
    using System.IO;
    using System.IO.Abstractions;
    using SharpYaml;
    using SharpYaml.Serialization;

    public class ConfigReader : IConfigReader
    {
        private readonly IFileSystem _iosys;

        public ConfigReader(IFileSystem iosys)
        {
            _iosys = iosys;
        }

        public T Read<T>(string configName)
        {
            using (var input = _iosys.File.OpenRead(configName))
            {
                var serializer = new Serializer(new SerializerSettings { NamingConvention = new FlatNamingConvention() });
                using (var reader = new StreamReader(input))
                {
                    var text = reader.ReadToEnd();
                    var config = serializer.Deserialize<T>(text);
                    return config;
                }
            }
        }
    }
}
