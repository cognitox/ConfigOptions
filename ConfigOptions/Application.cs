using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigOptions.Infrastructure.Interfaces;

namespace ConfigOptions
{
    public class Application: IApplication
    {
        public void Run() {
            Console.WriteLine("Running.....");
        }
    }
}
