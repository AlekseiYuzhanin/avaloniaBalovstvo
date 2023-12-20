using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace MyAppAvalonia;

public partial class CookerWindow : Window
{
    public CookerWindow()
    {
        InitializeComponent();
    }

     private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);   
    }
}