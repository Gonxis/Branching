using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetExample
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            log.Info("This is an info log");
            log.Error("This is my error");

            Console.ReadLine();
        }
    }
}
