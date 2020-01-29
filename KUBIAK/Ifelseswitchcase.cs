using System;
using System.Collections.Generic;
using System.Text;

namespace KUBIAK
{
    public static class Ifelseswitchcase
    {
        public static void Zadanie21()
        {
            int a, b, c;
            Console.WriteLine("Program sprawdza czy liczby a, b, c są trójką pitagorejską");
            Console.WriteLine("Podaj liczbę a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c:");
            c = int.Parse(Console.ReadLine());

            if ((a * a + b * b) == c * c)
            {
                Console.WriteLine("To jest trójka pitagorejska");
            }
            else
            {
                Console.WriteLine("To nie jest trójka pitagorejska");
            }
            Console.WriteLine();
        }
        public static void Zadanie22()
        {
            double a, b, c, delta, x1, x2, x;

            Console.WriteLine("Program oblicza pierwiastki równania kwadratowego ax^+bx+c=0");
            Console.WriteLine("Podaj a:");
            a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Niedozwolona wartość współczynnika a. Naciśnij klawisz ENTER.");
            }

            else
            {
                Console.WriteLine("Podaj b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c:");
                c = double.Parse(Console.ReadLine());

                delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("To równanie nie ma rozwiązań");
                }
                else if (delta == 0)
                {
                    x = -b / 2 * a;
                    Console.WriteLine("X to: {0:#.##}", x);
                }
                else
                {
                    x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("x1 to: {0:#.##}, a x2 to: {1:#.##}", x1, x2);
                }
            }
        }
        public static void Zadanie23()
        {
            double a, b, c, x1, x2, delta;
            byte liczba_pierwiastkow = 0;

            Console.WriteLine("Program oblicza równanie kwadratowe ax^2+bx+c=0.");
            Console.WriteLine("Podaj a");
            a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Niedozwolona wartość współczynnika a. Naciśnij klawisz ENTER.");
            }

            else
            {
                Console.WriteLine("Podaj b");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c");
                c = double.Parse(Console.ReadLine());

                delta = b * b - 4 * a * c;

                if (delta < 0) liczba_pierwiastkow = 0;
                if (delta == 0) liczba_pierwiastkow = 1;
                if (delta > 0) liczba_pierwiastkow = 2;

                switch (liczba_pierwiastkow)
                {
                    case 0:
                        {
                            Console.WriteLine("Dla a={0}, b={1} i c={2}, brak pierwiastków rzeczywistych", a, b, c);
                        }
                        break;
                    case 1:
                        {
                            x1 = -b / (2 * a);
                            Console.WriteLine("Dla a={0}, b={1} i c={2}, Jest jedno rozwiązanie x1={3:#.##}", a, b, c, x1);
                        }
                        break;
                    case 2:
                        {
                            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                            Console.WriteLine("Dla a={0}, b={1} i c={2}. " +
                            "Równanie kwadratowe ma dwa rozwiązania: x1={3:#.##} i x2={4:#.##}", a, b, c, x1, x2);
                        }
                        break;
                }
            }
        }

        public static void Zadanie24()
        {
            double a, b, c, x;

            Console.WriteLine("Program oblicza x z równania ax+b=c");
            Console.WriteLine("Podaj a:");
            a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Niedozwolona wartość współczynnika a. Nacisnij ENTER");
            }
            else
            {
                Console.WriteLine("Podaj b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c:");
                c = double.Parse(Console.ReadLine());

                x = (c - b) / a;

                Console.WriteLine("Dla a={0:#.##}, b={1:#.##} i c={2:#.##}. Wartość równania wynosi:{3:#.##}", a, b, c, x);
            }
        }

        public static void Zadanie25()
        {
            double zgadnij_liczbe, losuj_liczbe;

            Console.WriteLine("Program losuje liczbę. Zgadnij ją:");
            Random r = new Random();
            losuj_liczbe = Math.Round(10 * (r.NextDouble()));
            zgadnij_liczbe = double.Parse(Console.ReadLine());

            if (zgadnij_liczbe == losuj_liczbe)
            {
                Console.WriteLine("Gratuluję! Zgadłeś liczbę!");
            }
            else
            {
                Console.WriteLine("Twoja liczba to:{0:#.##}, Wylosowana liczba to:{1:#.##}. " +
                    "Bardzo mi przykro, nie zgadłeś.", zgadnij_liczbe, losuj_liczbe);
            }
        }
    }
}
