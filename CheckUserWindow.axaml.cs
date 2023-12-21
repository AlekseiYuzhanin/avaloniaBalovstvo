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

        userName = this.FindControl<TextBlock>("NameTBox");
        userLogin = this.FindControl<TextBlock>("LoginTBox");
        userPassword = this.FindControl<TextBlock>("PasswordTBox");
        role = this.FindControl<TextBlock>("RoleTBox");
        imageUser = this.FindControl<Image>("UserImage");
        imageContract = this.FindControl<Image>("ContractImage");
        this.editUser = edituser;

        userName.Text = editUser.UserName;
        userLogin.Text = editUser.UserLogin;
        userPassword.Text = editUser.UserPassword;
        role.Text = editUser.Role.RoleTitle;
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