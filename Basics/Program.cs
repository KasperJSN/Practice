using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethod();

            Console.ReadKey(); // required so console window does not close automatically; its waiting for user input (reading a key)
        }

        static void TestMethod()
        {
            // outputs text to console window
            // WriteLine takes entire line; Write appends
            // "\n" is a special new line symbol
            // WriteLine is basically Write + invisible "\n" at the end
            Console.WriteLine("test message 1");
            Console.Write("test ");
            Console.Write("message 2");
            Console.Write("test message 3 \n");
        }
    }
}
