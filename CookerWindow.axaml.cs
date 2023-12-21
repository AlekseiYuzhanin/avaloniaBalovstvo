using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Avalonia.Interactivity;


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

    private async void EditHandler(object sender, RoutedEventArgs e)
    {
        OrderDish? selectedDish = orderDGrid.SelectedItem as OrderDish;
        // Если элемент выбран
        if (selectedDish != null)
        {
            await new CheckDishWindow(selectedDish).ShowDialog(this);
            using(var context = new ApplicationContext())
            {
                orderDGrid.ItemsSource = context.OrderDishes.Include(o => o.Order).Include(o=> o.DishStatus).Include(o => o.Dish).ToList();  
            }
        }
    }
}