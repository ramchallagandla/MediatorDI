using StructureMap;

namespace MediatorDI.Registries
{
    public class BaseRegistry: Registry
    {
        public BaseRegistry()
        {
            For<IMediator>().Use<Mediator>();
        } 
    }
}
