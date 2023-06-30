using System;
using System.Windows.Controls;

namespace Gatta_Time
{
    public partial class Cat : Page
    {
        public Cat()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Gatcha.xaml", UriKind.Relative));
        }

        private void MeoButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("InRoom.xaml", UriKind.Relative));
        }
    }
}
