using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Unity;

namespace MyIoc.MyUtils
{
    public class MyControllerFactory:DefaultControllerFactory
    {
        //创建控制器
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            return base.CreateController(requestContext, controllerName);
        }

        // 控制器实例--选择构造函数--支持在构造控制器实例的时候，支持依赖注入--必须要使用ioc容器；
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            //return base.GetControllerInstance(requestContext, controllerType);
            IUnityContainer container = MyDIFactory.getContainer();
            object oInstance = container.Resolve(controllerType);
            return (IController)oInstance;
        }
    }
}