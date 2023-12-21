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

public partial class CheckDishWindow : Window
{
    private TextBlock userName;
    private TextBlock dishTitle;
    private CheckBox payed;
    private TextBlock ordertime;
    private OrderDish editdish;

    public CheckDishWindow()
    {
        InitializeComponent();
    }

     private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);   
    }

    public CheckDishWindow(OrderDish editdish)
    {
        InitializeComponent();

        userName = this.FindControl<TextBlock>("ClientNameTBlock");
        dishTitle = this.FindControl<TextBlock>("DishTitleTBlock");
        payed = this.FindControl<CheckBox>("DishPayedTBlock");
        ordertime = this.FindControl<TextBlock>("OrderTimeTBlock");
        this.editdish = editdish;

        userName.Text = editdish.Order.ClientName;
        dishTitle.Text = editdish.Dish.DishTitle;
        ordertime.Text = editdish.Order.OrderTime.ToString();
    }

    private void EditBtn(object sender, RoutedEventArgs e)
    {
        using (var dbContext = new ApplicationContext())
    {
        var product = dbContext.OrderDishes.Find(this.editdish.OrderDishId); // замените productId на ваш идентификатор продукта

        if (product != null)
    {
        if (product.DishStatus != null)
        {
            product.DishStatus.DishStatusId = 2;
            product.DishStatus.StatusTitle = "Приготовлен";
        }
        else
        {
            product.DishStatus = new DishStatus()
            {
                DishStatusId = 2,
                StatusTitle = "Приготовлен"
            };
        }

        dbContext.SaveChanges();
        Close();
    }
    }
    }
}