using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace MyIoc.MyUtils
{
    public class MydependencyResolver : IDependencyResolver
    {
        private IUnityContainer container;

        public MydependencyResolver(IUnityContainer container)
        {
            this.container = container;
        }
        public object GetService(Type serviceType)
        {
            //throw new NotImplementedException();
            try
            {
                return container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                //额外操作，如日志
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            //throw new NotImplementedException();
            try
            {
                return container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                //额外操作，如日志
                return Enumerable.Empty<object>();
            }
        }
    }
}