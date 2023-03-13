using TKD.Task._3.View.Pages;
using TKD.Task._3.Core;
using System.ComponentModel;
using System.Windows;

namespace TKD.Task._3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());

        }

    }
}