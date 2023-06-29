using System.Windows;

namespace Gatta_Time
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _NavigationFrame.Navigate(new MainMenuPage());
        }
    }
}
