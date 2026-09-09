class Program
{
    static void Main()
    {
        // Pole typu IShape — každý prvek je jiná třída (Square, Circle), ale
        // všechny umí Area(), tak s nimi můžeme pracovat jednotně.
        IShape[] shapes = { new Square(4), new Circle(3) };

        double totalArea = 0;
        foreach (IShape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name}: obsah = {shape.Area():F2}");
            totalArea += shape.Area();
        }

        Console.WriteLine($"Celkový obsah všech tvarů: {totalArea:F2}");
    }
}
