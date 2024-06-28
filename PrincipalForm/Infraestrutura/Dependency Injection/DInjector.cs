using Autofac;
using Negocio.Bussines.Login.Interfaces;
using Negocio.Bussines.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestrutura.Generic_DAL;
using Negocio.Bussines.Login.DAL;
using Negocio.Bussines.Login.Model;
using Infraestrutura.Factory;

namespace Sistema.Infraestrutura.Dependency_Injection
{
    public static class DInjector
    {
        public static IContainer Container { get; private set; }

        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterInstance(DbConnectionFactory.Instance).AsSelf();

            builder.RegisterGeneric(typeof(GenericDAO<>)).AsSelf();

            builder.RegisterType<LoginDao>().AsSelf();
            builder.RegisterType<LoginBis>().As<ILoginBis>();

            Container = builder.Build();
        }
    }
}
