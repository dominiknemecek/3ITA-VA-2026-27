class Program
{
    static void Main()
    {
        Account account = new Account(500);

        try
        {
            account.Withdraw(200);
            Console.WriteLine($"Po výběru 200: zůstatek {account.Balance} Kč");

            account.Withdraw(1000); // tohle vyhodí InsufficientFundsException
            Console.WriteLine("Tenhle řádek se už nikdy nevypíše.");
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Chyba: {ex.Message}");
            Console.WriteLine($"Chybělo {ex.Requested - ex.Available} Kč.");
        }
        finally
        {
            // "finally" se provede vždy — ať výjimka nastala, nebo ne. Hodí se
            // pro úklid (např. zavření souboru), ne pro logiku závislou na chybě.
            Console.WriteLine($"Konečný zůstatek: {account.Balance} Kč");
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
    }
}
