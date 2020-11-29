using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using Vic.SportsStore.WebApp.Infrastrature.Abstract;
using Vic.SportsStore.WebApp.Infrastrature.Concrete;


namespace Vic.SportsStore.WebApp
{
    public class IocConfig
    {
        public static void ConfigIoc()
        {
            var builder = new ContainerBuilder();

            //builder
            //    .RegisterControllers(typeof(MvcApplication).Assembly)
            //    .PropertiesAutowired();

            //builder
            //    .RegisterInstance<IProductsRepository>(new EFProductRepository())
            //    .PropertiesAutowired();

            //builder
            //    .RegisterInstance<IOrderProcessor>(new EmailOrderProcessor(new EmailSettings()))
            //    .PropertiesAutowired();

            builder
                .RegisterInstance<IAuthProvider>(new FormsAuthProvider())
                .PropertiesAutowired();

            //builder
            //    .RegisterInstance(new EFDbContext())
            //    .PropertiesAutowired();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}