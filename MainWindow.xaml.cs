using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KrestikINolik
{
    public partial class MainWindow : Window
    {
        Button[] button;
        public MainWindow()
        {
            InitializeComponent();
            button = new Button[9] { _1, _2, _3, _4, _5, _6, _7, _8, _9 };
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;

            Random random = new Random();
            int Knopka = random.Next(0, 9);

            int x = 0;
            int o = 0;
            string xw = "X";
            string ow = "O";
            while (button[Knopka].IsEnabled == false)
            {
                Knopka = random.Next(0, 9);
                foreach (var item in button)
                {
                    if (item.Content == "X")
                    {
                        x++;
                    }
                    if (item.Content == "O")
                    {
                        o++;
                    }
                }
                if (x == 3)
                {
                    CheckWin(xw);
                }
                if (o == 3)
                {
                    CheckWin(ow);
                }
                if (button[0].IsEnabled == false && button[1].IsEnabled == false && button[2].IsEnabled == false && button[3].IsEnabled == false && button[4].IsEnabled == false && button[5].IsEnabled == false && button[6].IsEnabled == false && button[7].IsEnabled == false && button[8].IsEnabled == false)
                {
                    break;
                }
            }

            button[Knopka].Content = "O";
            button[Knopka].IsEnabled = false;
        }

        static void CheckWin(string h)
        {

        }
    }
}
