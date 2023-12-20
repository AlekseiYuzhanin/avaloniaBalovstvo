using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;

namespace MyAppAvalonia;

public partial class ListBoxImpl : Window
{
    public ListBoxImpl()
    {
        InitializeComponent();
    }

     private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        using (var context = new ApplicationContext())
        {
            List<string> Content = context.Users
            .Include(u => u.Role)
            .Select(u => u.Role.RoleTitle)
            .Distinct()
            .ToList();
            ComboBox comboBox = this.FindControl<ComboBox>("MyComboBox");
            foreach(string val in Content )
            {
                comboBox.Items.Add(val);
            }
        }
    }
}