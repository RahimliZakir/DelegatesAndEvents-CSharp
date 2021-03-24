using System;
using System.Collections.Generic;
using System.Text;

namespace System.Specials.Handlers
{
    public delegate void MathOperationsHandler(int a, int b);

    public class MathOperations
    {
        public MathOperationsHandler ExecuteQueue;

        public void Topla(int v1, int v2)
        {
            Console.WriteLine($"Toplama: {v1 + v2}");
        }

        public void Cixma(int v1, int v2)
        {
            Console.WriteLine($"Çıxma: {v1 - v2}");
        }

        public void Vurma(int v1, int v2)
        {
            Console.WriteLine($"Vurma: {v1 * v2}");
        }

        public void Bolme(int v1, int v2)
        {
            Console.WriteLine($"Bölmə: {v1 / v2}");
        }

        public void Integral()
        {
            ExecuteQueue += Topla;
            ExecuteQueue += Cixma;
            ExecuteQueue += Vurma;
            ExecuteQueue += Bolme;
        }
    }
}
