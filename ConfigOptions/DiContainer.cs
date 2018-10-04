using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using ConfigOptions.Infrastructure.Interfaces;

namespace ConfigOptions
{
    public class DiContainer
    {
        public static IContainer Setup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();

            return builder.Build();
        }
    }
}
