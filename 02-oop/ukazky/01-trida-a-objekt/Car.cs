// Vlastní třída s konstruktorem a zapouzdřením.
//
// "mileageKm" je private pole — zvenčí třídy se k němu nedá sáhnout přímo.
// Přístup jde jen přes veřejnou property "MileageKm", která navíc hlídá,
// aby se hodnota nikdy nesnížila (to je smysl zapouzdření: třída si sama
// hlídá, v jakém stavu smí být).
public class Car
{
    private int mileageKm;

    public string Brand { get; }
    public string Model { get; }

    public int MileageKm
    {
        get => mileageKm;
        set
        {
            if (value < mileageKm)
            {
                throw new ArgumentException("Počet najetých km nemůže klesnout.");
            }
            mileageKm = value;
        }
    }

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
        mileageKm = 0;
    }

    public void Drive(int kilometers)
    {
        MileageKm += kilometers;
    }

    public override string ToString() => $"{Brand} {Model} ({MileageKm} km)";
}
