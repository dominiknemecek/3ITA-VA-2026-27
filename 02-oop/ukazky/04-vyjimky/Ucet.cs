public class Ucet
{
    public decimal Zustatek { get; private set; }

    public Ucet(decimal pocatecniZustatek)
    {
        Zustatek = pocatecniZustatek;
    }

    public void Vyber(decimal castka)
    {
        if (castka > Zustatek)
        {
            // "throw" okamžitě přeruší běh metody a předá výjimku volajícímu
            // kódu — dál se nevykoná ani řádek Zustatek -= castka.
            throw new NedostatekPenezException(castka, Zustatek);
        }

        Zustatek -= castka;
    }
}
