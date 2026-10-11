using System;

class Program
{
    static void Main()
    {
        byte size = 5; // polovina výšky diamantu (celková výška = 2*size - 1)

        // Horní polovina — počet hvězdiček s každým řádkem roste
        for (int i = 1; i <= size; i++)
        {
            for (int mezera = 0; mezera < size - i; mezera++)
                Console.Write(" ");
            for (int hvezda = 0; hvezda < 2 * i - 1; hvezda++)
                Console.Write("*");
            Console.WriteLine();
        }

        // Dolní polovina — zrcadlový obraz horní, bez prostředního řádku
        for (int i = size - 1; i >= 1; i--)
        {
            for (int mezera = 0; mezera < size - i; mezera++)
                Console.Write(" ");
            for (int hvezda = 0; hvezda < 2 * i - 1; hvezda++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}
