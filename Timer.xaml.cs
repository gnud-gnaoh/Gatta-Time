using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Gatta_Time
{
    public partial class Timer : Page
    {
        public Timer()
        {
            InitializeComponent();
        }

        DispatcherTimer _timer;
        TimeSpan _time;

        void change()
        {
            TimeSpan ts = TimeSpan.FromSeconds(10);

            ts = ts.Subtract(TimeSpan.FromSeconds(1));
            Demso.Text = ts.ToString(@"hh\:mm\:ss");
        }

        public Timer(int hours, int minutes)
        {
            hours /= 10;
            minutes /= 10;
            InitializeComponent();
            Console.WriteLine(Application.Current);
            _time = TimeSpan.FromSeconds(hours * 3600 + minutes * 60);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                Demso.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) { Time_over(); _timer.Stop(); }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }

        public void Time_over()
        {
            this.NavigationService.Navigate(new Uri("End.xaml", UriKind.Relative));
        }
    }
}
