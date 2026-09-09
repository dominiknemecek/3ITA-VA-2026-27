// Podmínky a cykly — základní řídicí struktury programu.
class Program
{
    static void Main()
    {
        Console.Write("Zadej známku (1-5): ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            // switch výraz — přehlednější než dlouhý řetězec if/else if, když
            // rozhodujeme podle konkrétních hodnot jedné proměnné.
            string gradeText = grade switch
            {
                1 => "výborný",
                2 => "chvalitebný",
                3 => "dobrý",
                4 => "dostatečný",
                5 => "nedostatečný",
                _ => "neplatná známka",
            };
            Console.WriteLine($"Slovně: {gradeText}");
        }

        // for — když dopředu víme, kolikrát se má cyklus opakovat.
        Console.WriteLine("\nMalá násobilka sedmi:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"7 × {i} = {7 * i}");
        }

        // while — když počet opakování dopředu neznáme a končíme podle podmínky.
        Console.WriteLine("\nZadávej čísla, konec zadáš jako 0:");
        int sum = 0;
        int number;
        do
        {
            Console.Write("Číslo: ");
            int.TryParse(Console.ReadLine(), out number);
            sum += number;
        } while (number != 0);
        Console.WriteLine($"Součet zadaných čísel: {sum}");

        // foreach — když procházíme prvky nějaké kolekce (pole, list, ...).
        string[] subjects = { "Matematika", "Programování", "Angličtina" };
        Console.WriteLine("\nRozvrh:");
        foreach (string subject in subjects)
        {
            Console.WriteLine($"- {subject}");
        }
    }
}
