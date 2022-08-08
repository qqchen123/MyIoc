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

            //�����Լ��Ŀ���������
            //ControllerBuilder.Current.SetControllerFactory(new MyControllerFactory());

            DependencyResolver.SetResolver(new MydependencyResolver(MyDIFactory.getContainer()));

            //log4net
            log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/ConfigFiles/log4net.config")));
        }

        /// <summary>
        /// ֻҪ��Ӧ����200�ͻᱻ���ﲶ׽��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        protected void Application_Error(object sender,EventArgs eventArgs)
        {
            Exception exception = Server.GetLastError();
            Response.Write("System is Error...");
            Server.ClearError();
        }
    }
}
