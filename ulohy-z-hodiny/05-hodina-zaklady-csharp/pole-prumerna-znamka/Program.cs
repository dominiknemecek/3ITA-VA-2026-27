using System;

class Program
{
    static void Main()
    {
        // Pole (array) — pevná velikost, daná hned při vytvoření.
        int[] znamky = { 2, 1, 3, 1, 2, 4, 1 };

        int soucet = 0;
        foreach (int znamka in znamky)
        {
            soucet += znamka;
        }
        double prumer = (double)soucet / znamky.Length;

        Console.WriteLine($"Počet známek: {znamky.Length}");
        Console.WriteLine($"Průměr: {prumer:F2}");

        // U známek nižší číslo znamená lepší výsledek
        Console.Write("Známky lepší než průměr: ");
        foreach (int znamka in znamky)
        {
            if (znamka < prumer)
                Console.Write(znamka + " ");
        }
        Console.WriteLine();
    }
}
