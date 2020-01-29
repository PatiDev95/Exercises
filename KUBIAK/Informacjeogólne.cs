using System;
using System.Collections.Generic;
using System.Text;

namespace KUBIAK
{
    public static class Informacjeogólne
    {
        public static void Zadanie11()
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

        public static void Zadanie12()
        {
            Console.WriteLine("Program wyswietla stałą pi z dokładnością:");
            Console.WriteLine("Pi={0:#.#####}", Math.PI);
            Console.WriteLine();
        }

        public static void Zadanie13()
        {
            Console.WriteLine("Program wyświetla pierwiastek kwadratowy z liczby pi.");
            Console.WriteLine("Z dokładnością do dwóch miejsc po przecinku:");
            Console.WriteLine("Sqrt(pi)={0:#.##}", Math.Sqrt(Math.PI));
            Console.WriteLine();
        }

        public static void Zadanie14()
        {
            double r, objetosc;

            Console.WriteLine("Program oblicza objętość kuli o promieniu r:");
            Console.WriteLine("Podaj wartość r:");

            r = double.Parse(Console.ReadLine());

            objetosc = 4 * Math.PI * r * r * r / 3;

            Console.WriteLine("Objętość kuli o promienu r={0:#.##}, wynosi objetosc={1:#.##}", r, objetosc);
            Console.WriteLine();
        }

        public static void Zadanie15A()
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

        public static void Zadanie15B()
        {
            int a = 37;
            int b = 11;

            Console.WriteLine("Program wyświetla wynik dzielenia całkowitego bez reszty dla dwóch liczb całkowitych.");
            Console.WriteLine(a + "/" + b + "=" + a / b + ".");
            Console.WriteLine("Wynikiem dzielenia jest:{0:#}", a / b);
            Console.WriteLine();
        }

        public static void Zadanie16()
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

        public static void Zadanie17()
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
    }
}
