using System;
using Avalonia.Interactivity;
using SerialPortAssist.ViewModels;
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

        /// <summary>
        /// 发送区文本框失去焦点时，自动将文本框内容添加到发送缓冲区，并启动自动发送数据定时器
        /// </summary>
        private void OnTxtSendDataLostFocus(object? sender, RoutedEventArgs e)
        {
            if (DataContext is MainWindowViewModel vm)
            {
                vm.HandleTxtSendDataLostFocus(sender, e);
            }
        }
    }
}
