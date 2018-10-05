using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigOptions.Infrastructure.Configurations.Feed;
using ConfigOptions.Infrastructure.Interfaces;
using Microsoft.Extensions.Options;

namespace ConfigOptions
{
    public class Application: IApplication
    {
        public FeedOptions _feedOptions { get; set; }
        public Application(IOptions<FeedOptions> feed)
        {
            _feedOptions = feed.Value;
        }
        public void Run() {
            
            Console.WriteLine("Running.....");

            foreach (var item in _feedOptions.Endpoints)
            {
                Console.WriteLine(item.Url);
            }
        }
    }
}
