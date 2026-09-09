// ": Animal" znamená, že Dog dědí od Animal — má vše, co Animal, a navíc
// přepisuje (override) metodu Sound() vlastní implementací.
public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override string Sound() => "Haf!";
}
