using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreConfigDemo
{
    public class MyConfig
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address address { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
    }
}