using System;
using System.IO;

namespace KUBIAK
{
    class Macierz_pliki_tekstowe
    {
        FileStream fout, fin;

        public void Czytaj_dane(int[,] tablica, int rozmiar)
        {
            int i, j;

            Console.WriteLine("Tworzymy tablicę 10x10.");
            Console.WriteLine();

            for (i = 0; i < rozmiar; i++)
            {
                for (j = 0; j < rozmiar; j++)
                {
                    if (i == j)
                        tablica[i, j] = 1;
                    else
                        tablica[i, j] = 0;
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void Zapisz_dane_do_pliku(int[,] tablica, int rozmiar)
        {
            int i, j;

            Console.WriteLine("Zapisujemy tablicę 10x10 do pliku tekstowego.");
            Console.WriteLine();

            fout = new FileStream("dane.txt", FileMode.Create);
            StreamWriter fstr_out = new StreamWriter(fout);


            for (i = 0; i < rozmiar; i++)
            {
                for (j = 0; j < rozmiar; j++)
                {
                    fstr_out.Write((char)tablica[i, j]); //rzutujmey i zapisujemy tablicę do pliku (zmianiając typ wartościowości)

                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }

            fstr_out.Close();
            fout.Close();

        }

        public void Czytaj_dane_z_pliku(int[,] tablica1, int rozmiar)
        {
            int i, j;

            Console.WriteLine();

            Console.WriteLine("Odczytujemy tablicę 10x10 z pliku tekstowego.");
            Console.WriteLine();

            fin = new FileStream("dane.txt", FileMode.Open);
            StreamReader fstr_in = new StreamReader(fin);

            for (i = 0; i < rozmiar; i++)
            {
                for (j = 0; j < rozmiar; j++)
                {
                    tablica1[i, j] = (int)fstr_in.Read(); //rzutujemy i zapisujemy zawartość pliku do tablicy1 (zmianiając typ wartościowości)
                    Console.Write(tablica1[i, j] + " ");
                }
                Console.WriteLine();
            }

            fstr_in.Close();
            fin.Close();
        }

        public void Wykonaj_zadanie()
        {
            const int rozmiar = 10;
            int[,] tablica = new int[rozmiar, rozmiar];
            int[,] tablica1 = new int[rozmiar, rozmiar];

            Macierz_pliki_tekstowe macierz_pliki_tekstowe = new Macierz_pliki_tekstowe();

            macierz_pliki_tekstowe.Czytaj_dane(tablica, rozmiar);
            macierz_pliki_tekstowe.Zapisz_dane_do_pliku(tablica, rozmiar);
            macierz_pliki_tekstowe.Czytaj_dane_z_pliku(tablica, rozmiar);
        }
    }
}
