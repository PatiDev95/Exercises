using System;
using System.Collections.Generic;
using System.Text;

namespace KUBIAK
{
    class Macierz
    {
        public void czytaj_dane(double[,] macierz, int rozmiar)

        {
            int i, j;

            Random r = new Random();

            for (i=0; i<rozmiar; i++)
            {
                for (j=0; j<rozmiar; j++)
                {
                    if (i == j)
                        macierz[i, j] = Math.Round(9 * (r.NextDouble()));
                    else
                        macierz[i, j] = 0;
                }
            }
        }

        public void przetwórz_dane(double[,] macierz, int rozmiar)
        {
            int i;
            double suma = 0;

            for (i=0; i<rozmiar; i++)
                suma = suma + macierz[i, i];
            Console.WriteLine("Suma elementów na przekątnej wynosi = " + suma + ".");
            Console.WriteLine();   
        }

        public void wyświetl_dane(double[,] macierz, int rozmair)
        {
            int i, j;

            for (i=0; i<rozmair; i++)
            {
                for(j=0;j<rozmair; j++)
                {
                    Console.Write(macierz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void wykonaj_zadanie()
        {
            int rozmiar = 10;
            double[,] tablica = new double[rozmiar, rozmiar];

            Macierz macierz = new Macierz();

            macierz.czytaj_dane(tablica, rozmiar);
            macierz.przetwórz_dane(tablica, rozmiar);
            macierz.wyświetl_dane(tablica, rozmiar);

        }
    }
}
