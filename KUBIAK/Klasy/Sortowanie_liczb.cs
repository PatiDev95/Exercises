using System;
using System.Collections.Generic;
using System.Text;

namespace KUBIAK
{
    class Sortowanie_liczb
    {
        public void czytaj_dane(int[]liczby, int n)
        {
            int i;

            Console.WriteLine("Liczby nieposortowane to: ");
            for (i=0;i<n; i++)
            {
                if (i < n - 1)
                    Console.Write(liczby[i] + ", ");
                else
                    Console.WriteLine(liczby[i] + ".");
            }
            Console.WriteLine();
        }

        public void przetwórz_dane(int[]liczby, int n)
        {
            int i, j, x;

            for (i=1; i<=n-1; i++)
            {
                for (j=n-1;j>=i;j--)
                    if (liczby[j-1]>liczby[j])
                    {
                        x = liczby[j - 1];
                        liczby[j - 1] = liczby[j];
                        liczby[j] = x;
                    }
            }
        }

        public void wyświetl_wynik(int[] liczby, int n)
        {
            int i;

            Console.WriteLine();
            Console.WriteLine("Liczby posortowane to:");

            for (i=0;i<n;i++)
            {
                if (i < n - 1)
                    Console.Write(liczby[i] + ", ");
                else
                    Console.WriteLine(liczby[i] + ".");
            }
        }

        public void wykonaj_zadanie()
        {
            int n = 6;
            int[] liczby = new int[n];

            liczby[0] = 57;
            liczby[1] = 303;
            liczby[2] = 34;
            liczby[3] = -1025;
            liczby[4] = 8;
            liczby[5] = 20;

            Sortowanie_liczb sortowanie = new Sortowanie_liczb();

            sortowanie.czytaj_dane(liczby, n);
            sortowanie.przetwórz_dane(liczby, n);
            sortowanie.wyświetl_wynik(liczby, n);
        }
    }
}
