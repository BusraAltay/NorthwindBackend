using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor//abstract'ı biz yazdık
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)//virtual'ı biz koyduk
        {

        }
    }
}
