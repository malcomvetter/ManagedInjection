using System;
using System.Reflection;

namespace ExampleDLL
{
    public class Class1
    {
        public Class1 ()
        {
            Console.WriteLine("Hello from {0} Constructor", Assembly.GetExecutingAssembly().GetName().Name);
        }

        public void Main(string[] args)
        {
            Console.WriteLine("Hello from {0} {1}()", Assembly.GetExecutingAssembly().GetName().Name, MethodBase.GetCurrentMethod().Name);
        }
    }
}
