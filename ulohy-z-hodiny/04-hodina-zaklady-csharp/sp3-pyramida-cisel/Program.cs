using System;

class Program
{
    static void Main()
    {
        byte pocetRadku = 5;

        for (int radek = 1; radek <= pocetRadku; radek++)
        {
            // Úvodní mezery jen pro vycentrování pyramidy
            for (int mezera = 0; mezera < pocetRadku - radek; mezera++)
                Console.Write(" ");

            // Na každém řádku vypíšeme čísla 1 až radek
            for (int cislo = 1; cislo <= radek; cislo++)
                Console.Write(cislo + " ");

            Console.WriteLine();
        }
    }
}
