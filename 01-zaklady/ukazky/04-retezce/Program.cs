// string v C# je samostatný, neměnný (immutable) typ — na rozdíl od
// C je to plnohodnotný objekt s vlastními metodami, ne pole znaků.

string veta = "Ahoj, světe programování!";

Console.WriteLine($"Délka: {veta.Length} znaků");
Console.WriteLine($"Velkými písmeny: {veta.ToUpper()}");
Console.WriteLine($"Obsahuje 'světe': {veta.Contains("světe")}");

// Každá metoda vrací NOVÝ string, původní "veta" se nezmění — proto se
// výsledek musí uložit do proměnné, jinak by se ztratil.
string bezCarky = veta.Replace(",", "");
Console.WriteLine($"Bez čárky: {bezCarky}");

// Split rozdělí text podle oddělovače na pole podřetězců.
string[] slova = veta.Split(' ');
Console.WriteLine($"Počet slov: {slova.Length}");
foreach (string slovo in slova)
{
    Console.WriteLine($" - {slovo}");
}

// Trim odstraní mezery na začátku/konci — typické pro čištění vstupu
// od uživatele před dalším zpracováním.
string sMezerami = "   nazdar   ";
Console.WriteLine($"[{sMezerami.Trim()}]");
