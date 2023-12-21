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
using System.Text;

namespace MyAppAvalonia;

public partial class CheckUserWindow : Window
{
    private User editUser;

    private TextBlock userName;
    private TextBlock userLogin;
    private TextBlock userPassword;
    private TextBlock role;
    private Image imageUser;
    private Image imageContract;
    private byte[] contractContainer;
    private byte[] profileContainer;
    public CheckUserWindow()
    {
        InitializeComponent();
    
    }

     private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);   
    }

    public CheckUserWindow(User edituser)
    {
        InitializeComponent();

        userName = this.FindControl<TextBlock>("ClientNameTBlock");
        userLogin = this.FindControl<TextBlock>("DishTitleTBlock");
        userPassword = this.FindControl<TextBlock>("DishPayedTBlock");
        role = this.FindControl<TextBlock>("OrderTimeTBlock");
        imageUser = this.FindControl<Image>("OrderTimeTBlock");
        imageContract = this.FindControl<Image>("OrderTimeTBlock");
        this.editUser = edituser;

        userName.Text = editUser.Order.ClientName;
        dishTitle.Text = editUser.Dish.DishTitle;
        ordertime.Text = editUser.Order.OrderTime.ToString();
    }

    private async void OpenUser_Click(object sender, RoutedEventArgs e)
    {       

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string[] result = await dialog.ShowAsync(this);
            imageUser.Source = new Avalonia.Media.Imaging.Bitmap(result[0]);
            profileContainer = Encoding.UTF8.GetBytes(result[0]);
    }

    [Obsolete]
    private async void OpenContract_Click(object sender, RoutedEventArgs e)
    {       

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string[] result = await dialog.ShowAsync(this);
            imageContract.Source = new Avalonia.Media.Imaging.Bitmap(result[0]);
            contractContainer = Encoding.Default.GetBytes(result[0]);
    }
}