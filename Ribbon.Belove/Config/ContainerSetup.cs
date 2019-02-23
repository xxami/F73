namespace Ribbon.Belove.Config
{
    using System.IO;
    using System.IO.Abstractions;
    using MicroResolver;

    public class ContainerSetup
    {
        public ContainerSetup()
        {
            var resolver = ObjectResolver.Create();
            resolver.Register<IFileSystem, FileSystem>();
            resolver.Register<ISettings, Settings>(Lifestyle.Singleton);

            resolver.Compile();
        }
    }
}