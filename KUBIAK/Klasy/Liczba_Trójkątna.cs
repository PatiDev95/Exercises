using System;

namespace KUBIAK
{
    class Liczba_Trójkątna
    {
        public int Triangle(int n)
        {
            if (n == 1)
                return 1;
            else
                return (n + Triangle(n - 1));
        }

        public void Wykonaj_Zadanie()
        {
            int i, n = 10;

            Console.WriteLine("Program znajduje " + n + " pierwszych liczb trójkątnych.");
            Console.WriteLine();

            Liczba_Trójkątna liczby_trójkątne = new Liczba_Trójkątna ();

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("#" + i + " = " + liczby_trójkątne.Triangle(i));
            }
        }
    }
}
