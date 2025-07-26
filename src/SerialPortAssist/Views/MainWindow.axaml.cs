using System;
using Avalonia.Interactivity;
using Ursa.Controls;

namespace SerialPortAssist.Views
{
    public partial class MainWindow : UrsaWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenRepository(object? sender, RoutedEventArgs e)
        {
            Launcher.LaunchUriAsync(new Uri("https://github.com/zeekcheung/SerialPortAssist"));
        }
    }
}
