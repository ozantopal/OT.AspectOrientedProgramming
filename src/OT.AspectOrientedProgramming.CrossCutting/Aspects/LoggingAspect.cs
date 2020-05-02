using Castle.DynamicProxy;
using OT.AspectOrientedProgramming.CrossCutting.Interceptors;
using System;

namespace OT.AspectOrientedProgramming.CrossCutting.Aspects
{
    public class LoggingAspect : MethodInterception
    {
        public LoggingAspect()
        {

        }

        protected override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("LoggingAspect.OnBefore() executed");
        }

        protected override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("LoggingAspect.OnAfter() executed");
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            Console.WriteLine("LoggingAspect.OnSuccess() executed");
        }

        protected override void OnException(IInvocation invocation)
        {
            Console.WriteLine("LoggingAspect.OnException() executed");
        }
    }
}
