using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyIoc.MyMvcFilters
{
    public class MyHandlerErrorAttribute:HandleErrorAttribute
    {
        //如果有异常跳转到这里来
        public override void OnException(ExceptionContext filterContext)
        {
            //base.OnException(filterContext);
            if (!filterContext.ExceptionHandled)
            {
                //处理异常
                //1.访问页面-返回错误页面
                //2.ajax-响应json

                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    filterContext.Result = new JsonResult()
                    {
                        Data = new
                        {
                            DebugMessage=filterContext.Exception.Message,
                            RetValue="",
                            PromptMsg="发生错误请联系管理员"
                        }
                    };
                }
                else
                {
                    filterContext.Result = new ViewResult()
                    {
                        ViewName = "~/Views/Shared/Error.cshtml",
                        ViewData = new ViewDataDictionary(filterContext.Exception.Message)
                    };
                }
            }
            //异常已经被处理了设置为true
            filterContext.ExceptionHandled = true;
        }
    }
}