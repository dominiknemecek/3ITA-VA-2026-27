// Základní (bázová) třída — obsahuje to, co mají všechna zvířata společné.
public class Animal
{
    public string Name { get; }

    public Animal(string name)
    {
        Name = name;
    }

    // "virtual" říká: potomci smí tuhle metodu přepsat vlastní verzí.
    public virtual string Sound() => "...";

    public void Introduce()
    {
        // Sound() se zavolá podle skutečného typu objektu (Dog/Cat),
        // i když je proměnná typu Animal — tomu se říká polymorfismus.
        Console.WriteLine($"{Name} dělá: {Sound()}");
    }
}
