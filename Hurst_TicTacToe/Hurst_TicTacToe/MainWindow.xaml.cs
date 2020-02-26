using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Media;
using System.Threading.Tasks;

namespace Hurst_TicTacToe
{
    public partial class MainWindow : Window
    {
        SoundPlayer player = new SoundPlayer();

        public MainWindow()
        {
            InitializeComponent();
            NewGame();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\jedisaber.wav";
            player.Play();
        }

        private BoxSymbol[] bSymbols;
        private bool playerOneTurn;
        private bool gameEnded;

        private void NewGame()
        {
            bSymbols = new BoxSymbol[9];

            for (var i = 0; i < bSymbols.Length; i++)
                bSymbols[i] = BoxSymbol.Open;

            playerOneTurn = true;

            GameBoard.Children.Cast<Button>().ToList().ForEach(button =>
            {
                button.Content = string.Empty;
                button.Background = Brushes.Black;
                button.Foreground = Brushes.OrangeRed;
            });

            gameEnded = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (gameEnded)
            {
                NewGame();
                return;
            }
            var button = (Button)sender;
            int column = Grid.GetColumn(button);
            int row = Grid.GetRow(button);

            int index = column + (row * 3);

            if (bSymbols[index] != BoxSymbol.Open)
            {
                return;
            }

            if (playerOneTurn)
                bSymbols[index] = BoxSymbol.Cross;
            else
                bSymbols[index] = BoxSymbol.Circle;

            if (playerOneTurn)
            {
                button.Content = "X";
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\66.wav";
                player.Play();
            }
            else
            {
                button.Content = "O";
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\trap.wav";
                player.Play();
            }
            if (!playerOneTurn)
                button.Foreground = Brushes.LimeGreen;

            if (playerOneTurn)
                playerOneTurn = false;
            else
                playerOneTurn = true;

            CheckForWinner();
        }
        private void CheckForWinner()
        {  
            if (bSymbols[0] != BoxSymbol.Open && (bSymbols[0] & bSymbols[1] & bSymbols[2]) == bSymbols[0])
            {
                gameEnded = true;
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.LimeGreen;
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\victoryff.swf.wav";
                player.Play();
                Reset();
            }
            if (bSymbols[3] != BoxSymbol.Open && (bSymbols[3] & bSymbols[4] & bSymbols[5]) == bSymbols[3])
            {
                gameEnded = true;
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.LimeGreen;
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\victoryff.swf.wav";
                player.Play();
                Reset();
            }
            if (bSymbols[6] != BoxSymbol.Open && (bSymbols[6] & bSymbols[7] & bSymbols[8]) == bSymbols[6])
            {
                gameEnded = true;
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.LimeGreen;
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\victoryff.swf.wav";
                player.Play();
                Reset();
            }
        
            if (bSymbols[0] != BoxSymbol.Open && (bSymbols[0] & bSymbols[3] & bSymbols[6]) == bSymbols[0])
            {
                gameEnded = true;
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.LimeGreen;
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\victoryff.swf.wav";
                player.Play();
                Reset();
            }
            if (bSymbols[1] != BoxSymbol.Open && (bSymbols[1] & bSymbols[4] & bSymbols[7]) == bSymbols[1])
            {
                gameEnded = true;
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.LimeGreen;
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\victoryff.swf.wav";
                player.Play();
                Reset();
            }
            if (bSymbols[2] != BoxSymbol.Open && (bSymbols[2] & bSymbols[5] & bSymbols[8]) == bSymbols[2])
            {
                gameEnded = true;
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.LimeGreen;
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\victoryff.swf.wav";
                player.Play();
                Reset();
            }
          
            if (bSymbols[0] != BoxSymbol.Open && (bSymbols[0] & bSymbols[4] & bSymbols[8]) == bSymbols[0])
            {
                gameEnded = true;
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.LimeGreen;
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\victoryff.swf.wav";
                player.Play();
                Reset();
            }
            if (bSymbols[2] != BoxSymbol.Open && (bSymbols[2] & bSymbols[4] & bSymbols[6]) == bSymbols[2])
            {
                gameEnded = true;
                Button2_0.Background = Button1_1.Background = Button0_2.Background = Brushes.LimeGreen;
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\victoryff.swf.wav";
                player.Play();
                Reset();
            }
         
            if (!bSymbols.Any(f => f == BoxSymbol.Open) && !gameEnded)
            {
                gameEnded = true;
                GameBoard.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Background = Brushes.Teal;
                });
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\sadtrombone.swf.wav";
                player.Play();
                MessageBox.Show("Tie game!!! \nOnce you click ok a new game will start.");
                NewGame();
            }
        }
        public void Reset()
        {
            MessageBox.Show("You win!!! \nOnce you click ok a new game will start.");          
            NewGame();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\sithsaber.wav";
            player.Play();
        }
    }
}
