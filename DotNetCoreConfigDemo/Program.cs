using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreConfigDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                 .AddJsonFile("appsetting.json", false, true)
                 .Build();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddOptions();
            serviceCollection.Configure<MyConfig>(config);
            var services = serviceCollection.BuildServiceProvider();

            while (true)
            {
                var myConfig = services.GetService<IOptionsMonitor<MyConfig>>();
                Task.Delay(1000).Wait();
                Console.WriteLine(myConfig.CurrentValue.Age);
            }
        }
    }
}