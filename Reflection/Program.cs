using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly =  Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine(t.FullName);
                Attribute? attr = t.GetCustomAttribute(typeof(AuthorAttribute));
                if (attr != null)
                    Console.WriteLine(attr.ToString());

                PropertyInfo[] psi = t.GetProperties();
                foreach (PropertyInfo pi in psi)
                { 
                    Console.WriteLine("\tproperty type {0} property name {1}",
                        pi.PropertyType.Name, pi.Name);

                }
                MethodInfo[] msi = t.GetMethods(); 
                foreach(MethodInfo mi in msi)
                {
                    if (mi.IsPublic)
                    {
                        Attribute? ma = mi.GetCustomAttribute(typeof(LabelAttribute));
                        if (ma != null) 
                            Console.WriteLine("\t{0} public {1} {2}()", 
                                ((LabelAttribute)ma).Label,
                                mi.ReturnType.Name, mi.Name);
                        else
                            Console.WriteLine("\tpublic {0} {1}()", mi.ReturnType.Name, mi.Name);
                    }
                        
                }
            }

            Type cInfo = assembly.GetType("Reflection.Calculator");

            Console.WriteLine($"{Environment.MachineName} {Environment.OSVersion}");
            Console.WriteLine($"Документы пользователя: {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}");

        }
    }
}
