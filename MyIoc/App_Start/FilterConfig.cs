using System.Web;
using System.Web.Mvc;
using MyIoc.MyMvcFilters;

namespace MyIoc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //全局注册过滤器
            //filters.Add(new MyIndexActionFilter());
            filters.Add(new MyHandlerErrorAttribute());
        }
    }
}
