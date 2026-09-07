using System.Windows;

namespace PrvniOkno;

// Rozložení okna je v MainWindow.xaml, tady je jen logika — obsluha
// událostí napojených v XAML přes atribut Click="...".
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void tlacitkoPozdrav_Click(object sender, RoutedEventArgs e)
    {
        popisekVysledek.Text = $"Ahoj, {textJmeno.Text}!";
    }
}
