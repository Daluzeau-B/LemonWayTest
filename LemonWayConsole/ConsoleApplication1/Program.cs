using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            LemonWayWS.Service WebServiceMethods = new LemonWayWS.Service();

            Console.WriteLine(" Web Service Methods");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Fibonacci(int n)");
            Console.WriteLine(": Return Fibonaci sequence number");
            Console.WriteLine("Exemple: calling Fibonacci(10) will return " + WebServiceMethods.Fibonaci(10));
            Console.WriteLine("\n2. XmlToJson(string xml)");
            Console.WriteLine(": Convert Xml to Json");
            Console.WriteLine("Exemple: calling XmlToJson(<foo>bar</foo>) will return " + WebServiceMethods.XmlToJson("<foo>bar</foo>"));

            Console.ReadLine();
        }
    }
}
