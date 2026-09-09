// Základní datové typy a práce se vstupem/výstupem v konzoli.
class Program
{
    static void Main()
    {
        string name = "Jan";        // text
        int age = 17;                // celé číslo
        double height = 178.5;       // desetinné číslo
        bool isStudent = true;       // pravda/nepravda

        Console.WriteLine($"{name}, {age} let, výška {height} cm, student: {isStudent}");

        // Načtení vstupu od uživatele — Console.ReadLine() vrací vždy string,
        // pokud potřebujeme číslo, musíme ho převést (parsovat).
        Console.Write("Zadej svůj věk: ");
        string? input = Console.ReadLine();

        // int.TryParse nespadne na neplatném vstupu (např. písmena) — vrátí false
        // a do "enteredAge" dá 0, místo aby program shodil výjimkou.
        if (int.TryParse(input, out int enteredAge))
        {
            int nextYearAge = enteredAge + 1;
            Console.WriteLine($"Za rok ti bude {nextYearAge}.");
        }
        else
        {
            Console.WriteLine("To nevypadá jako platné číslo.");
        }
    }
}
