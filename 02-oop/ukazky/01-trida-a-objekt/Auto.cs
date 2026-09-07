// Vlastní třída s konstruktorem a zapouzdřením.
//
// "najetoKm" je private pole — zvenčí třídy se k němu nedá sáhnout přímo.
// Přístup jde jen přes veřejnou property "NajetoKm", která navíc hlídá,
// aby se hodnota nikdy nesnížila (to je smysl zapouzdření: třída si sama
// hlídá, v jakém stavu smí být).
public class Auto
{
    private int najetoKm;

    public string Znacka { get; }
    public string Model { get; }

    public int NajetoKm
    {
        get => najetoKm;
        set
        {
            if (value < najetoKm)
            {
                throw new ArgumentException("Počet najetých km nemůže klesnout.");
            }
            najetoKm = value;
        }
    }

    public Auto(string znacka, string model)
    {
        Znacka = znacka;
        Model = model;
        najetoKm = 0;
    }

    public void Najeto(int kilometru)
    {
        NajetoKm += kilometru;
    }

    public override string ToString() => $"{Znacka} {Model} ({NajetoKm} km)";
}
