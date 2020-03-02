using System;

namespace KUBIAK

{
    public class RownanieKwadratowe
    {
        double a, b, c, delta, x1, x2;
        byte liczba_pierwiastków;

        public void czytaj_dane()
        {
            Console.WriteLine("Program oblicza pierwiastki równania kwadratowego dla dowolnych liczb a, b, c.");
            Console.WriteLine("Podaj a: ");
            a = double.Parse(Console.ReadLine());

            if (a==0)
            {
                Console.WriteLine("Niedozwolona wartość współczynnika a. Naciśnij klawisz ENTER.");
                Console.Read();
                Environment.Exit(0); // wyjście z programu
            }

            else
            {
                Console.WriteLine("Podaj b: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c: ");
                c = double.Parse(Console.ReadLine());
            }
        }

        public void przetwórz_dane()
        {
            delta = b * b - 4 * a * c;

            if (delta < 0) liczba_pierwiastków = 0;
            if (delta == 0) liczba_pierwiastków = 1;
            if (delta > 0) liczba_pierwiastków = 2;

            switch (liczba_pierwiastków)
            {
                case 1: x1 = -b / (2 * a);
                    break;
                case 2:
                    {
                        x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    }
                    break;
            }
        }

        public void wyświetl_wynik()
        {
            Console.WriteLine("Dla wprowadzonych liczb a = {0:##.##}, b = {1:##.##}, c = {2:##.##}.", a, b, c);

            switch (liczba_pierwiastków)
            {
                case 0: Console.WriteLine("Brak pierwiastków rzeczywistych.");
                    break;
                case 1: Console.WriteLine("Trójmian kwadratowy ma jeden pierwiastek podwójny: x1 = {0:##.##}", x1);
                    break;
                case 2: Console.WriteLine("Trójmian kwadratowy ma dwa pierwiastki: x1 = {0:##.##} i x2 = {1:##.##}.", x1, x2);
                    break;
            }
        }

        public void wykonaj_zadanie()
        {
            RownanieKwadratowe rownaniekwadratowe = new RownanieKwadratowe();

            rownaniekwadratowe.czytaj_dane();
            rownaniekwadratowe.przetwórz_dane();
            rownaniekwadratowe.wyświetl_wynik();

        }
    }
}
