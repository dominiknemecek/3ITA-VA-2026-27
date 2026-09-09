// string v C# je samostatný, neměnný (immutable) typ — na rozdíl od
// C je to plnohodnotný objekt s vlastními metodami, ne pole znaků.
class Program
{
    static void Main()
    {
        string sentence = "Ahoj, světe programování!";

        Console.WriteLine($"Délka: {sentence.Length} znaků");
        Console.WriteLine($"Velkými písmeny: {sentence.ToUpper()}");
        Console.WriteLine($"Obsahuje 'světe': {sentence.Contains("světe")}");

        // Každá metoda vrací NOVÝ string, původní "sentence" se nezmění —
        // proto se výsledek musí uložit do proměnné, jinak by se ztratil.
        string withoutComma = sentence.Replace(",", "");
        Console.WriteLine($"Bez čárky: {withoutComma}");

        // Split rozdělí text podle oddělovače na pole podřetězců.
        string[] words = sentence.Split(' ');
        Console.WriteLine($"Počet slov: {words.Length}");
        foreach (string word in words)
        {
            Console.WriteLine($" - {word}");
        }

        // Trim odstraní mezery na začátku/konci — typické pro čištění vstupu
        // od uživatele před dalším zpracováním.
        string withSpaces = "   nazdar   ";
        Console.WriteLine($"[{withSpaces.Trim()}]");
    }
}
