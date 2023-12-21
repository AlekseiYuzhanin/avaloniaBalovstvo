using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Text;
using System.Reactive.Linq;
using Avalonia.Input;
using Avalonia.VisualTree;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

namespace MyAppAvalonia;

public partial class AdminWindow : Window
{

private TextBox userName;
private TextBox userLogin;
private TextBox userPassword;
private ComboBox roleComboBox;
private Image imageUser;
private Image imageContract;
private byte[] contractContainer;
private byte[] profileContainer;
private DataGrid usersDGrid;
private DataGrid shiftDGrid;
private DataGrid orderDGrid;
public AdminWindow()
{
    InitializeComponent();
    
    usersDGrid = this.FindControl<DataGrid>("UsersDGrid");
    shiftDGrid = this.FindControl<DataGrid>("ShiftDGrid");
    orderDGrid = this.FindControl<DataGrid>("OrderDGrid");
    using(var context = new ApplicationContext())
    {
        usersDGrid.ItemsSource = context.Users.Include(u=>u.Role).ToList();
        shiftDGrid.ItemsSource = context.ShiftAssignments.Include(s => s.User).Include(s => s.Shift).ToList();  
        orderDGrid.ItemsSource = context.OrderDishes.Include(o => o.Order).Include(o=> o.DishStatus).Include(o => o.Dish).ToList();  
    }
}

private void InitializeComponent()
{
    AvaloniaXamlLoader.Load(this);
    
    userName = this.FindControl<TextBox>("NameTBox");
    userLogin = this.FindControl<TextBox>("LoginTBox");
    userPassword = this.FindControl<TextBox>("PasswordTBox");
    roleComboBox = this.FindControl<ComboBox>("RoleCBox");
    imageUser = this.FindControl<Image>("UserImage");
    imageContract = this.FindControl<Image>("ContractImage");

    using (var context = new ApplicationContext())
        {
            List<string> Content = context.Users
            .Include(u => u.Role)
            .Select(u => u.Role.RoleTitle)
            .Distinct()
            .ToList();

            foreach(string val in Content )
            {
                roleComboBox.Items.Add(val);
            }

        }
}


    [Obsolete]
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

    private void RegBtn(object sender, RoutedEventArgs e)
    {
        using(var context = new ApplicationContext())
        {
            var successRegistrationBox = MessageBoxManager
            .GetMessageBoxStandard("Успешно!", "пользователь был зарегистрирован",
                ButtonEnum.OkCancel);
            var newUser = new User()
            {
                UserId = context.Users.Max(q=>q.UserId) + 1,
                UserName = userName.Text,
                UserLogin = userLogin.Text,
                UserPassword = userPassword.Text,
                Fired = false,
                RoleId = roleComboBox.SelectedIndex + 1,
                ContractPicture = contractContainer,
                ProfilePicture = profileContainer
            };
            context.Users.Add(newUser);
            context.SaveChanges();
            var result = successRegistrationBox.ShowAsync();
        }

        userName.Text = "";
        userLogin.Text = "";
        userPassword.Text = "";
    }
    
    private async void EditHandler(object sender, RoutedEventArgs e)
    {
        User? selectedUser = usersDGrid.SelectedItem as User;
        // Если элемент выбран
        if (selectedUser != null)
        {
            await new CheckUserWindow(selectedUser).ShowDialog(this);
            using(var context = new ApplicationContext())
            {
                usersDGrid.ItemsSource = context.Users.Include(q=>q.Role).ToList();
            }
        }
    }
    }



