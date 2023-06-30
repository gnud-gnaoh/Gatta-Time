using System;
using System.Windows.Controls;

namespace Gatta_Time
{
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainMenuPage.xaml", UriKind.Relative));
        }
    }
}
