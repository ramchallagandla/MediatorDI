namespace MediatorDI
{
    using StructureMap;
    public class Ioc
    {
        private static Container _container;
        private Ioc() { }

        public static Container Container {
            get
            {
                if (_container == null)
                    _container = Bootstrap();

                    return _container;
            }
        }
        
        private static Container Bootstrap()
        {
            return new Container(_ =>
            {
                _.Scan(x =>
                {
                    x.AssembliesAndExecutablesFromApplicationBaseDirectory();
                    x.LookForRegistries();
                    x.ConnectImplementationsToTypesClosing(typeof(IRequestHandler<,>));
                });                
            });
        }
    }
}
