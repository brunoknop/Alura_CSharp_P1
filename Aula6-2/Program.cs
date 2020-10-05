using System;

namespace Aula6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Numero = 0; Numero <= 100; Numero++)
            {
                if (Numero % 3 == 0)
                {
                    Console.WriteLine(Numero);
                }
            }
        }
    }
}
