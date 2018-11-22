using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TreinamentoXunit.Domain;
using TreinamentoXunit.Services;

namespace TreinamentoXunit.WebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ConfigureContainer(container =>
            {
                ConfiguracaoIoCServices.Configure(container);
            });
        }

        private static void ConfigureContainer(Action<Container> containerConfig)
        {
            Factory.Container = new Container();
            Factory.Container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            containerConfig(Factory.Container);
            Factory.Container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            Factory.Container.RegisterMvcIntegratedFilterProvider();
            Factory.Container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(Factory.Container));
        }
    }
}
