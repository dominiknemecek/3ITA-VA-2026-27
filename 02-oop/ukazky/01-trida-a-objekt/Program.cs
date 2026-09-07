Auto auto = new Auto("Škoda", "Octavia");
Console.WriteLine(auto);

auto.Najeto(150);
auto.Najeto(80);
Console.WriteLine(auto);

try
{
    auto.NajetoKm = 100; // méně než už má najeto — property to odmítne
}
catch (ArgumentException chyba)
{
    Console.WriteLine($"Chyba: {chyba.Message}");
}
