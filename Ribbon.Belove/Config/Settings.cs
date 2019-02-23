namespace Ribbon.Belove.Config
{
    using Reader;

    public class Settings : ISettings
    {
        private const string SettingsFile = "settings.yaml";
        public string ProfileName { get; set; }
        public Resolution Resolution { get; set; }

        public Settings(IConfigReader reader)
        {
            var settings = reader.Read<Settings>(SettingsFile);
            ProfileName = settings.ProfileName;
            Resolution = settings.Resolution;
        }
    }

    public class Resolution
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}