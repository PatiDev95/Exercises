using System;
using System.Collections.Generic;
using System.Text;

namespace KUBIAK
{
    class Silnia
    {
        public static int Utwórz_silnię(int liczba)
        {
            int zwrot = 1;
            if (liczba>=2)
            {
                zwrot = liczba * Utwórz_silnię(liczba - 1);
            }
            return zwrot;
        }

        public void Wykonaj_Zadanie()
        {
            int i, n;

            Silnia silnia = new Silnia();

            Console.WriteLine("Oblicznaie silni dla dowolnej liczby całkowitej:");
            Console.WriteLine("Podaj n: ");
            n = int.Parse(Console.ReadLine());

            for(i=1;i<=n;i++)
            {
                Console.WriteLine(" " + i + "! = " + Silnia.Utwórz_silnię(i));
            }
        }
    }
}
