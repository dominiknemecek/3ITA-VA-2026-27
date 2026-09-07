// Podmínky a cykly — základní řídicí struktury programu.

Console.Write("Zadej známku (1-5): ");
if (int.TryParse(Console.ReadLine(), out int znamka))
{
    // switch výraz — přehlednější než dlouhý řetězec if/else if, když
    // rozhodujeme podle konkrétních hodnot jedné proměnné.
    string slovne = znamka switch
    {
        1 => "výborný",
        2 => "chvalitebný",
        3 => "dobrý",
        4 => "dostatečný",
        5 => "nedostatečný",
        _ => "neplatná známka",
    };
    Console.WriteLine($"Slovně: {slovne}");
}

// for — když dopředu víme, kolikrát se má cyklus opakovat.
Console.WriteLine("\nMalá násobilka sedmi:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"7 × {i} = {7 * i}");
}

// while — když počet opakování dopředu neznáme a končíme podle podmínky.
Console.WriteLine("\nZadávej čísla, konec zadáš jako 0:");
int soucet = 0;
int cislo;
do
{
    Console.Write("Číslo: ");
    int.TryParse(Console.ReadLine(), out cislo);
    soucet += cislo;
} while (cislo != 0);
Console.WriteLine($"Součet zadaných čísel: {soucet}");

// foreach — když procházíme prvky nějaké kolekce (pole, list, ...).
string[] predmety = { "Matematika", "Programování", "Angličtina" };
Console.WriteLine("\nRozvrh:");
foreach (string predmet in predmety)
{
    Console.WriteLine($"- {predmet}");
}
