using System;
using System.Windows.Controls;

namespace Gatta_Time
{
    public partial class End : Page
    {
        public End()
        {
            InitializeComponent();
        }

        private void btn_Click_home(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainMenuPage.xaml", UriKind.Relative));
        }

        private void btn_Click_meo(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("InRoom.xaml", UriKind.Relative));
        }
    }
}
