Ucet ucet = new Ucet(500);

try
{
    ucet.Vyber(200);
    Console.WriteLine($"Po výběru 200: zůstatek {ucet.Zustatek} Kč");

    ucet.Vyber(1000); // tohle vyhodí NedostatekPenezException
    Console.WriteLine("Tenhle řádek se už nikdy nevypíše.");
}
catch (NedostatekPenezException chyba)
{
    Console.WriteLine($"Chyba: {chyba.Message}");
    Console.WriteLine($"Chybělo {chyba.Pozadovano - chyba.Dostupno} Kč.");
}
finally
{
    // "finally" se provede vždy — ať výjimka nastala, nebo ne. Hodí se
    // pro úklid (např. zavření souboru), ne pro logiku závislou na chybě.
    Console.WriteLine($"Konečný zůstatek: {ucet.Zustatek} Kč");
}

// Vestavěná výjimka DivideByZeroException — celočíselné dělení nulou
// v C# nevrací "nekonečno" jako u double, ale rovnou spadne.
try
{
    int a = 10;
    int b = 0;
    Console.WriteLine(a / b);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Dělení nulou není povolené.");
}
