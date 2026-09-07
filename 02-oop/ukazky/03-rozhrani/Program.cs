// Pole typu ITvar — každý prvek je jiná třída (Ctverec, Kruh), ale
// všechny umí Obsah(), tak s nimi můžeme pracovat jednotně.
ITvar[] tvary = { new Ctverec(4), new Kruh(3) };

double celkovyObsah = 0;
foreach (ITvar tvar in tvary)
{
    Console.WriteLine($"{tvar.GetType().Name}: obsah = {tvar.Obsah():F2}");
    celkovyObsah += tvar.Obsah();
}

Console.WriteLine($"Celkový obsah všech tvarů: {celkovyObsah:F2}");
