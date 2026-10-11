using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary<KlíčovýTyp, HodnotovýTyp> — páry klíč -> hodnota.
        // Na rozdíl od pole se nepřistupuje přes číselný index, ale přes klíč.
        Dictionary<string, string> telefonniSeznam = new Dictionary<string, string>
        {
            { "Adam", "777 123 456" },
            { "Bára", "604 987 654" },
            { "Cyril", "608 222 333" },
        };

        // Přidání nového záznamu — pokud klíč ještě neexistuje, vznikne nový
        telefonniSeznam["David"] = "721 555 111";

        Console.WriteLine("Celý seznam:");
        foreach (KeyValuePair<string, string> zaznam in telefonniSeznam)
        {
            Console.WriteLine($"{zaznam.Key}: {zaznam.Value}");
        }

        // ContainsKey ověří existenci klíče předem, aby přístup přes [klíč]
        // nespadl s výjimkou, pokud klíč v seznamu není.
        string jmeno = "Bára";
        if (telefonniSeznam.ContainsKey(jmeno))
        {
            Console.WriteLine($"\nTelefon na {jmeno}: {telefonniSeznam[jmeno]}");
        }
        else
        {
            Console.WriteLine($"\n{jmeno} v seznamu není.");
        }
    }
}
