// Vlastní výjimka — dědí od Exception a přidává jen to, co potřebujeme
// navíc (tady požadovanou a dostupnou částku), aby je šlo v catch bloku
// přečíst a použít.
public class NedostatekPenezException : Exception
{
    public decimal Pozadovano { get; }
    public decimal Dostupno { get; }

    public NedostatekPenezException(decimal pozadovano, decimal dostupno)
        : base($"Nelze vybrat {pozadovano} Kč, na účtu je jen {dostupno} Kč.")
    {
        Pozadovano = pozadovano;
        Dostupno = dostupno;
    }
}
