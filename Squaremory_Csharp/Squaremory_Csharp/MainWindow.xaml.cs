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
using System.Timers;

namespace Squaremory_Csharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Startbtn_Click_1(object sender, RoutedEventArgs e)
        {
            
          
            
          
           
            
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
    }
}
