using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using ConfigOptions.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Options;
using System.IO;
using ConfigOptions.Infrastructure.Extensions;
using ConfigOptions.Infrastructure.Configurations.Mailing;
using ConfigOptions.Infrastructure.Configurations.Feed;

namespace ConfigOptions
{
    public class DiContainer
    {
        public static IContainer Setup()
        {
            var configurationBuilder = new ConfigurationBuilder()
               //.SetBasePath(Path.Combine("./", "configs"))
               .AddJsonFile($"{Path.Combine("./", "configs")}/settings.json", optional: false);
            var configuration = configurationBuilder.Build();


            



            var builder = new ContainerBuilder();
            builder.RegisterOptions();
            builder.RegisterConfigurationOptions<MailingOptions>(configuration.GetSection("mailing"));
            builder.RegisterConfigurationOptions<FeedOptions>(configuration.GetSection("feed"));
            builder.RegisterType<Application>().As<IApplication>();

            return builder.Build();
        }
    }
}
