using System;
using System.Windows;
using System.Windows.Controls;

namespace Gatta_Time
{
    public partial class Gatcha : Page
    {
        public Gatcha()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Cat.xaml", UriKind.Relative));
        }

        private void HomeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("InRoom.xaml", UriKind.Relative));
        }
    }
}
