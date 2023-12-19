using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using Avalonia.Markup.Xaml;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MyAppAvalonia;

public partial class CookerWindow : Window
{
    public CookerWindow()
    {
        InitializeComponent();
        ApplicationContext applicationContext = new ApplicationContext();
    }

     private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);   
    }
}