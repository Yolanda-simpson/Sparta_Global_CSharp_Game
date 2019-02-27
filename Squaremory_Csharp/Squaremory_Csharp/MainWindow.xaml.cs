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
        int score = 0;

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
            
            Random rn = new Random();
            int x = rn.Next(36);
            int y = rn.Next(36);
            int z = rn.Next(36);
            int a = rn.Next(36);

            Button b1 = (Button)grid.Children[x];
            Button b2 = (Button)grid.Children[y];
            Button b3 = (Button)grid.Children[z];
            Button b4 = (Button)grid.Children[a];

            b1.Background = Brushes.Black;
            b2.Background = Brushes.Black;
            b3.Background = Brushes.Black;
            b4.Background = Brushes.Black;
            
        }
        public Button getGridChild(int r, int c)
        {
            for (int i = 0; i < grid.Children.Count; i++)
            {
                Button e = (Button)grid.Children[i];
                if (Grid.GetRow(e) == r && Grid.GetColumn(e) == c)
                    return e;
            }
            return null;
        }

        private int increment = 16;
        
        public void myTimer_Tick(object sender, EventArgs e)
        {
            TextBlock btc1 = new TextBlock();
            increment--;
            if (increment == 0)
            {
                cd.Stop();
                MessageBox.Show("game over");
            }
            if (increment == 10)
            {
                b1.Background = Brushes.White;
                b2.Background = Brushes.White;
                b3.Background = Brushes.White;
                b4.Background = Brushes.White;
            }

            txttimer.Text = increment.ToString();
            
        }

        private void changeBlockColour()
        {
            
            
           
        }
        private void blockScore()
        {
            score = score + 20;
            score1.Text = score.ToString();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
           

            //btn1.Click += Btn1_Click;
            //btn1.Background = Brushes.White;

            blockScore();
            //btn1.Background = Brushes.Black;

        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {

            // btn5.Click += Btn5_Click;
            //btn5.Background = Brushes.White;
            blockScore();

            // btn5.Background = Brushes.Black;
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {

            blockScore();
            btn9.Background = Brushes.White;


            // btn9.Background = Brushes.Transparent;
        }
        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
        private void Btn11_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
         private void Btn12_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
        private void Btn13_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn14_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn15_Click(object sender, RoutedEventArgs e)
        {
            blockScore();


            //btn15.Background = Brushes.Black;

        }

        private void Btn16_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn17_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn18_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn19_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn20_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn21_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn22_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn23_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn24_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn25_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn26_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
        private void Btn27_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
        private void Btn28_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn29_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn30_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn31_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn32_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn33_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn34_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn35_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }

        private void Btn36_Click(object sender, RoutedEventArgs e)
        {
            blockScore();
        }
    }
}
      


