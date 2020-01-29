using System;
using System.Collections.Generic;
using System.Text;

namespace KUBIAK
{
    public static class Pętle
    {
        public static void Zadanie31()
        {
            int x, y;

            Console.WriteLine("Program oblicza wartość funkcji y=3*x, dla x zmieniajacego się od 0 do 10. Z wykorzystaniem pętli for.");
            Console.WriteLine();

            for (x = 0; x <= 10; x++)
            {
                y = 3 * x;
                Console.WriteLine("x=" + x + " to" + '\t' + "y=" + y);
            }
        }
        public static void Zadanie32()
        {
            int x = 0, y = 0;

            Console.WriteLine("Program oblicza wartość funkcji y=3*x, dla x zmieniajacego się od 0 do 10. Z wykorzystaniem pętli do ... while");
            Console.WriteLine();

            do
            {
                y = 3 * x;
                Console.WriteLine("x = " + x + '\t' + "y = " + y);
                x++;
            }
            while (x <= 10);
        }

        public static void Zadanie33()
        {
            int x = 0, y = 0;

            Console.WriteLine("Program oblicza wartość funkcji y=3*x, dla x zmieniajacego się od 0 do 10. Z wykorzystaniem pętli while");
            Console.WriteLine();

            while (x <= 10)
            {
                y = 3 * x;
                Console.WriteLine("x = " + x + '\t' + "y = " + y);
                x++;
            }
        }
        public static void Zadanie34()
        {
            int x;

            Console.WriteLine("Program wyświetla liczby całkowite od 1 do 20.");
            Console.WriteLine();

            for (x = 1; x <= 20; x++)
            {
                if (x < 20)
                    Console.Write(x + ",");
                else
                    Console.Write(x + ".");
            }
        }
        public static void Zadanie35()
        {
            int x = 1;

            Console.WriteLine("Program wyświetla liczby całkowite od 1 do 20.");
            Console.WriteLine();

            do
            {
                if (x < 20)
                    Console.Write(x + ",");
                else
                    Console.Write(x + ".");
                x++;
            }
            while (x <= 20);
        }
        public static void Zadanie36()
        {
            int x = 0;

            Console.WriteLine("Program wyświetla liczby całkowite od 1 do 20.");
            Console.WriteLine();

            while (x <= 20)
            {
                if (x < 20)
                    Console.Write(x + ",");
                else
                    Console.Write(x + ".");
                x++;
            }
        }

        public static void Zadanie37()
        {
            int x, suma = 0;

            Console.WriteLine("Program sumuje liczby całkowite od 1 do 100");

            for (x = 0; x <= 100; x++)
            {
                suma = suma + x;
            }
            Console.WriteLine("Suma liczb od 1 do 100 wynosi: " + suma + ".");
        }

        public static void Zadanie38()
        {
            int x = 0, suma = 0;

            Console.WriteLine("Program sumuje liczby całkowite od 1 do 100");

            do
            {
                suma = suma + x;
                x++;
            }
            while (x <= 100);

            Console.WriteLine("Suma liczb od 1 do 100 wynosi: " + suma + ".");
        }

        public static void Zadanie39()
        {
            int x = 0, suma = 0;

            Console.WriteLine("Program sumuje liczby całkowite od 1 do 100");

            while (x <= 100)
            {
                suma = suma + x;
                x++;
            }

            Console.WriteLine("Suma liczb od 1 do 100 wynosi: " + suma + ".");
        }

        public static void Zadanie310()
        {
            int x, suma = 0;

            Console.WriteLine("Program sumuje liczby parzyste od 1 do 100");

            for (x = 1; x <= 100; x++)
            {
                if (x % 2 == 0) suma += x;
            }
            Console.WriteLine("Suma liczb parzystych od 1 do 100 wynosi: " + suma);
        }

        public static void Zadanie311()
        {
            int x = 0, suma = 0;

            Console.WriteLine("Program sumuje liczby parzyste od 1 do 100");

            do
            {
                if (x % 2 == 0) suma += x;
                x++;
            }
            while (x <= 100);

            Console.WriteLine("Suma liczb parzystych od 1 do 100 wynosi: " + suma);
        }

        public static void Zadanie312()
        {
            int x = 0, suma = 0;

            Console.WriteLine("Program sumuje liczby parzyste od 1 do 100");

            while (x <= 100)
            {
                if (x % 2 == 0) suma += x;
                x++;
            }
            Console.WriteLine("Suma liczb parzystych od 1 do 100 wynosi: " + suma);
        }

        public static void Zadanie313()
        {
            int x, suma = 0;

            Console.WriteLine("Zadanie 13 Suma liczb nieparzystych od 1 do 100");

            for (x = 1; x <= 100; x++)
            {
                if (!(x % 2 == 0)) suma = suma + x;
            }

            Console.WriteLine("Zadanie 13 Suma liczb nieparzystych to:" + suma);
        }

        public static void Zadanie314()
        {
            int x = 0, suma = 0;

            Console.WriteLine("Zadanie 14 Suma liczb nieparzystych od 1 do 100");

            do
            {
                if (!(x % 2 == 0)) suma = suma + x;
                x++;
            }
            while (x <= 100);

            Console.WriteLine("Zadanie 14 Suma liczb nieparzystych od 1 do 100 wynosi: {0:#.##}", suma);
        }

        public static void Zadanie315()
        {
            int x = 1, suma = 0;

            Console.WriteLine("Zadanie 15 Suma liczb nieparzystych od 1 do 100. (pętla while)");

            while (x <= 100)
            {
                if (!(x % 2 == 00)) suma = suma + x;
                x++;
            }

            Console.WriteLine("Zadanie 15 Suma liczb nieparzystych od 1 do 100 wynosi:" + suma);
        }

        public static void Zadanie316()

        {
            int ilosc_liczb = 5, i;
            double liczba, suma = 0, min, max;

            Console.WriteLine("Program znajduje " + ilosc_liczb + " liczb całkowitych od 0 do 99, a następnie znajduje największą i najmiejszą");
            Console.WriteLine("oraz oblicza średnią ze wszystkich wylosowanych liczb.");

            Random r = new Random();
            min = Math.Round(100 * (r.NextDouble()));
            Console.Write("Wylosowano liczby: " + min + ", ");

            max = min;
            suma = suma + max;

            for (i = 2; i <= ilosc_liczb; i++)
            {
                liczba = Math.Round(100 * (r.NextDouble()));
                if (i < ilosc_liczb)
                    Console.Write(liczba + ", ");
                else
                {
                    Console.WriteLine(liczba + ".");
                }

                if (max < liczba) max = liczba;
                if (liczba < min) min = liczba;

                suma = suma + liczba;
            }

            Console.WriteLine("Min:" + min + " Max:" + max + " Średnia:" + suma / ilosc_liczb + ".");
            Console.WriteLine();
        }
        public static void Zadanie317()
        {
            int ilosc_liczb = 5, i = 2;
            double liczba, suma = 0, min, max;


            Console.WriteLine("Program znajduje " + ilosc_liczb + " liczb całkowitych od 0 do 99, a następnie znajduje największą i najmiejszą");
            Console.WriteLine("oraz oblicza średnią ze wszystkich wylosowanych liczb.");

            Random r = new Random();
            min = Math.Round(100 * (r.NextDouble()));
            Console.Write("Wylosowano liczby: " + min + ", ");

            max = min;
            suma = suma + max;

            do
            {
                liczba = Math.Round(100 * (r.NextDouble()));

                if (i < ilosc_liczb)
                    Console.Write(liczba + ", ");
                else
                    Console.WriteLine(liczba + ".");

                if (liczba > max) max = liczba;
                if (liczba < min) min = liczba;

                suma = suma + liczba;
                i++;
            }
            while (i <= ilosc_liczb);

            Console.WriteLine("Min:" + min + " Max:" + max + " Średnia:" + suma / ilosc_liczb + ".");
            Console.WriteLine();
        }

        public static void Zadanie318()
        {
            int ilosc_liczb = 5, i = 2;
            double liczba, suma = 0, min, max;


            Console.WriteLine("Program znajduje " + ilosc_liczb + " liczb całkowitych od 0 do 99, a następnie znajduje największą i najmiejszą");
            Console.WriteLine("oraz oblicza średnią ze wszystkich wylosowanych liczb.");

            Random r = new Random();
            min = Math.Round(100 * (r.NextDouble()));
            Console.Write("Wylosowano liczby: " + min + ", ");

            max = min;
            suma = suma + min;

            while (i <= ilosc_liczb)
            {
                liczba = Math.Round(100 * (r.NextDouble()));
                if (i < ilosc_liczb)
                    Console.Write(liczba + ", ");
                else
                    Console.WriteLine(liczba + ".");

                if (liczba > max) max = liczba;
                if (liczba < min) min = liczba;

                suma = suma + liczba;
                i++;
            }
            Console.WriteLine("Min:" + min + " Max:" + max + " Średnia:" + suma / ilosc_liczb + ".");
        }

        public static void Zadanie319()
        {
            int n = 10, wiersz, kolumna;

            Console.WriteLine("Program wyświetla tabliczkę mnożenia dla liczb od 1 do 100.");
            Console.WriteLine();

            for (wiersz = 1; wiersz <= n; wiersz++)
            {
                for (kolumna = 1; kolumna <= n; kolumna++)
                {
                    Console.Write(wiersz * kolumna + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Zadanie320()
        {
            int n = 10, wiersz, kolumna;

            Console.WriteLine("Program wyświetla tabliczkę mnożenia dla liczb od 1 do 100.");
            Console.WriteLine();

            wiersz = 1;

            do
            {
                kolumna = 1;
                do
                {
                    Console.Write(wiersz * kolumna + "\t");
                    kolumna++;
                }
                while (kolumna <= n);

                wiersz++;
                Console.WriteLine();

            }
            while (wiersz <= n);

            Console.WriteLine();
        }

        public static void Zadanie321()
        {
            int n = 10, wiersz, kolumna;

            Console.WriteLine("Program wyświetla tabliczkę mnożenia dla liczb od 1 do 100.");
            Console.WriteLine();

            wiersz = 1;

            while (wiersz <= n)
            {
                kolumna = 1;
                while (kolumna <= n)
                {
                    Console.Write(wiersz * kolumna + "\t");
                    kolumna++;
                }
                wiersz++;
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Zadanie322()
        {
            char znak;

            Console.WriteLine("Program wyświetla duże litery alfabetu od A do Z i od Z do A.");
            Console.WriteLine("Litery alfabetu w kolejności zwiększającej się: ");

            for (znak = 'A'; znak <= 'Z'; znak++)
            {
                if (znak < 'Z')
                    Console.Write(znak + ", ");
                else
                    Console.Write(znak + ".");
            }

            Console.WriteLine();

            Console.WriteLine("Litery alfabetu w kolejności zmniejszającej się: ");

            for (znak = 'Z'; znak >= 'A'; znak--)
            {
                if (znak > 'A')
                    Console.Write(znak + ", ");
                else
                    Console.Write(znak + ".");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Zadanie323()
        {
            char znak;

            Console.WriteLine("Program wyświetla duże litery alfabetu od A do Z i od Z do A.");
            Console.WriteLine("Litery alfabetu w kolejności zwiększającej się: ");

            znak = 'A';

            do
            {
                if (znak < 'Z')
                    Console.Write(znak + ", ");
                else
                    Console.Write(znak + ".");
                znak++;
            }
            while (znak <= 'Z');

            Console.WriteLine();

            Console.WriteLine("Litery alfabetu w kolejności zmniejszającej się: ");

            znak = 'Z';

            do
            {
                if (znak > 'A')
                    Console.Write(znak + ", ");
                else
                    Console.Write(znak + ".");

                znak--;
            }
            while (znak >= 'A');

            Console.WriteLine();
            Console.WriteLine();
        }
        public static void Zadanie324()
        {
            char znak;

            Console.WriteLine("Program wyświetla duże litery alfabetu od A do Z i od Z do A.");
            Console.WriteLine("Litery alfabetu w kolejności zwiększającej się: ");

            znak = 'A';

            while (znak <= 'Z')
            {
                if (znak < 'Z')
                    Console.Write(znak + ", ");
                else
                    Console.Write(znak + ".");
                znak++;
            }

            Console.WriteLine();

            Console.WriteLine("Litery alfabetu w kolejności zmniejszającej się: ");

            znak = 'Z';

            while (znak >= 'A')
            {
                if (znak > 'A')
                    Console.Write(znak + ", ");
                else
                    Console.Write(znak + ".");

                znak--;
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Zadanie325()
        {
            int j = 0, i;

            for (i = 1000; i <= 9999; i++)
            {
                int pdc = i / 100;
                int odc = i % 100;

                if (pdc * pdc + odc * odc == i)
                {
                    Console.WriteLine(i + "=" + pdc + "*" + pdc + "+" + odc + "*" + odc);
                    j++;
                }

            }

            Console.WriteLine();
            Console.WriteLine("Znaleziono " + j + " liczy.");
        }

        public static void Zadanie325B()
        {
            Console.WriteLine();
            Console.WriteLine();

            int x = 1000, j = 0;

            do
            {
                int pdc = x / 100;
                int odc = x % 100;

                if (x == pdc * pdc + odc * odc)
                {
                    Console.WriteLine(x + "=" + pdc + "*" + pdc + "+" + odc + "*" + odc);
                    j++;
                }
                x++;
            }
            while (x < 10000);


            Console.WriteLine();
            Console.WriteLine("Znaleziono " + j + " liczy.");
        }

        public static void Zadanie325C()
        {
            Console.WriteLine();
            Console.WriteLine();

            int x = 1000, j = 0;

            while (x < 10000)
            {
                int pdc = x / 100;
                int odc = x % 100;

                if (x == pdc * pdc + odc * odc)
                {
                    Console.WriteLine(x + "=" + pdc + "*" + pdc + "+" + odc + "*" + odc);
                    j++;
                }
                x++;
            }


            Console.WriteLine();
            Console.WriteLine("Znaleziono " + j + " liczy.");
        }

        public static void Zadanie326()
        {
            Console.WriteLine();
            Console.WriteLine();

            int j = 0, i;

            for (i = 100000; i < 1000000; i++)
            {
                int ptc = i / 1000;
                int otc = i % 1000;

                if (ptc * ptc + otc * otc == i)
                {
                    Console.WriteLine(i + "=" + ptc + "*" + ptc + "+" + otc + "*" + otc);
                    j++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Znaleziono " + j + " liczbę.");
        }

        public static void Zadanie326B()
        {
            Console.WriteLine();
            Console.WriteLine();

            int j = 0, i = 100000;

            do
            {
                int ptc = i / 1000;
                int otc = i % 1000;

                if (ptc * ptc + otc * otc == i)
                {
                    Console.WriteLine(i + "=" + ptc + "*" + ptc + "+" + otc + "*" + otc);
                    j++;
                }
                i++;
            }
            while (i < 1000000);

            Console.WriteLine();
            Console.WriteLine("Znaleziono " + j + " liczbę.");
        }

        public static void Zadanie326C()

        {
            Console.WriteLine();
            Console.WriteLine();

            int j = 0, i = 100000;

            while (i < 1000000)
            {
                int ptc = i / 1000;
                int otc = i % 1000;

                if (ptc * ptc + otc * otc == i)
                {
                    Console.WriteLine(i + "=" + ptc + "*" + ptc + "+" + otc + "*" + otc);
                    j++;
                }
                i++;
            }


            Console.WriteLine();
            Console.WriteLine("Znaleziono " + j + " liczbę.");
        }

        public static void Zadanie327()
        {
            Int32 liczba_punktow = 100000000, i;
            int licznik = 0;
            double x, y, pi;

            Console.WriteLine("Proszę czekać...");
            Random r = new Random();

            for (i = 1; i < liczba_punktow; i++)
            {
                x = Math.Round(100 * (r.NextDouble())) / 100.0;
                y = Math.Round(100 * (r.NextDouble())) / 100.0;

                if (x * x + y * y <= 1)
                {
                    licznik = licznik + 1;
                }

            }

            pi = 4.0 * licznik / liczba_punktow;

            Console.WriteLine("Wartość pi = " + Math.PI);
            Console.WriteLine("Oblicznona wartość pi = " + pi);
        }

        public static void Zadanie328()
        {
            int x, i;

            for (i = 0; i < 20; i++)
            {
                x = i / 2;
                Console.Write(x);
            }

            Console.WriteLine();
        }
        public static void Zadanie328B()
        {
            int x, i = 0;

            do
            {
                x = i / 2;
                Console.Write(x);
                i++;
            }
            while (i < 20);

            Console.WriteLine();
        }

        public static void Zadanie328C()
        {
            int x, i = 0;

            while (i < 20)
            {
                x = i / 2;
                Console.Write(x);
                i++;
            }

            Console.WriteLine();
        }
    }
}
