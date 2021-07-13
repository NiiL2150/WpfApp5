using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(500) };
            timer.Tick += TimerTick;
            DataContext = new DataSource();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            ((DataSource)DataContext).Value++;
            UpdateUI();
        }

        private void UpdateUI()
        {
            tickLabel.Content = ((DataSource)DataContext).Value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!timer.IsEnabled)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
