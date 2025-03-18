using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ankietaPreferencje;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
    }

    private void CheckIsInput()
    {
        var isInputName = string.IsNullOrEmpty(InputNameTextBox.Text);

        if (isInputName)
        {
            WarningTextBlock.Text = "Nie podano imienia!";
        }
        else
        {
            WarningTextBlock.Text = null;
        }
        
        
    }
    private void CheckbuttonClick(object? sender, RoutedEventArgs e)
    {
        CheckIsInput();
    }
    
    private void SendButtonClick(object? sender, RoutedEventArgs e)
    {
        CheckIsInput();
        if (WarningTextBlock.Text == "Nie podano imienia!")
        {
            SummaryTextBlock.Text = "Wypełnij wszystkie dane";
        }

        else
        {
            var name = InputNameTextBox.Text;
            var hobby = (Hobby.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Nie wybrano";

            var firstBox = FirstCheckBox.IsChecked == true ? 1 : 0;
            var secondBox = SecondCheckBox.IsChecked == true ? 1 : 0;
            var thirdBox = ThirdCheckBox.IsChecked == true ? 1 : 0;
            var fourthBox = FourthCheckBox.IsChecked == true ? 1 : 0;

            var sumCheckBox = firstBox + secondBox + thirdBox + fourthBox;

            SummaryTextBlock.Text = $"Imię: {name} \n Hobby: {hobby} \n Liczba tak: {sumCheckBox}";
        }

    }
}