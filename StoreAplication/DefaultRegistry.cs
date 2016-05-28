using StoreAplication.Interfaces.IRepositories;
using StoreAplication.Repositories;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace StoreAplication
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(scanner =>
            {
                scanner.TheCallingAssembly();
                scanner.WithDefaultConventions();
                scanner.LookForRegistries();
            });

            For<IMainRepository>().Use<MainRepository>();
        }
    }
}