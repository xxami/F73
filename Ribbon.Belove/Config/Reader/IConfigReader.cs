namespace Ribbon.Belove.Config.Reader
{
    using System.IO;

    public interface IConfigReader
    {
        T Read<T>(string configName);
    }
}