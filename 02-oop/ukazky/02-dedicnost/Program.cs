// Pole typu Zvire, ale prvky jsou skutečně Pes a Kocka — polymorfismus:
// každý objekt "ví", jaký zvuk vydat, i když s nimi pracujeme přes
// společný typ Zvire.
Zvire[] zvirata = { new Pes("Rex"), new Kocka("Micka") };

foreach (Zvire zvire in zvirata)
{
    zvire.PredstavSe();
}
