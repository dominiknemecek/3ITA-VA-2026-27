// Základní (bázová) třída — obsahuje to, co mají všechna zvířata společné.
public class Zvire
{
    public string Jmeno { get; }

    public Zvire(string jmeno)
    {
        Jmeno = jmeno;
    }

    // "virtual" říká: potomci smí tuhle metodu přepsat vlastní verzí.
    public virtual string Zvuk() => "...";

    public void PredstavSe()
    {
        // Zvuk() se zavolá podle skutečného typu objektu (Pes/Kocka),
        // i když je proměnná typu Zvire — tomu se říká polymorfismus.
        Console.WriteLine($"{Jmeno} dělá: {Zvuk()}");
    }
}
