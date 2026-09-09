class Program
{
    static void Main()
    {
        // Pole typu Animal, ale prvky jsou skutečně Dog a Cat — polymorfismus:
        // každý objekt "ví", jaký zvuk vydat, i když s nimi pracujeme přes
        // společný typ Animal.
        Animal[] animals = { new Dog("Rex"), new Cat("Micka") };

        foreach (Animal animal in animals)
        {
            animal.Introduce();
        }
    }
}
