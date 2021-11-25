using Autofac.Integration.Web;
using System;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebFormClient
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        static IContainerProvider _ContainerProvider;

        public IContainerProvider ContainerProvider
        {
            get { return _ContainerProvider; }
        }
        void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}