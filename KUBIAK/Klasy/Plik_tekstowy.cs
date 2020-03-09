using System;
using System.IO;

namespace KUBIAK
{
    class Plik_tekstowy
    {
        String dane,    // zmienna dane przechowuje dane przed zapisem do pliku tekstowego, 
               dane1;   // a zmienna dane1 przechowuje dane odczytane z pliku tekstowego.
        FileStream fout, fin;

        public void Czytaj_dane()
        {
            Console.WriteLine("Wpisujemy dane do pliku tekstowego.");
            Console.WriteLine("Podaj imię i nazwisko");
            dane = Console.ReadLine();
        }

        public void Zapisz_dane_do_pliku()
        {
            fout = new FileStream("dane.txt", FileMode.Create); //tworzymy strumień znaków połączonych z plikiem tekstowym w trybie Create
            StreamWriter fstr_out = new StreamWriter(fout); //tworzymy strumień wyjściowy
            fstr_out.Write(dane); //zapisujemy łańcuch do pliku
            fstr_out.Close(); //zamykamy zapis
            fout.Close(); //zamykamy plik

        }

        public void Czytaj_dane_z_pliku()
        {
            Console.WriteLine();
            Console.WriteLine("Oczytujemy dane z pliku tekstowego");

            fin = new FileStream("dane.txt", FileMode.Open);  //tworzymy strumień znaków połączonych z plikiem tekstowym w trybie Open
            StreamReader fstr_in = new StreamReader(fin); //tworzymy strumień wejściowy
            while ((dane1 = fstr_in.ReadLine()) !=null) //odczytujemy dane z pliku, aż napotkamy koniec
            {
                Console.WriteLine(dane1);
            }
            fstr_in.Close(); //zamykamy odczyt
            fin.Close(); //zamykamy plik
        }

        public void Wykonaj_Zadanie()
        {
            Plik_tekstowy plik_tekstowy = new Plik_tekstowy(); //deklaracja zmiennej, utworzenie obiektu i przypisanie go do zmiennej

            plik_tekstowy.Czytaj_dane();
            plik_tekstowy.Zapisz_dane_do_pliku();
            plik_tekstowy.Czytaj_dane_z_pliku();
        }
    }
}
