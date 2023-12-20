using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace MyAppAvalonia;

public partial class AdminWindow : Window
{

private TextBox userName;
private TextBox userLogin;
private TextBox userPassword;
private ComboBox roleComboBox;
private Image imageUser;
private Image imageContract;
public ObservableCollection<string> RolesList { get; }

public AdminWindow()
{
    InitializeComponent();

}

private void InitializeComponent()
{
    AvaloniaXamlLoader.Load(this);
    
    imageUser = this.FindControl<Image>("UserImage");
    imageContract = this.FindControl<Image>("ContractImage");
    roleComboBox = this.FindControl<ComboBox>("RoleCBox");
}

    [Obsolete]
    private async void OpenUser_Click(object sender, RoutedEventArgs e)
    {       

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string[] result = await dialog.ShowAsync(this);
            imageUser.Source = new Avalonia.Media.Imaging.Bitmap(result[0]);
    }

    [Obsolete]
    private async void OpenContract_Click(object sender, RoutedEventArgs e)
    {       

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string[] result = await dialog.ShowAsync(this);
            imageContract.Source = new Avalonia.Media.Imaging.Bitmap(result[0]);
    }
    
    private void RegBtn_Click(object sender, RoutedEventArgs e)
    {

    }
}


