// Vlastní výjimka — dědí od Exception a přidává jen to, co potřebujeme
// navíc (tady požadovanou a dostupnou částku), aby je šlo v catch bloku
// přečíst a použít.
public class InsufficientFundsException : Exception
{
    public decimal Requested { get; }
    public decimal Available { get; }

    public InsufficientFundsException(decimal requested, decimal available)
        : base($"Nelze vybrat {requested} Kč, na účtu je jen {available} Kč.")
    {
        Requested = requested;
        Available = available;
    }
}
