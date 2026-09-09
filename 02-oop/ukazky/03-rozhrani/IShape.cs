// Rozhraní (interface) předepisuje jen CO třída umí, ne JAK to udělá —
// na rozdíl od dědičnosti (viz 02-dedicnost) tu nejde o "je to", ale
// o "umí to". Třída může implementovat libovolně rozhraní, ale dědit
// jen od jedné základní třídy.
public interface IShape
{
    double Area();
}
