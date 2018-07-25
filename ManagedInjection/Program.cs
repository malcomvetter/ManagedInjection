using System;
using System.Collections.Generic;
using System.IO;

namespace ManagedInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblies = new List<string> { "ExampleDLL.dll", "ExampleEXE.exe" };
            foreach (var assembly in assemblies)
            {
                var bytes = File.ReadAllBytes(assembly);
                var b64 = Convert.ToBase64String(bytes);
                ManagedInjection.Inject(b64);
            }
            Console.ReadKey();
        }
    }
}
