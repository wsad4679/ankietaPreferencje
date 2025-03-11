using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ankietaPreferencje;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
    }

    private void CheckbuttonClick(object? sender, RoutedEventArgs e)
    {
        var isInputName = string.IsNullOrEmpty(InputNameTextBox.Text);

        if (!isInputName)
        {
            WarningTextBlock.Text = null;
            var name = InputNameTextBox.Text;
        }
        else
        {
            WarningTextBlock.Text = "Nie podano imienia!";
        }
    

    }
    private void SendButtonClick(object? sender, RoutedEventArgs e)
    {
        
    }
}