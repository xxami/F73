namespace Ribbon.Belove.Config
{
    using Reader;

    public class Settings : ISettings
    {
        public RootSetting Root { get; set; }

        public Settings(IConfigReader reader, string settingsFile)
        {
            Root = reader.Read<RootSetting>(settingsFile);
        }
    }

    public class RootSetting
    {
        public string ProfileName { get; set; }
        public Resolution Resolution { get; set; }
    }

    public class Resolution
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
