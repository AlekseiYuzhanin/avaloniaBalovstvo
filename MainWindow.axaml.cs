using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

namespace MyAppAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    /*private async void ClickHandler(object sender, RoutedEventArgs e)
    {
        var box = MessageBoxManager
            .GetMessageBoxStandard("Caption", "Are you sure you would like to delete appender_replace_page_1?",
                ButtonEnum.YesNoCancel);

        var result = await box.ShowAsync();
    }*/

    
}