using System;
using System.Specials.Handlers;
using System.Text;

namespace _4.CustomDelegates.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MathOperations mo = new MathOperations();

            mo.Integral();

            mo.ExecuteQueue(14, 7);

            Console.ReadKey();
        }
    }
}
