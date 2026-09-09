class Program
{
    static void Main()
    {
        Car car = new Car("Škoda", "Octavia");
        Console.WriteLine(car);

        car.Drive(150);
        car.Drive(80);
        Console.WriteLine(car);

        try
        {
            car.MileageKm = 100; // méně než už má najeto — property to odmítne
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Chyba: {ex.Message}");
        }
    }
}
