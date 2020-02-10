using System;

namespace KUBIAK
{
    public class PoleProstokata
    {
        double a, b, oblicz_pole;

        public void czytaj_dane()
        {
            Console.WriteLine("Oblicz pole prostokąta:v");
            Console.WriteLine("Podaj bok a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok b: ");
            b = double.Parse(Console.ReadLine());
        }

        void przetwórz_dane()
        {
            oblicz_pole = a * b;
        }

        void wyświetl_wynik()
        {
            Console.Write("Pole prostokąta o boka a = {0:##.##} i boku b = {1:##.##}", a, b);
            Console.WriteLine(" wynosi: {0:##.##}", oblicz_pole);
        }

        public void wykonaj_zadanie()
        {
            PoleProstokata poleprost = new PoleProstokata();

            poleprost.czytaj_dane();
            poleprost.przetwórz_dane();
            poleprost.wyświetl_wynik();

        }
    }
}
