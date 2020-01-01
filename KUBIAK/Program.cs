﻿using System;

namespace KUBIAK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie11();
            //Zadanie12();
            //Zadanie13();
            //Zadanie14();
            //Zadanie15A();
            //Zadanie15B();
            //Zadanie16();
            //Zadanie17();
            //Zadanie21();
            //Zadanie22();
            //Zadanie23();
            //Zadanie24();
            Zadanie25();

        }

        static void Zadanie11()
        {
            double a, b, pole;

            Console.WriteLine("Program oblicza pole prostokąta.");
            Console.WriteLine("Podaj bok a.");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok b.");
            b = double.Parse(Console.ReadLine());

            pole = a * b;

            Console.WriteLine("Pole prostokąta o boku a={0} i b={1} wynosi {0:#.##}.", a, b, pole);
            Console.WriteLine();
        }

        static void Zadanie12()
        {
            Console.WriteLine("Program wyswietla stałą pi z dokładnością:");
            Console.WriteLine("Pi={0:#.#####}", Math.PI);
            Console.WriteLine();
        }

        static void Zadanie13()
        {
            Console.WriteLine("Program wyświetla pierwiastek kwadratowy z liczby pi.");
            Console.WriteLine("Z dokładnością do dwóch miejsc po przecinku:");
            Console.WriteLine("Sqrt(pi)={0:#.##}", Math.Sqrt(Math.PI));
            Console.WriteLine();
        }

        static void Zadanie14()
        {
            double r, objetosc;

            Console.WriteLine("Program oblicza objętość kuli o promieniu r:");
            Console.WriteLine("Podaj wartość r:");

            r = double.Parse(Console.ReadLine());

            objetosc = 4 * Math.PI * r * r * r / 3;

            Console.WriteLine("Objętość kuli o promienu r={0:#.##}, wynosi objetosc={1:#.##}", r, objetosc);
            Console.WriteLine();
        }

        static void Zadanie15A()
        {
            int dzielenie;

            int a = 37;
            int b = 11;

            dzielenie = a / b;

            Console.WriteLine("Program wyświetla wynik dzielenia całkowitego bez reszty dla dwóch liczb całkowitych.");
            Console.WriteLine("Dla liczb a=" + a + " i b=" + b);
            Console.WriteLine("Wynikiem dzielenia jest:{0:#} ", dzielenie + ".");
            Console.WriteLine();
        }

        static void Zadanie15B()
        {
            int a = 37;
            int b = 11;

            Console.WriteLine("Program wyświetla wynik dzielenia całkowitego bez reszty dla dwóch liczb całkowitych.");
            Console.WriteLine(a + "/" + b + "=" + a / b + ".");
            Console.WriteLine("Wynikiem dzielenia jest:{0:#}", a / b);
            Console.WriteLine();
        }

        static void Zadanie16()
        {
            int a = 37;
            int b = 11;

            Console.WriteLine("Program oblicza resztę z dzielenia całkowitego dwóch liczb całkowitych:");
            Console.WriteLine("a={0} i b={1}", a, b);
            Console.WriteLine("a=" + a + " i b=" + b);
            Console.WriteLine();
            Console.WriteLine(a + "%" + b + "=" + a % b);
            Console.WriteLine();
        }

        static void Zadanie17()
        {
            double x, y, dodawanie, odejmowanie, mnożenie, dzielenie;

            Console.WriteLine("Program wykonuje obliczenia matematyczne takie jak dodawanie, odejmowanie, mnożenie i dzielenie na dwóch liczbach");
            Console.WriteLine("Podaj pierwszą liczbę:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            y = double.Parse(Console.ReadLine());

            dodawanie = x + y;
            odejmowanie = x - y;
            mnożenie = x * y;
            dzielenie = x / y;

            Console.WriteLine("Wynikiem dodawania " + x + " i " + y + " jest:{0:#.##}", dodawanie);
            Console.WriteLine("Wynikiem odejmowania " + x + " i " + y + " jest:{0:#.##}", +odejmowanie);
            Console.WriteLine("Wynikiem mnożenia " + x + " i " + y + " jest:{0:#.##}", +mnożenie);
            Console.WriteLine("Wynikiem dzielenia " + x + " i " + y + " jest:{0:#.##}", +dzielenie);
            Console.WriteLine();
        }

        static void Zadanie21()
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
        static void Zadanie22()
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
        static void Zadanie23()
        {
            double a, b, c, x1, x2, x, delta;
            byte liczba_pierwiastkow = 0;

            Console.WriteLine("Program oblicza równanie kwadratowe ax^2+bx+c=0.");
            Console.WriteLine("Podaj a");
            a = double.Parse(Console.ReadLine());

            if (a==0)
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

        static void Zadanie24()
        {
            double a, b, c, x;

            Console.WriteLine("Program oblicza x z równania ax+b=c");
            Console.WriteLine("Podaj a:");
            a = double.Parse(Console.ReadLine());
            if (a==0)
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

        static void Zadanie25()
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
                    "Bardzo mi przykro, nie zgadłeś.", zgadnij_liczbe,losuj_liczbe)
                   ;
            }
        }

}   }
