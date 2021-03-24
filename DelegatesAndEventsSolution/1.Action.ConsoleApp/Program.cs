using System;

namespace _1.Actions.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // First way
            Action m1 = Method1;

            // Second way (With Instance)
            Action<int> m2 = new Action<int>(Method2);

            // Third way (Anonymous delegate)
            Action<float, sbyte> m3 = delegate (float f, sbyte sb)
            {
                Console.WriteLine("Method3");
            };

            m3 += delegate (float f, sbyte sb)
            {
                Console.WriteLine("Method3");
            };
            m3 += delegate (float f, sbyte sb)
            {
                Console.WriteLine("Method3");
            };
            m3 += delegate (float f, sbyte sb)
            {
                Console.WriteLine("Method3");
            };
            m3 += delegate (float f, sbyte sb)
            {
                Console.WriteLine("Method3");
            };

            m3.Invoke(2.5F, 2);
            // m3(2.5F, 2);

            // Fourth way (With Lambda expression)
            Action<int, string, decimal> m4 = (int v1, string v2, decimal v3) =>
            {
                Console.WriteLine("Method4");
            };

            Console.ReadKey();
        }

        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        private static void Method2(int obj)
        {
            Console.WriteLine("Method2");
        }
    }
}
