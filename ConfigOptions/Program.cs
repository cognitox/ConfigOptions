using Autofac;
using ConfigOptions.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = DiContainer.Setup();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
