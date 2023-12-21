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

public partial class WaiterWindow : Window
{

    private DataGrid orderDGrid;

    public WaiterWindow()
    {
        InitializeComponent();
        orderDGrid = this.FindControl<DataGrid>("OrderDGrid");
        using(var context = new ApplicationContext())
    {
        orderDGrid.ItemsSource = context.OrderDishes.Include(o => o.Order).Include(o=> o.DishStatus).Include(o => o.Dish).ToList();  
    }   
    }

     private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);   
    }
}