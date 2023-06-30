using System;
using System.Windows.Controls;

namespace Gatta_Time
{
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void ManualButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Manual.xaml", UriKind.Relative));
        }
        private void FocusButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("FocusMode.xaml", UriKind.Relative));
        }

        private void SettingsButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Settings.xaml", UriKind.Relative));
        }
    }
}
