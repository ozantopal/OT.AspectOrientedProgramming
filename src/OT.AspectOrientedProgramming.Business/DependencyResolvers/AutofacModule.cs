using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using OT.AspectOrientedProgramming.Business.Abstracts;
using OT.AspectOrientedProgramming.Business.Concretes;
using OT.AspectOrientedProgramming.CrossCutting.Interceptors;

namespace OT.AspectOrientedProgramming.Business.DependencyResolvers
{
    public class AutofacModule : Module
    {
        public AutofacModule()
        {

        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FooService>().As<IFooService>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly)
             .AsImplementedInterfaces()
              .EnableInterfaceInterceptors(new ProxyGenerationOptions()
              {
                  Selector = new AspectInterceptorSelector()
              })
              .SingleInstance();

        }
    }
}
