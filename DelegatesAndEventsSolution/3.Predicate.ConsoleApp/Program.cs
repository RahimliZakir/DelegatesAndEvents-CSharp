using System;

namespace _3.Predicates.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> m1 = Method1;

            Predicate<string> m2 = new Predicate<string>(Method2);

            Predicate<decimal> m3 = delegate (decimal d)
            {
                return true;
            };

            Predicate<float> m4 = (float f) =>
            {
                return false;
            };

            Console.ReadKey();
        }

        public static bool Method1(int v1)
        {
            return true;
        }

        public static bool Method2(string s)
        {
            return false;
        }
    }
}
