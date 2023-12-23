using ApplicationManagementSystem.Core.Repositories;
using ApplicationManagementSystem.Core.Utilities.Interceptors;
using ApplicationManagementSystem.Core.Utilities.Security.JWT;
using ApplicationManagementSystem.Core.Utilities.Security.JWT.Configuration;
using ApplicationManagementSystem.DataAccess.EntityFrameworkCore.Repositories;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using System.Reflection;
using Module = Autofac.Module;

namespace ApplicationManagementSystem.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Generic Repo
            builder.RegisterGeneric(typeof(Repository<,>)).As(typeof(IRepository<,>)).InstancePerDependency();
            builder.RegisterType<JwtAuthenticationManager>().As<IJwtAuthenticationManager>().SingleInstance();
            builder.RegisterType<JwtConfiguration>().As<IJwtConfiguration>().SingleInstance();



            //Aspect Oriented Programming
            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions { Selector = new AspectInterceptorSelector() })
                .InstancePerLifetimeScope();

        }
    }
}