using System;
using System.Reflection;

namespace ManagedInjection
{
    public static class ManagedInjection
    {
        public static void Inject(string assemblyB64)
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
