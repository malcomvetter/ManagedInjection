using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Injector
{
    public class Injector
    {
        public Injector() { }

        public void Inject(string assemblyB64)
        {
            var bytes = Convert.FromBase64String(assemblyB64);
            var assembly = Assembly.Load(bytes);

            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine("[*] Loaded Type {0}", type);
                object instance = Activator.CreateInstance(type);
                object[] args = new object[] { new string[] { "" } };
                try
                {
                    type.GetMethod("Main").Invoke(instance, args);
                }
                catch { }
            }
        }
    }
}
