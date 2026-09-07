namespace PrvniOkno;

// Vlastní logika okna. Rozložení prvků (co kde je, jak je velké) je
// v Form1.Designer.cs — do toho souboru se ručně nezasahuje, generuje
// a upravuje ho Návrhář formulářů (Form Designer) ve Visual Studiu.
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // Metoda napojená na událost Click tlačítka tlacitkoPozdrav
    // (propojení vidíte v Form1.Designer.cs).
    private void tlacitkoPozdrav_Click(object sender, EventArgs e)
    {
        popisekVysledek.Text = $"Ahoj, {textJmeno.Text}!";
    }
}
