using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System.IO;
using System.Linq;

namespace MyAppAvalonia;

public partial class AdminWindow : Window
{
    public AdminWindow()
    {
        InitializeComponent();
    }

     private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);   
    }

    [System.Obsolete]
    private void OnDragOver(object sender, DragEventArgs e)
    {
        if (e.Data.Contains(DataFormats.FileNames))
        {
            e.DragEffects = DragDropEffects.Copy;
            e.Handled = true;
        }
    }

    private void OnDrop(object sender, DragEventArgs e)
    {
        Image _draggedImage = this.Find<Image>("draggedImage");
        if (e.Data.Contains(DataFormats.FileNames))
        {
            var fileNames = e.Data.GetFileNames();

            if (fileNames.Count() > 0)
            {
                var file = fileNames.First();

                using (var stream = File.OpenRead(file))
                {
                    var bitmap = new Bitmap(stream);
                    _draggedImage.Source = bitmap;
                }
            }

            e.Handled = true;
        }
    }
}


