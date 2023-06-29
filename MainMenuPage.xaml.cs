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
    }
}
