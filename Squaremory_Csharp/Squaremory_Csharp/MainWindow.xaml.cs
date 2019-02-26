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


namespace Squaremory_Csharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer cd = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            cd.Start();



        }
        private void Startbtn_Click_1(object sender, RoutedEventArgs e)
        {
            cd.Interval = TimeSpan.FromSeconds(1);
            cd.Tick += myTimer_Tick;
            cd.Start();

            for (int i = 0; i < grid.ColumnDefinitions.Count; i++)
            {

                for (int x = 0; x < grid.RowDefinitions.Count; x++)
                {
                    Random rnd = new Random();
                    int row = rnd.Next(6);
                    int col = rnd.Next(6);
                    TextBlock btc = new TextBlock();
                    btc.Background = Brushes.Black;

                    Grid.SetColumn(btc, col);
                    Grid.SetRow(btc, row);
                    grid.Children.Add(btc);
                }
            }

        }
        private int increment = 16;
        public void myTimer_Tick(object sender, EventArgs e)
        {
            increment--;
            if (increment == 0)
            {
                cd.Stop();
            }
            txttimer.Text = increment.ToString();
        }
       



    }
}
      


