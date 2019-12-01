using Autofac;

namespace Rock.Etc.Hat.Platform.Core
{
    public interface IPlatform
    {
        void Initialization(ContainerBuilder builder);
    }
}