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
using System.IO;


namespace Squaremory_Csharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DispatcherTimer cd = new DispatcherTimer();
        int score = 0;
        int errorcount = 0;


        Button b1;
        Button b2;
        Button b3;
        Button b4;
        Button b5;
        Button b6;
        Button b7;
        Button[] blackButtons;



        Image img = new Image();
        Image img2 = new Image();
        Image img3 = new Image();
        Image img4 = new Image();
        Image img5 = new Image();
        Image img6 = new Image();
        Image img7 = new Image();

        public Window1()
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
            int b = rn.Next(36);
            int c = rn.Next(36);
            int d = rn.Next(36);

            b1 = (Button)grid.Children[x];
            b2 = (Button)grid.Children[y];
            b3 = (Button)grid.Children[z];
            b4 = (Button)grid.Children[a];
            b5 = (Button)grid.Children[b];
            b6 = (Button)grid.Children[c];
            b7 = (Button)grid.Children[d];
            blackButtons = new Button[7] { b1, b2, b3, b4, b5, b6, b7 };


            img.Source = new BitmapImage(new Uri(@"C:\Users\tech-w99a.LAPTOP-3BLG1NHP\Engineering26\week7\Sparta_Global_CSharp_Game\Squaremory_Csharp\Squaremory_Csharp\bin\square5.png"));
            img2.Source = new BitmapImage(new Uri(@"C:\Users\tech-w99a.LAPTOP-3BLG1NHP\Engineering26\week7\Sparta_Global_CSharp_Game\Squaremory_Csharp\Squaremory_Csharp\bin\square5.png"));
            img3.Source = new BitmapImage(new Uri(@"C:\Users\tech-w99a.LAPTOP-3BLG1NHP\Engineering26\week7\Sparta_Global_CSharp_Game\Squaremory_Csharp\Squaremory_Csharp\bin\square5.png"));
            img4.Source = new BitmapImage(new Uri(@"C:\Users\tech-w99a.LAPTOP-3BLG1NHP\Engineering26\week7\Sparta_Global_CSharp_Game\Squaremory_Csharp\Squaremory_Csharp\bin\square5.png"));
            img5.Source = new BitmapImage(new Uri(@"C:\Users\tech-w99a.LAPTOP-3BLG1NHP\Engineering26\week7\Sparta_Global_CSharp_Game\Squaremory_Csharp\Squaremory_Csharp\bin\square5.png"));
            img6.Source = new BitmapImage(new Uri(@"C:\Users\tech-w99a.LAPTOP-3BLG1NHP\Engineering26\week7\Sparta_Global_CSharp_Game\Squaremory_Csharp\Squaremory_Csharp\bin\square5.png"));
            img7.Source = new BitmapImage(new Uri(@"C:\Users\tech-w99a.LAPTOP-3BLG1NHP\Engineering26\week7\Sparta_Global_CSharp_Game\Squaremory_Csharp\Squaremory_Csharp\bin\square5.png"));



            b1.Content = img;
            b2.Content = img2;
            b3.Content = img3;
            b4.Content = img4;
            b5.Content = img5;
            b6.Content = img6;
            b7.Content = img7;



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

        private int increment = 9;

        public void myTimer_Tick(object sender, EventArgs e)
        {
            TextBlock btc1 = new TextBlock();
            increment--;
            if (increment == 0)
            {
                cd.Stop();
                img.Visibility = Visibility.Collapsed;
                img2.Visibility = Visibility.Collapsed;
                img3.Visibility = Visibility.Collapsed;
                img4.Visibility = Visibility.Collapsed;
                img5.Visibility = Visibility.Collapsed;
                img6.Visibility = Visibility.Collapsed;
                img7.Visibility = Visibility.Collapsed;
                MessageBox.Show("now click the squares you remember:", "Time to remember the squares");

            }

            txttimer.Text = increment.ToString();

        }

        private void playSimpleSound()
        {

            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\tech-w99a.LAPTOP-3BLG1NHP\Engineering26\week7\Sparta_Global_CSharp_Game\Squaremory_Csharp\Squaremory_Csharp\bin\ding.wav");
            simpleSound.Play();
        }
        private void playSimpleSound2()
        {

            SoundPlayer simpleSound2 = new SoundPlayer(@"C:\Users\tech-w99a.LAPTOP-3BLG1NHP\Engineering26\week7\Sparta_Global_CSharp_Game\Squaremory_Csharp\Squaremory_Csharp\bin\clap.wav");
            simpleSound2.Play();
        }


        private void blockScore(string btnName)
        {
            if (errorcount == 3)
            {
                MessageBox.Show("Game Over", "Game Over");

                this.Close();

            }
            var window1 = new Window1();
            for (int i = 0; i < blackButtons.Length; i++)
            {

                bool incorrect = blackButtons[0].Name != btnName && blackButtons[1].Name != btnName && blackButtons[2].Name != btnName && blackButtons[3].Name != btnName && blackButtons[4].Name != btnName && blackButtons[5].Name != btnName && blackButtons[6].Name != btnName;

                if (blackButtons[i].Name == btnName)
                {
                    score = score + 20;
                    score1.Text = score.ToString();

                    blackButtons[i].Background = Brushes.Red;
                    playSimpleSound();

                }
                else if (incorrect)
                {
                    errorcount++;
                    MessageBox.Show("Incorrect", "Wrong Square Clicked");
                    break;


                }

                if (score == 140)
                {
                    MessageBox.Show("congratulations you found the squares", "Congartualtions");
                    playSimpleSound2();

                    this.Close();
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

    }
}

