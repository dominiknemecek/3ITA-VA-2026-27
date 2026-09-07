namespace SeznamAVyber;

// ListBox — seznam položek, ze kterých uživatel může vybrat jednu (nebo
// víc, podle SelectionMode). Naplňujeme ho v konstruktoru, ne v
// Form1.Designer.cs, protože položky nejsou pevná součást návrhu okna.
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        seznamJazyku.Items.Add("C#");
        seznamJazyku.Items.Add("C");
        seznamJazyku.Items.Add("Python");
        seznamJazyku.Items.Add("JavaScript");
    }

    // SelectedIndexChanged se spustí pokaždé, když uživatel klikne na
    // jinou položku seznamu — nemusíme čekat na potvrzovací tlačítko.
    private void seznamJazyku_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (seznamJazyku.SelectedItem is string vybranyJazyk)
        {
            popisekVyber.Text = $"Vybral jsi: {vybranyJazyk}";
        }
    }
}
