using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWorld.NamespaceEx
{
    public static class Class1
    {
        public static string MyName { get; set; } = "";
        public static void myMethod()
        {
            Console.WriteLine("Hallo my name is " + MyName);
        }
    }
}
