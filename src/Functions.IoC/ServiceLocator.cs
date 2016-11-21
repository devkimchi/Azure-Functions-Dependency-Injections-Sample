using Autofac;
using Autofac.Extras.CommonServiceLocator;

using Functions.Mappers;
using Functions.Services;

using Microsoft.Practices.ServiceLocation;

namespace Functions.IoC
{
    /// <summary>
    /// This represents the service locator entity.
    /// </summary>
    public class ServiceLocator
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ServiceLocator"/> class.
        /// </summary>
        public ServiceLocator()
        {
            this.Build();
        }

        /// <summary>
        /// Gets the <see cref="IServiceLocator"/> instance.
        /// </summary>
        public IServiceLocator Instance { get; private set; }

        private void Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MapperFactory>().As<IMapperFactory>().InstancePerDependency();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerDependency();

            var container = builder.Build();

            var csl = new AutofacServiceLocator(container);

            Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(() => csl);

            this.Instance = Microsoft.Practices.ServiceLocation.ServiceLocator.Current;
        }
    }
}
