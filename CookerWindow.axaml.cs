using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace MyAppAvalonia;

public partial class CookerWindow : Window
{

    private DataGrid orderDGrid;

    public CookerWindow()
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