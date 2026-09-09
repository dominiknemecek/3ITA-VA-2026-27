using System.Windows;
using System.Windows.Controls;

namespace SeznamAVyber;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void languageListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (languageListBox.SelectedItem is ListBoxItem selectedItem)
        {
            selectionLabel.Text = $"Vybral jsi: {selectedItem.Content}";
        }
    }
}
