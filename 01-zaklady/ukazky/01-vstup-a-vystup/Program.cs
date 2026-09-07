// Základní datové typy a práce se vstupem/výstupem v konzoli.

string jmeno = "Jan";       // text
int vek = 17;                // celé číslo
double vyska = 178.5;        // desetinné číslo
bool jeStudent = true;       // pravda/nepravda

Console.WriteLine($"{jmeno}, {vek} let, výška {vyska} cm, student: {jeStudent}");

// Načtení vstupu od uživatele — Console.ReadLine() vrací vždy string,
// pokud potřebujeme číslo, musíme ho převést (parsovat).
Console.Write("Zadej svůj věk: ");
string? vstup = Console.ReadLine();

// int.TryParse nespadne na neplatném vstupu (např. písmena) — vrátí false
// a do "zadanyVek" dá 0, místo aby program shodil výjimkou.
if (int.TryParse(vstup, out int zadanyVek))
{
    int zaRokBudes = zadanyVek + 1;
    Console.WriteLine($"Za rok ti bude {zaRokBudes}.");
}
else
{
    Console.WriteLine("To nevypadá jako platné číslo.");
}
