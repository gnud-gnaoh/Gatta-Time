using System;
using System.Windows;
using System.Windows.Controls;

namespace Gatta_Time
{
    public partial class FocusMode : Page
    {
        public int hours = 0, minutes = 0;
        public string s;
        public FocusMode()
        {
            InitializeComponent();
        }

        public static int Cvt(string k)
        {
            int a = 0;
            for (int i = 0; i < k.Length; i++)
            {
                a += ((int)k[i] - 48) * 10;
            }
            return a;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            s = chtxbValue.Text;

            this.hours = Cvt(s) * 10 + Cvt(dhtxbValue.Text);
            this.minutes = Cvt(cptxbValue.Text) * 10 + Cvt(dptxbValue.Text);
            
            this.NavigationService.Navigate(new Timer(hours, minutes));
        }
    }
}
