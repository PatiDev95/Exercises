using System;
using System.Collections;

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
            int ni = 40, nj = 50, i, j, suma1, suma2;
            int[,] tablica = new int[nj, ni];

            Console.WriteLine("Program wyświetla zawartość tablicy dwuwymiarowej " + ni + "x" + nj + "-elementowej.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Zadanie Zaawansowane!!!";
            

            for (i = 0; i < nj; i++)
            {
                for (j = 0; j < ni; j++)
                {
                    //if (j == 0) tablica[i, j] = i;
                    //if (j == 1) 
                        tablica[i, j] = i * j;
                    //if (j > 1) tablica[i, j] = 0;
                    var x = tablica[i, j];
                    Console.Write(x + (x <= 9 ? "    " : x <= 99 ? "   " : x <= 999 ? "  " : " " ));
                }
                Console.WriteLine();
            }

            suma1 = 0;
            suma2 = 0;

            for(i=0;i<ni;i++)
            {
                suma1 = suma1 + tablica[i, 0];
                suma2 = suma2 + tablica[i, 1];
            }
            Console.ResetColor();
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

        public static void Zadanie49()
        {
            int n = 100, i, suma = 0, suma1;
            int[] dane = new int[n];

            Console.WriteLine("Program sumuje liczby od 1 do 100, znajdujące się w tablicy jednowymiarowej.");

            for (i = 0; i < n; i++)
            {
                dane[i] = i + 1;
            }

            // Sposób z forech

            foreach (int x in dane)
            {
                suma = suma + x;
            }

            // Sposób z for

            suma1 = 0;

            for (i = 0; i < n; i++)
            {
                suma1 = suma1 + dane[i];
            }
            Console.WriteLine("Suma liczb od 1 do 100 z wykorzystaniem forech wynosi: " + suma + ".");
            Console.WriteLine("Suma liczb od 1 do 100 z wykorzystaniem for wynosi: " + suma1 + "."); 
        }

        public static void Zadanie410()
        {
            int n = 100, i, suma_np = 0, suma_p = 0;
            int[] dane = new int[n];

            Console.WriteLine("Program sumuje liczby parzyste i nieparzyste znajdujące się w przedziale od 1 do 100, znajdujące się w tablicy.");

            for(i=0; i<n; i++)
            {
                dane[i] = i + 1;
            }

            foreach (int x in dane)
            {
                if ((x % 2) == 0)
                    suma_p = suma_p + x;
                else
                    suma_np += x;
            }
            Console.WriteLine("Suma liczb parzystych od 1 do 100 wynosi " + suma_p + ".");
            Console.WriteLine("Suma liczb nieparzystych od 1 do 100 wynosi " + suma_np + ".");
            Console.WriteLine();
        }

        public static void Zadanie411()
        {
            ArrayList lista = new ArrayList();

            lista.Add(20);
            lista.Add(51);
            lista.Add(-72);
            lista.Add(4);
            lista.Add(14);
            lista.Add(-4);

            Console.Write("Elementy nieposortowane: ");

            for (int i = 0; i< lista.Count; i++)
            {
                if (i < lista.Count-1)
                    Console.Write(lista[i] + ", ");
                else
                    Console.WriteLine(lista[i] + ".");
            }

            lista.Sort();

            Console.Write("Elementy posortowane: ");

            for (int i=0; i<lista.Count; i++)
            {
                if (i < lista.Count - 1)
                    Console.Write(lista[i] + ", ");
                else
                    Console.WriteLine(lista[i] + ".");
            }

            lista.RemoveAt(1);
            
            Console.Write("Usunięto drugi element z listy i dodano nowy element do listy: ");
            lista.Add(10);

            for (int i =0; i<lista.Count; i++)
            {
                if (i < lista.Count - 1)
                    Console.Write(lista[i] + ", ");
                else
                    Console.WriteLine(lista[i] + ".");
            }

            lista.Sort();

            Console.Write("Elementy posortowane: ");

            for( int i = 0; i< lista.Count; i++)
            {
                if (i < lista.Count - 1)
                    Console.Write(lista[i] + ", ");
                else
                    Console.WriteLine(lista[i] + ".");
            }
            Console.WriteLine();
        }

        public static void Zadanie412()
        {
            ArrayList lista = new ArrayList();

            lista.Add("Tomek");
            lista.Add("Zenek");
            lista.Add("Ania");
            lista.Add("Jarek");
            lista.Add("Kasia");
            lista.Add("Dominika");

            Console.Write("Elementy nieposortowane: ");
            for (int i =0; i<lista.Count; i++)
            {
                if (i < lista.Count - 1)
                    Console.Write(lista[i] + ", ");
                else
                    Console.WriteLine(lista[i] + ".");
            }

            lista.Sort();

            Console.Write("Elementy posortowane: ");
            for (int i = 0; i < lista.Count; i++)
            {
                if (i < lista.Count - 1)
                    Console.Write(lista[i] + ", ");
                else
                    Console.WriteLine(lista[i] + ".");
            }

            lista.RemoveAt(2);
            Console.Write("Usunięto drugi element z listy i dodano nowy element do listy: ");
            lista.Add("Marta");

            for (int i = 0; i < lista.Count; i++)
            {
                if (i < lista.Count - 1)
                    Console.Write(lista[i] + ", ");
                else
                    Console.WriteLine(lista[i] + ".");
            }

            lista.Sort();

            Console.Write("Elementy posortowane: ");
            for (int i =0; i<lista.Count; i++)
            {
                if (i < lista.Count - 1)
                    Console.Write(lista[i] + ", ");
                else
                    Console.WriteLine(lista[i] + ".");
            }
        }
    }
}
