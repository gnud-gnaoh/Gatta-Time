using System;
using System.Windows.Controls;

namespace Gatta_Time
{
    public partial class InRoom : Page
    {
        public InRoom()
        {
            InitializeComponent();
        }

        private void cartButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Gatcha.xaml", UriKind.Relative));
        }

        private void homeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainMenuPage.xaml", UriKind.Relative));
        }

    }
}
