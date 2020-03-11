using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace KUBIAK
{
    class Serializacja
    {
        double[] pomiary = { 10.17, 12.83, 11.78, 15.23, 11.08, 13.67 };

        public void Zapisz_czytaj_dane()
        {
            Console.WriteLine("Wszystkie pomiary: ");
            for (int i = 0; i < pomiary.Length; i++)
                Console.WriteLine(pomiary[i] + " ");

            Stream StreamWrite = new FileStream("pomiary.dat", FileMode.Create); //Utworzenie pliku, który będzie zawierał strumienie danych

            BinaryFormatter BinaryWriter = new BinaryFormatter(); //Utworzenie obiektu typu BinaryFormatter
            BinaryWriter.Serialize(StreamWrite, pomiary); //Serializacja - przekształcenie obiektu w strumień bajtów.
            StreamWrite.Close(); //Zamknięcie strumienia.

            Console.WriteLine();
            Console.WriteLine("Co drugi pomiar odczytany z pliku pomiary.dat: ");

            Stream StreamRead = new FileStream("pomiary.dat", FileMode.Open); //Otwarcie pliku, który zawiera strumień danych.

            BinaryFormatter BinaryReader = new BinaryFormatter();

            pomiary = (double[])BinaryReader.Deserialize(StreamRead); //Deserializacja i rzutowanie

            for (int i = 0; i < pomiary.Length; i += 2)
                Console.WriteLine(pomiary[i] + " ");

            StreamRead.Close(); //Zamknięcie strumienia.
        }

        public void Wykonaj_zadanie()
        {
            Serializacja serializacja = new Serializacja();

            serializacja.Zapisz_czytaj_dane();
        }
    }
}
