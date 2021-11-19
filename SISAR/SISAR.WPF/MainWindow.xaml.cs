using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace SISAR.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Tools();
        }

        private void Tools_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Tools();
        }

        private void Updates_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Updates();
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new About();
        }

    }
}
