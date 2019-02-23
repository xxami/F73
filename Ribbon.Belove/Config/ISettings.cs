namespace Ribbon.Belove.Config
{
    using System.IO;

    public interface ISettings
    {
        string ProfileName { get; set; }
        Resolution Resolution { get; set; }
    }
}