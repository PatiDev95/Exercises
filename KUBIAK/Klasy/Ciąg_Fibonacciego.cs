using System;

namespace KUBIAK
{
    class Ciąg_Fibonacciego
    {
        public int Licz_ciągF(int n)
        {
            switch (n)
            {
                case 0: return 0;
                case 1: return 1;
                default: return Licz_ciągF(n - 1) + Licz_ciągF(n - 2);
            }
        }

        public void Wykonaj_zadanie()
        {
            int i, n = 10;
            Ciąg_Fibonacciego ciąg_Fibonacciego = new Ciąg_Fibonacciego();

            Console.WriteLine("Program znajduje rekurencyjnie " + n + " pierwszych liczb Fibonacciego");
            Console.WriteLine();

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(ciąg_Fibonacciego.Licz_ciągF(i) + " ");
            }
        }
    }
}
