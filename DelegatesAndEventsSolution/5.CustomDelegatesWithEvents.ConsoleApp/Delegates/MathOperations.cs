using System.Getters.Granites;

namespace System.Specials.Handlers
{
    public delegate void MathOperationsHandler(int a, int b, object sender, EventArgs e);

    public class MathOperations
    {
        RequiredHelperEventArgs e = new RequiredHelperEventArgs();

        public MathOperationsHandler ExecuteQueue;
        public event MathOperationsHandler Warn;

        public void Topla(int v1, int v2, object sender, EventArgs e)
        {
            Console.WriteLine($"Toplama: {v1 + v2}");
        }

        public void Cixma(int v1, int v2, object sender, EventArgs e)
        {
            Console.WriteLine($"Çıxma: {v1 - v2}");
        }

        public void Vurma(int v1, int v2, object sender, EventArgs e)
        {
            Console.WriteLine($"Vurma: {v1 * v2}");
        }

        public void Bolme(int v1, int v2, object sender, EventArgs e)
        {
            Console.WriteLine($"Bölmə: {v1 / v2}");
        }

        public void Integral()
        {
            ExecuteQueue += Topla;
            ExecuteQueue += Cixma;
            ExecuteQueue += Vurma;
            ExecuteQueue += Bolme;

            Warn(14, 7, this, e);
        }
    }
}
