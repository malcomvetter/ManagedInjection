using System;
using System.Reflection;

namespace ExampleEXE
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from {0} {1}()", Assembly.GetExecutingAssembly().GetName().Name, MethodBase.GetCurrentMethod().Name);
        }
    }
}
