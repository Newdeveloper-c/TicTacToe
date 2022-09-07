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

namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }

        #region private members

        private MarkType[] Results;

        private bool Players1Turn;

        private bool GameEnd;

        private int ArrLength = 9;

        #endregion private membres

        #region game logic methods
        private void NewGame()
        {
            Results = new MarkType[ArrLength];

            for (var i = 0; i < Results.Length; i++)
                Results[i] = MarkType.Free;

            Players1Turn = true;

            //Iterate every button in the grid and set default values for colors
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                button.Content = string.Empty;
                button.Background = Brushes.AntiqueWhite;
                button.Foreground = Brushes.Blue;
            });

            GameEnd = false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(GameEnd)
            {
                NewGame();
                return;
            }
            var button = (Button)sender;

            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);
            int index = column + (row * (int)Math.Sqrt(ArrLength));

            if (Results[index] != MarkType.Free)
                return;

            Results[index] = (Players1Turn) ? MarkType.Cross : MarkType.Nought;

            if (!Players1Turn)
                button.Foreground = Brushes.Red;
            
            button.Content = Players1Turn ? 'X' : 'O';

            Players1Turn = !Players1Turn;

            //Check for a winner or pod
            FindWinner();
        }

        private void FindWinner()
        {
            #region manualchecking
            if (Results[0] != MarkType.Free && (Results[0] & Results[1] & Results[2]) == Results[0])
            {
                GameEnd = true;
                button1.Background = button2.Background = button3.Background = Brushes.Green;
            }

            if (Results[0] != MarkType.Free && (Results[0] & Results[3] & Results[6]) == Results[0])
            {
                GameEnd = true;
                button1.Background = button4.Background = button7.Background = Brushes.Green;
            }

            if (Results[0] != MarkType.Free && (Results[0] & Results[4] & Results[8]) == Results[0])
            {
                GameEnd = true;
                button1.Background = button5.Background = button9.Background = Brushes.Green;
            }

            if (Results[1] != MarkType.Free && (Results[1] & Results[4] & Results[7]) == Results[1])
            {
                GameEnd = true;
                button2.Background = button5.Background = button8.Background = Brushes.Green;
            }

            if (Results[2] != MarkType.Free && (Results[2] & Results[5] & Results[8]) == Results[2])
            {
                GameEnd = true;
                button3.Background = button6.Background = button9.Background = Brushes.Green;
            }

            if (Results[2] != MarkType.Free && (Results[2] & Results[4] & Results[6]) == Results[2])
            {
                GameEnd = true;
                button3.Background = button5.Background = button7.Background = Brushes.Green;
            }

            if (Results[3] != MarkType.Free && (Results[3] & Results[4] & Results[5]) == Results[3])
            {
                GameEnd = true;
                button4.Background = button5.Background = button6.Background = Brushes.Green;
            }

            if (Results[6] != MarkType.Free && (Results[6] & Results[7] & Results[8]) == Results[6])
            {
                GameEnd = true;
                button7.Background = button8.Background = button9.Background = Brushes.Green;
            }
            #endregion manualchecking

            if (!Results.Any(f => f == MarkType.Free))
            {
                GameEnd = true;

                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Background = Brushes.Orange;
                });
            }
        }

        #endregion game logic methods 

    }
}
