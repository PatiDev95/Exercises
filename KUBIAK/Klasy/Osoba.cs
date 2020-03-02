using System;

namespace KUBIAK
{
    class Osoba
    {
        String imię;
        String nazwisko;
        String ulica;
        String numer_domu;
        String miasto;
        String kod_pocztowy;

        public void Wczytaj()
        {
            Console.WriteLine("Dane osobowe: ");
            Console.WriteLine("=============================");
            Console.WriteLine("Podaj imię:");
            imię = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj ulicę:");
            ulica = Console.ReadLine();
            Console.WriteLine("Podaj numer domu:");
            numer_domu = Console.ReadLine();
            Console.WriteLine("Podaj miasto:");
            miasto = Console.ReadLine();
            Console.WriteLine("Podaj kod pocztowy:");
            kod_pocztowy = Console.ReadLine();

            Console.WriteLine();
        }

        public void Wyświetl()
        {
            Console.WriteLine("Wyświetlanie danych:");
            Console.WriteLine("==============================");
            Console.WriteLine("Imię: " + imię + ".");
            Console.WriteLine("Nazwisko: " + nazwisko + ".");
            Console.WriteLine("Ulica: " + ulica + ".");
            Console.WriteLine("Numer domu: " + numer_domu + ".");
            Console.WriteLine("Miasto: " + miasto + ".");
            Console.WriteLine("Kod pocztowy: " + kod_pocztowy + ".");
        }

        class Kadra : Osoba
        {
            String wykształcenie;
            String stanowisko;

            public void Wczytaj1()
            {
                Wczytaj();
                Console.WriteLine("Podaj wykształcenie:");
                wykształcenie = Console.ReadLine();
                Console.WriteLine("Podaj stanowisko:");
                stanowisko = Console.ReadLine();
                Console.WriteLine();
            }

            public void Wyświetl1()
            {
                Wyświetl();
                Console.WriteLine("Wykształcenie: " + wykształcenie + ".");
                Console.WriteLine("Stanowisko: " + stanowisko + ".");
            }
        }

        public void Wykonaj_Zadanie()
        {
            //Osoba osoba = new Osoba();

            //osoba.Wczytaj();
            //osoba.Wyświetl();

            Kadra kadra = new Kadra();

            kadra.Wczytaj1();
            kadra.Wyświetl1();
        }
    }
}
