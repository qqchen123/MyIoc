using MyIoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyIoc.MyMvcFilters
{
    public class MyAuthorizeFilterAttribute:AuthorizeAttribute
    {
        private string _LoginUrl = null;

        public MyAuthorizeFilterAttribute(string loginUrl="~/Login/Index")
        {
            this._LoginUrl = loginUrl;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //base.OnAuthorization(filterContext);

            HttpContextBase httpContext = filterContext.HttpContext;
            if (filterContext.ActionDescriptor.IsDefined(typeof(MyAllowAnonynousAttribute), true))
            {
                return;
            }
            else if (filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(MyAllowAnonynousAttribute), true))
            {
                return;
            }
            else if (httpContext.Session["CurrentUser"] == null || !(httpContext.Session["CurrentUser"] is CurrentUser))
            {
                if (httpContext.Request.IsAjaxRequest())
                {
                    filterContext.Result = new JsonResult()
                    {
                        Data = new
                        {
                            DebugMessage="登录过期",
                            RetValue=""
                        }
                    };
                }
                else
                {
                    httpContext.Session["CurrentUrl"] = httpContext.Request.Url.AbsoluteUri;
                    filterContext.Result = new RedirectResult(this._LoginUrl);
                    //短路器：指定了Result，那么请求就截止了，不会执行action
                }
            }
            else
            {
                CurrentUser user = (CurrentUser)httpContext.Session["CurrentUser"];
                return;
            }
        }
    }
}