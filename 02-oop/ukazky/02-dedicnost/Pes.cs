// ": Zvire" znamená, že Pes dědí od Zvire — má vše, co Zvire, a navíc
// přepisuje (override) metodu Zvuk() vlastní implementací.
public class Pes : Zvire
{
    public Pes(string jmeno) : base(jmeno) { }

    public override string Zvuk() => "Haf!";
}
