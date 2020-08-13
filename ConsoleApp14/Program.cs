using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Threading;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Running {typeof(string).Assembly.Location}");
                Thread.Sleep(10000);
            }
        }
    }
}
