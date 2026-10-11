using System;

class Program
{
    static void Main()
    {
        byte pocetSchodu = 6;

        for (int i = 1; i <= pocetSchodu; i++)
        {
            // Mezery zleva zajistí, že schody "rostou" směrem doprava dolů
            for (int mezera = 0; mezera < pocetSchodu - i; mezera++)
                Console.Write(" ");

            for (int schod = 0; schod < i; schod++)
                Console.Write("##");

            Console.WriteLine();
        }
    }
}
