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

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ApplicationContext applicationContext = new ApplicationContext();
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
                Console.WriteLine("YESYESYES");
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