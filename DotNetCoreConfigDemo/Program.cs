using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace DotNetCoreConfigDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myConfig = new MyConfig();
            new ConfigurationBuilder()
                .AddJsonFile("appsetting.json")
                .Build()
                .Bind(myConfig);
        }
    }
}