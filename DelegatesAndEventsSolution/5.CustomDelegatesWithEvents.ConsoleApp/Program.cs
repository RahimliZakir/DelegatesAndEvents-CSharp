using System;
using System.Getters.Granites;
using System.Specials.Handlers;
using System.Text;

namespace _5.CustomDelegatesWithEvents.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            RequiredHelperEventArgs e = new RequiredHelperEventArgs();

            MathOperations mo = new MathOperations();

            mo.Warn += Mo_Warn;

            mo.Integral();

            mo.ExecuteQueue(14, 7, args, e);

            Console.ReadKey();
        }

        private static void Mo_Warn(int a, int b, object sender, EventArgs e)
        {
            Console.WriteLine("Warned!");
        }
    }
}
