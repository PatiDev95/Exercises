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
            int n = 10, i, j, suma;
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

            suma = 0;

            for (i = 0; i < n; i++)
            {
                suma = suma + macierz[i, i];
            }

            Console.WriteLine("Suma wyróżnionych elementów w tablicy wynosi " + suma + ".");
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
                suma = suma + macierz[i, n-i-1];
            }
            Console.WriteLine("Suma wyróżnionych elementów w tablicy wynosi " + suma + ".");
            Console.WriteLine();
        }
        public static void Zadanie46()
        {
            int n = 10, i, j, suma;
            int[,] macierz = new int[n, n];

            Console.WriteLine("Program wyświetla zawartość tablicy dwuwymiarowej " + n + "x" + n + "-elementowej.");
            
            for (i=0; i<n; i++)
            {
                for(j=0; j<n; j++)
                {
                    if (n == i + j + 1)
                        macierz[i, j] = i;
                    else
                        macierz[i, j] = 0;

                    Console.Write(macierz[i, j] + " ");
                }
                Console.WriteLine();
            }

            suma = 0;

            for (i=0;i<n;i++)
            {
                suma = suma + macierz[i, n-i-1];
            }
            Console.WriteLine("Suma wyróżnionych elementów tablicy wynosi " + suma + ".");
            Console.WriteLine();
        }

        public static void Zadanie47()
        {
            int n = 10, i, j, suma1, suma2;
            int[,] tablica = new int[n, n];

            Console.WriteLine("Program wyświetla zawartość tablicy dwuwymiarowej " + n + "x" + n + "-elementowej.");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (j == 0) tablica[i, j] = i;
                    if (j == 1) tablica[i, j] = i * i;
                    if (j > 1) tablica[i, j] = 0;

                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }

            suma1 = 0;
            suma2 = 0;

            for(i=0;i<n;i++)
            {
                suma1 = suma1 + tablica[i, 0];
                suma2 = suma2 + tablica[i, 1];
            }
            Console.WriteLine("Suma liczb pierwszej kolumny to: " + suma1 + " a suma liczb drugiej kolumny to: " + suma2 + ".");
            Console.WriteLine();
        }

        public static void Zadanie48()
        {
            int n = 10, i, j;
            int[,] a = new int[n, n];
            int[,] b = new int[n, n];

            Console.WriteLine("Program wyświetla tablice a.");

            for (i = 0; i < n; i++)
            {
                for(j=0;j<n;j++)
                {
                    a[i, j] = j;
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Program wyświetla tablicę b, z wartościami z tablicy a i zamianą kolumny na wiersze.");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    b[i, j] = a[j, i];
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }

           
        }
    }
}
