public class Kruh : ITvar
{
    public double Polomer { get; }

    public Kruh(double polomer)
    {
        Polomer = polomer;
    }

    public double Obsah() => Math.PI * Polomer * Polomer;
}
