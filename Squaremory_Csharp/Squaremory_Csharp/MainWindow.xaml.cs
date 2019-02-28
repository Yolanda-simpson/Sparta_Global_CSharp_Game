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
using System.Media;


namespace Squaremory_Csharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer cd = new DispatcherTimer();
        int score = 0;
        int attempts = 0;
        

        Button b1;
        Button b2;
        Button b3;
        Button b4;
        Button[] blackButtons;
        Button[,] SquareArray;
        BitmapImage[] squareimages;
        


        public MainWindow()
        {
            InitializeComponent();
            cd.Start();



        }

        //public void squareimg()
        //{
        //    SquareArray = new Button [6,6];
        //    SquareArray[0, 0] = btn1;
        //    SquareArray[0, 1] = btn2;
        //    SquareArray[0, 2] = btn3;
        //    SquareArray[0, 3] = btn4;
        //    SquareArray[0, 4] = btn5;
        //    SquareArray[0, 5] = btn6;
        //    SquareArray[1, 0] = btn7;
        //    SquareArray[1, 1] = btn8;
        //    SquareArray[1, 2] = btn9;
        //    SquareArray[1, 3] = btn10;
        //    SquareArray[1, 4] = btn11;
        //    SquareArray[1, 5] = btn12;
        //    SquareArray[2, 0] = btn13;
        //    SquareArray[2, 1] = btn14;
        //    SquareArray[2, 2] = btn15;
        //    SquareArray[2, 3] = btn16;
        //    SquareArray[2, 4] = btn17;
        //    SquareArray[2, 5] = btn18;
        //    SquareArray[3, 0] = btn19;
        //    SquareArray[3, 1] = btn20;
        //    SquareArray[3, 2] = btn21;
        //    SquareArray[3, 3] = btn22;
        //    SquareArray[3, 4] = btn23;
        //    SquareArray[3, 5] = btn24;
        //    SquareArray[4, 0] = btn25;
        //    SquareArray[4, 1] = btn26;
        //    SquareArray[4, 2] = btn27;
        //    SquareArray[4, 3] = btn28;
        //    SquareArray[4, 4] = btn29;
        //    SquareArray[4, 5] = btn30;
        //    SquareArray[5, 0] = btn31;
        //    SquareArray[5, 1] = btn32;
        //    SquareArray[5, 2] = btn33;
        //    SquareArray[5, 3] = btn34;
        //    SquareArray[5, 4] = btn35;
        //    SquareArray[5, 5] = btn36;

        //    squareimages = new BitmapImage[1];
        //    squareimages[0] = new BitmapImage(new Uri(@"C:\Users\tech-w99a.LAPTOP-3BLG1NHP\Engineering26\week7\Sparta_Global_CSharp_Game\square1"));




        //}
          
        
        
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

            b1 = (Button)grid.Children[x];
            b2 = (Button)grid.Children[y];
            b3 = (Button)grid.Children[z];
            b4 = (Button)grid.Children[a];
            blackButtons = new Button[4] { b1, b2, b3, b4 };

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

        private int increment = 6;
        
        public void myTimer_Tick(object sender, EventArgs e)
        {
            TextBlock btc1 = new TextBlock();
            increment--;
            if (increment == 0)
            {
                cd.Stop();
                b1.Background = Brushes.Transparent;
                b2.Background = Brushes.Transparent;
                b3.Background = Brushes.Transparent;
                b4.Background = Brushes.Transparent;
                MessageBox.Show("now click the squares you remember:" ,"Time to remember the squares" );
                
            }

            txttimer.Text = increment.ToString();
           
        }

        private void playSimpleSound()
        {

            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\ding.wav");
            simpleSound.Play();
        }


        private void changeBlockColour()
        {


        }
        private void blockScore(string btnName)
        {
            var window1 = new Window1();
            for (int i = 0; i < blackButtons.Length; i++)
            {
                bool incorrect = blackButtons[0].Name != btnName && blackButtons[1].Name != btnName && blackButtons[2].Name != btnName && blackButtons[3].Name != btnName;

                if (blackButtons[i].Name == btnName)
                {
                    score = score + 20;
                    score1.Text = score.ToString();

                    blackButtons[i].Background = Brushes.Black;
                    playSimpleSound();

                }
                else if (incorrect)
                {
                    MessageBox.Show("Incorrect", "Wrong Square Clicked");
                    
                    break;
                    
                }
              
                if (score == 80)
                {
                    MessageBox.Show("congratulations you found the squares");
                 
                       window1.Show();
                       this.Hide();
                        break;

                }
                


            }
            
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {

            blockScore("btn1");

        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn2");
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn3");
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn4");
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn5");

        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {

            blockScore("btn6");
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn7");
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn8");
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {

            blockScore("btn9");
        }
        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn10");
        }
        private void Btn11_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn11");
        }
         private void Btn12_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn12");
        }
        private void Btn13_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn13");
        }

        private void Btn14_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn14");
        }

        private void Btn15_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn15");
        }

        private void Btn16_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn16");
        }

        private void Btn17_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn17");
        }

        private void Btn18_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn18");
        }

        private void Btn19_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn19");
        }

        private void Btn20_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn20");
        }

        private void Btn21_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn21");
        }

        private void Btn22_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn22");
        }

        private void Btn23_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn23");
        }

        private void Btn24_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn24");
        }

        private void Btn25_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn25");
        }

        private void Btn26_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn26");
        }
        private void Btn27_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn27");
        }
        private void Btn28_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn28");
        }

        private void Btn29_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn29");
        }

        private void Btn30_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn30");
        }

        private void Btn31_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn31");
        }

        private void Btn32_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn32");
        }

        private void Btn33_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn33");
        }

        private void Btn34_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn34");
        }

        private void Btn35_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn35");
        }

        private void Btn36_Click(object sender, RoutedEventArgs e)
        {
            blockScore("btn36");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(b1.Name+" "+b2.Name+" "+b3.Name+" "+b4.Name);
        }
    }
}
      


