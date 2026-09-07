using System.Windows;
using System.Windows.Controls;

namespace SeznamAVyber;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void seznamJazyku_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (seznamJazyku.SelectedItem is ListBoxItem vybrana)
        {
            popisekVyber.Text = $"Vybral jsi: {vybrana.Content}";
        }
    }
}
