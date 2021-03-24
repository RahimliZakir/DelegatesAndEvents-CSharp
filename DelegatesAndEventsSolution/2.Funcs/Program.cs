using System;

namespace _2.Funcs.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> m1 = Method1;

            Func<double, double, decimal> m2 = new Func<double, double, decimal>(Method2);

            Func<int, int, int, int> m3 = delegate (int v1, int v2, int v3)
            {
                return v1 + v2 + v3;
            };

            Func<int, int, int> m4 = (int a, int b) =>
            {
                return a + b;
            };

            m4 += (int a, int b) =>
             {
                 return a + b;
             };

            m4 += (int a, int b) =>
            {
                return a + b;
            };


            m4 += (int a, int b) =>
            {
                return a + b;
            };

            var result = m4.Invoke(2, 3);
            Console.WriteLine(result);
            // m4(2, 3);

            Console.ReadKey();
        }

        public static int Method1()
        {
            return 25;
        }

        public static decimal Method2(double a, double b)
        {
            decimal aa = Convert.ToDecimal(a);
            decimal bb = Convert.ToDecimal(b);

            decimal c = aa + bb;

            return c;
        }
    }
}
