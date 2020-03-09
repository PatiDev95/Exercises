using System;
using System.IO;

namespace KUBIAK
{
    class Macierz_pliki_tekstowe2
    {
        FileStream fout, fin;

        public void Czytaj_dane(int[,] tablicaA, int rozmiar)
        {
            int i, j;

            Console.WriteLine("Tworzymy tablicę A.");
            Console.WriteLine();

            for (i = 0; i < rozmiar; i++)
            {
                for (j = 0; j < rozmiar; j++)
                {
                    
                    if (j == 0) tablicaA[i, j] = 0;
                    if (j == 1) tablicaA[i, j] = 1;
                    if (j > 1) tablicaA[i, j] = 0;

                    Console.Write(tablicaA[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void Przetwórz_dane(int[,] tablicaA, int[,] tablicaB, int rozmiar)
        {
            int i, j;

            Console.WriteLine();
            Console.WriteLine("Przepisujemy zawrtość tablicy A do tablicy B");
            Console.WriteLine();

            for (i = 0; i < rozmiar; i++)
            {
                for (j = 0; j < rozmiar; j++)
                {
                    tablicaB[i, j] = tablicaA[j, i];

                    Console.Write(tablicaB[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void Zapisz_dane_do_pliku(int[,] tablicaB, int rozmiar)
        {
            int i, j;

            Console.WriteLine("Zapisujemy tablicę B do pliku tekstowego.");
            Console.WriteLine();

            fout = new FileStream("dane.txt", FileMode.Create);
            StreamWriter fstr_out = new StreamWriter(fout);


            for (i = 0; i < rozmiar; i++)
            {
                for (j = 0; j < rozmiar; j++)
                {
                    fstr_out.Write((char)tablicaB[i, j]); //rzutujmey i zapisujemy tablicę do pliku (zmianiając typ wartościowości)

                    Console.Write(tablicaB[i, j] + " ");
                }
                Console.WriteLine();
            }

            fstr_out.Close();
            fout.Close();

        }

        public void Czytaj_dane_z_pliku(int[,] tablicaC, int rozmiar)
        {
            int i, j;

            Console.WriteLine();

            Console.WriteLine("Odczytujemy tablicę C z pliku tekstowego.");
            Console.WriteLine();

            fin = new FileStream("dane.txt", FileMode.Open);
            StreamReader fstr_in = new StreamReader(fin);

            for (i = 0; i < rozmiar; i++)
            {
                for (j = 0; j < rozmiar; j++)
                {
                    tablicaC[i, j] = (int)fstr_in.Read(); //rzutujemy i zapisujemy zawartość pliku do tablicy1 (zmianiając typ wartościowości)
                    Console.Write(tablicaC[i, j] + " ");
                }
                Console.WriteLine();
            }

            fstr_in.Close();
            fin.Close();
        }

        public void Wykonaj_zadanie()
        {
            const int rozmiar = 10;
            int[,] tablicaA = new int[rozmiar, rozmiar];
            int[,] tablicaB = new int[rozmiar, rozmiar];
            int[,] tablicaC = new int[rozmiar, rozmiar];

            Macierz_pliki_tekstowe2 macierz_pliki_tekstowe2 = new Macierz_pliki_tekstowe2();

            macierz_pliki_tekstowe2.Czytaj_dane(tablicaA, rozmiar);
            macierz_pliki_tekstowe2.Przetwórz_dane(tablicaA, tablicaB, rozmiar);
            macierz_pliki_tekstowe2.Zapisz_dane_do_pliku(tablicaB, rozmiar);
            macierz_pliki_tekstowe2.Czytaj_dane_z_pliku(tablicaC, rozmiar);
        }
    }
}