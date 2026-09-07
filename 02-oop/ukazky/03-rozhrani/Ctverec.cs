public class Ctverec : ITvar
{
    public double Strana { get; }

    public Ctverec(double strana)
    {
        Strana = strana;
    }

    public double Obsah() => Strana * Strana;
}
