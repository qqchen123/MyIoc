using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyIoc.MyMvcFilters
{
    public class MyIndexActionFilter:ActionFilterAttribute
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(MyIndexActionFilter));
        /// <summary>
        /// 在方法执行前
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log.Info("--OnActionExecuting--");
        }

        /// <summary>
        /// 在方法执行后
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log.Info("--OnActionExecuted--");
        }

        /// <summary>
        /// 在结果执行前
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log.Info("--OnResultExecuting--");
        }

        /// <summary>
        /// 在结果执行后
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log.Info("--OnResultExecuted--");
        }
    }
}