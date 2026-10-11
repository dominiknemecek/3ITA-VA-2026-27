using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List<T> — na rozdíl od pole může za běhu měnit velikost (Add/Remove).
        List<string> ukoly = new List<string>();

        ukoly.Add("Napsat domácí úkol");
        ukoly.Add("Naučit se na test");
        ukoly.Add("Procvičit cykly");

        Console.WriteLine($"Počet úkolů: {ukoly.Count}");
        Console.WriteLine("Seznam úkolů:");
        for (int i = 0; i < ukoly.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {ukoly[i]}");
        }

        // Odebrání konkrétní položky podle hodnoty (ne podle indexu)
        ukoly.Remove("Naučit se na test");

        Console.WriteLine("\nPo splnění jednoho úkolu:");
        foreach (string ukol in ukoly)
        {
            Console.WriteLine($"- {ukol}");
        }
    }
}
