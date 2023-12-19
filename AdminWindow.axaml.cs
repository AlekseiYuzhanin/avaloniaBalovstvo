using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using System.IO;
using System.Linq;

namespace MyAppAvalonia;

public partial class AdminWindow : Window
{
    public AdminWindow()
    {
        InitializeComponent();
    }

     private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);   
    }

    private async void OpenFile_Click(object sender, RoutedEventArgs e)
    {       
            Image? image = this.FindControl<Image>("UserImage");

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string[] result = await dialog.ShowAsync(this);
            image.Source = new Avalonia.Media.Imaging.Bitmap(result[0]);
    }
    
}


