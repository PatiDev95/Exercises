using System;

namespace KUBIAK
{
    public static class TabliceKolekcje
    {
        public static void Zadanie41()
        {
            int n = 10, i;

            int[] dane = new int[n];
            Console.WriteLine("Program wyświetla zawartość tablicy jednowumiarowej " + n + "-elementowej.");

            for (i = 0; i < n; i++)
            {
                dane[i] = i;
                Console.WriteLine("dane[" + i + "] = " + dane[i]);
            }

            Console.WriteLine();

        }

        public static void Zadanie42()
        {
            int n = 10, i;

            int[] dane = new int[n];
            Console.WriteLine("Program wyświetla zawartość tablicy jednowymiarowej " + n + "-elementowej.");

            for (i = 0; i < n; i++)
            {
                dane[i] = n - 1 - i;
                Console.WriteLine("dane[" + i + "] = " + dane[i]);

            }
        }

        public static void Zadanie43()
        {
            int n = 10, i, j, suma;
            int[,] macierz = new int[n, n];

            Console.WriteLine("Program wyświetla zawartość tablicy dwuwymiarowej " + n + "x" + n + "-elementowej.");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                        macierz[i, j] = 1;
                    else
                        macierz[i, j] = 0;

                    Console.Write(macierz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            suma = 0;

            for (i = 0; i < n; i++)
            {
                suma = suma + macierz[i, i];
            }

            Console.WriteLine("Suma wyróżnionych elementów w tablicy wynosi " + suma + ".");
            Console.WriteLine();

        }

        public static void Zadanie44()
        {
            int n = 10, i, j;
            int[,] macierz = new int[n, n];

            Console.WriteLine("Program wyświetla zawartość tablicy dwuwymiarowej " + n + "x" + n + "-elementowej.");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                        macierz[i, j] = i;
                    else
                        macierz[i, j] = 0;
                    Console.Write(macierz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Zadanie45()
        {
            int n = 10, i, j, suma;
            int[,] macierz = new int[10, 10];

            Console.WriteLine("Program wyświetla zawartość tablicy dwuwymiarowej " + n + "x" + n + "-elementowej.");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (n == i + j + 1)
                        macierz[i, j] = 1;
                    else
                        macierz[i, j] = 0;

                    Console.Write(macierz[i, j] + " ");
                }

                Console.WriteLine();
            }
            suma = 0;
            for (i = 0; i < n; i++)
            {
                suma = suma + macierz[i, i];
            }

            Console.WriteLine("Suma wyróżnionych elementów w tablicy wynosi " + suma + ".");
            Console.WriteLine();
        }
    }
}
