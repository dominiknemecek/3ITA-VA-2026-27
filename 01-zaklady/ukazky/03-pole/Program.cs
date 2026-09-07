// Pole (array) — pevně velká sada hodnot stejného typu, indexovaná od 0.

int[] cisla = { 12, 45, 7, 88, 23 };

// foreach — když jen procházíme prvky a nepotřebujeme jejich index.
Console.Write("Pole obsahuje:");
foreach (int cislo in cisla)
{
    Console.Write($" {cislo}");
}
Console.WriteLine();

// Klasický for se hodí, když index sám potřebujeme (např. při hledání
// pozice maxima, ne jen jeho hodnoty).
int indexMaxima = 0;
for (int i = 1; i < cisla.Length; i++)
{
    if (cisla[i] > cisla[indexMaxima])
    {
        indexMaxima = i;
    }
}
Console.WriteLine($"Maximum je {cisla[indexMaxima]} na indexu {indexMaxima}.");

// Pole v C# má vestavěné pomocníky — třída Array a metody jako Sum/Max
// z System.Linq (u jednoduchých čísel se to hodí místo ručního cyklu).
Console.WriteLine($"Součet: {cisla.Sum()}, průměr: {cisla.Average():F1}");

int[] serazeno = (int[])cisla.Clone();
Array.Sort(serazeno);
Console.WriteLine($"Seřazeno: {string.Join(", ", serazeno)}");
