// Pole (array) — pevně velká sada hodnot stejného typu, indexovaná od 0.
class Program
{
    static void Main()
    {
        int[] numbers = { 12, 45, 7, 88, 23 };

        // foreach — když jen procházíme prvky a nepotřebujeme jejich index.
        Console.Write("Pole obsahuje:");
        foreach (int number in numbers)
        {
            Console.Write($" {number}");
        }
        Console.WriteLine();

        // Klasický for se hodí, když index sám potřebujeme (např. při hledání
        // pozice maxima, ne jen jeho hodnoty).
        int maxIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[maxIndex])
            {
                maxIndex = i;
            }
        }
        Console.WriteLine($"Maximum je {numbers[maxIndex]} na indexu {maxIndex}.");

        // Pole v C# má vestavěné pomocníky — třída Array a metody jako Sum/Max
        // z System.Linq (u jednoduchých čísel se to hodí místo ručního cyklu).
        Console.WriteLine($"Součet: {numbers.Sum()}, průměr: {numbers.Average():F1}");

        int[] sorted = (int[])numbers.Clone();
        Array.Sort(sorted);
        Console.WriteLine($"Seřazeno: {string.Join(", ", sorted)}");
    }
}
