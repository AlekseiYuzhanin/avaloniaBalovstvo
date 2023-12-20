using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MyAppAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
     private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);   
    }

    private void ClickHandler(object? sender, RoutedEventArgs e)
    {
        using (var context = new ApplicationContext())
    {
        TextBox? login = this.FindControl<TextBox>("LoginTBox");
        TextBox? password = this.FindControl<TextBox>("PasswordTBox");
        var userNotExistsbox = MessageBoxManager
            .GetMessageBoxStandard("Ошибка", "Такого пользователя не существует",
                ButtonEnum.OkCancel);
            var whiteSpaceBox = MessageBoxManager
            .GetMessageBoxStandard("Ошибка", "Заполните все поля",
                ButtonEnum.OkCancel);

        var user = context.Users.Include(u => u.Role).FirstOrDefault(u => u.UserLogin == login.Text && u.UserPassword == password.Text);
        
        if (user != null)
        {
            if(user.Role.RoleTitle.ToString() == "Admin")
            {
                new AdminWindow().Show();
                new ListBoxImpl().Show();
                Close();
            }
            if(user.Role.RoleTitle.ToString() == "Waiter")
            {
                new WaiterWindow().Show();
                Close();
            }
            if(user.Role.RoleTitle.ToString() == "Cooker")
            {
                new CookerWindow().Show();
                Close();
            }
        }
        if(string.IsNullOrWhiteSpace(login?.Text) && string.IsNullOrWhiteSpace(password?.Text))
        {
            var result = whiteSpaceBox.ShowAsync();
            return;
        }
        if(user == null)
        {
            var result = userNotExistsbox.ShowAsync();
            return;
        }
    }
    }
}