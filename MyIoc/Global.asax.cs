using MyIoc.MyUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MyIoc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //定义自己的控制器工厂
            ControllerBuilder.Current.SetControllerFactory(new MyControllerFactory());

            //log4net
            log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/ConfigFiles/log4net.config")));
        }
    }
}
