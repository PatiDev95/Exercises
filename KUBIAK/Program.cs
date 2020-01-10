using System;

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
            //Zadanie25();
            //Zadanie31();
            //Zadanie32();
            //Zadanie33();
            //Zadanie34();
            //Zadanie35();
            //Zadanie36();
            //Zadanie37();
            //Zadanie38();
            //Zadanie39();
            //Zadanie310();
            //Zadanie311();
            //Zadanie312();
            //Zadanie313();
            //Zadanie314();
            //Zadanie315();
            //Zadanie316();
            //Zadanie317();
            //Zadanie318();
            //Zadanie319();
            //Zadanie320();
            //Zadanie321();
            Zadanie322();
            Zadanie323();

       

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
            double a, b, c, x1, x2, delta;
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
        static void Zadanie31()
        {
            int x, y;

            Console.WriteLine("Program oblicza wartość funkcji y=3*x, dla x zmieniajacego się od 0 do 10. Z wykorzystaniem pętli for.");
            Console.WriteLine();

            for (x=0; x<=10; x++)
            {
                y = 3 * x;
                Console.WriteLine("x=" + x + " to" + '\t' + "y=" + y);
            }
        }
        static void Zadanie32()
        {
            int x=0, y=0;

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

        static void Zadanie33()
        {
            int x = 0, y = 0;

            Console.WriteLine("Program oblicza wartość funkcji y=3*x, dla x zmieniajacego się od 0 do 10. Z wykorzystaniem pętli while");
            Console.WriteLine();

            while (x<=10)
            {
                y = 3 * x;
                Console.WriteLine("x = " + x + '\t' + "y = " + y);
                x++;
            }
        }
        static void Zadanie34()
        {
            int x;

            Console.WriteLine("Program wyświetla liczby całkowite od 1 do 20.");
            Console.WriteLine();

            for (x=1; x<=20; x++)
            {
                if (x < 20)
                    Console.Write(x + ",");
                else
                    Console.Write(x + ".");
            }
        }
        static void Zadanie35()
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
        static void Zadanie36()
        {
            int x = 0;

            Console.WriteLine("Program wyświetla liczby całkowite od 1 do 20.");
            Console.WriteLine();

            while (x<=20)
            {
                if (x < 20)
                    Console.Write(x + ",");
                else
                    Console.Write(x + ".");
                x++;
            }
        }

        static void Zadanie37()
        {
            int x, suma = 0;

            Console.WriteLine("Program sumuje liczby całkowite od 1 do 100");

            for (x = 0; x <= 100; x++)
            {
                suma = suma + x;
            }
                Console.WriteLine("Suma liczb od 1 do 100 wynosi: " + suma + ".");
        }  

        static void Zadanie38()
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

        static void Zadanie39()
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

        static void Zadanie310()
        {
            int x, suma = 0;

            Console.WriteLine("Program sumuje liczby parzyste od 1 do 100");

            for (x = 1; x <= 100; x++) 
            {
                if (x % 2 == 0) suma += x;
            }
            Console.WriteLine("Suma liczb parzystych od 1 do 100 wynosi: " + suma);
        }

        static void Zadanie311()
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

        static void Zadanie312()
        {
            int x = 0, suma = 0;

            Console.WriteLine("Program sumuje liczby parzyste od 1 do 100");

            while (x<=100)
            {
                if (x % 2 == 0) suma += x;
                x++;
            }
            Console.WriteLine("Suma liczb parzystych od 1 do 100 wynosi: " + suma);
        }

        static void Zadanie313()
        {
            int x, suma = 0;

            Console.WriteLine("Zadanie 13 Suma liczb nieparzystych od 1 do 100");

            for (x = 1; x <= 100; x++)
            {
                if (!(x % 2 == 0)) suma = suma + x;
            }

            Console.WriteLine("Zadanie 13 Suma liczb nieparzystych to:" + suma);
        }

        static void Zadanie314()
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

        static void Zadanie315()
        {
            int x = 1, suma = 0;

            Console.WriteLine("Zadanie 15 Suma liczb nieparzystych od 1 do 100. (pętla while)");

            while (x<=100)
            {
                if (!(x % 2 == 00)) suma = suma + x;
                x++;
            }

            Console.WriteLine("Zadanie 15 Suma liczb nieparzystych od 1 do 100 wynosi:" + suma);
        }

        static void Zadanie316()

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
        static void Zadanie317()
        {
            int ilosc_liczb = 5, i=2;
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

       static void Zadanie318()
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

            while (i<=ilosc_liczb)
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

        static void Zadanie319()
        {
            int n = 10, wiersz, kolumna;

            Console.WriteLine("Program wyświetla tabliczkę mnożenia dla liczb od 1 do 100.");
            Console.WriteLine();

            for (wiersz = 1; wiersz <= n; wiersz++)
            {
                for(kolumna=1; kolumna<=n; kolumna++)
                {
                    Console.Write(wiersz * kolumna + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Zadanie320()
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
                    Console.Write(wiersz  * kolumna + "\t");
                    kolumna++;
                }
                while (kolumna <= n);

                wiersz++;
                Console.WriteLine();

            }
            while (wiersz <= n);

            Console.WriteLine();
        }

        static void Zadanie321()
        {
            int n=10,  wiersz, kolumna;

            Console.WriteLine("Program wyświetla tabliczkę mnożenia dla liczb od 1 do 100.");
            Console.WriteLine();

            wiersz = 1;

            while (wiersz<=n)
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

        static void Zadanie322()
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

        static void Zadanie323()
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
        }
}   }




