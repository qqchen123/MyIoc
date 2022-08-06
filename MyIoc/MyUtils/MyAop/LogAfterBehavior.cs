using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace MyIoc.MyUtils.MyAop
{
    public class LogAfterBehavior : IInterceptionBehavior
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(typeof(LogAfterBehavior));
        public bool WillExecute => true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            log.Info("执行前");
            // 如果继续往后执行：
            IMethodReturn methodReturn = getNext()(input, getNext);

            log.Info("执行后");

            return methodReturn;
        }
    }
}