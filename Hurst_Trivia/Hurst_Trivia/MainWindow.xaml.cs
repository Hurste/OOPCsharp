using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Hurst_Trivia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openFile = new OpenFileDialog();
        string line = "";
        StreamReader fileONA;
        Questions quest = new Questions();

        int qCount = 0,
            index = 0,
            correctTotal = 0;
        string correctAnswer;
        string FileName = "Trivia.txt";

        public MainWindow()
        {
            InitializeComponent();
            imgStart.Visibility = Visibility.Visible;
            btnStart.Visibility = Visibility.Visible;
            btnExit.Visibility = Visibility.Visible;

            btnCheckAnswer.Visibility = Visibility.Hidden;
            rdBtnAnswer1.Visibility = Visibility.Hidden;
            rdBtnAnswer2.Visibility = Visibility.Hidden;
            rdBtnAnswer3.Visibility = Visibility.Hidden;
            rdBtnAnswer4.Visibility = Visibility.Hidden;
            if(openFile.ShowDialog() == DialogResult.HasValue)
            {
                StreamReader fileQNA = new StreamReader(openFile.FileName);
                while (line != null)
                {
                    line = fileQNA.ReadLine();
                }
            }
            openFile.Filter = "Text Files (.txt)| *.txt";
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void btnInstructions_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome to the Trivia Game! This is a fun game to play, you guessed it... TRIVIA! There are 6 questions, all multiple choice. Hope you get a high score!");
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {

            imgStart.Visibility = Visibility.Hidden;
            btnStart.Visibility = Visibility.Hidden;
            btnExit1.Visibility = Visibility.Hidden;

            btnCheckAnswer.Visibility = Visibility.Visible;
            rdBtnAnswer1.Visibility = Visibility.Visible;
            rdBtnAnswer2.Visibility = Visibility.Visible;
            rdBtnAnswer3.Visibility = Visibility.Visible;
            rdBtnAnswer4.Visibility = Visibility.Visible;

            rdBtnAnswer1.IsChecked = false;
            rdBtnAnswer2.IsChecked = false;
            rdBtnAnswer3.IsChecked = false;
            rdBtnAnswer4.IsChecked = false;

            string[] possAnswer = new string[6];

            if (qCount != 0)
            {
                if (index < qCount)
                {
                    lblQuestionBox.Content = (quest.GetQuestion(index));
                    lblQuestionNum.Content = "Question " + (index + 1).ToString();

                    possAnswer = quest.GetAnswers(index);

                    rdBtnAnswer1.Content = possAnswer[0];
                    rdBtnAnswer2.Content = possAnswer[1];
                    rdBtnAnswer3.Content = possAnswer[2];
                    rdBtnAnswer4.Content = possAnswer[3];

                    correctAnswer = quest.GetCorrectAnswer(index);

                    ButtonClear(true);

                    index++;
                }
                else
                {
                    EndGame();
                }
            }
        }

        public void ButtonClear(bool visible)
        {
            lblQuestionBox.Visibility = Visibility.Visible;
            lblQuestionNum.Visibility = Visibility.Visible;
            btnCheckAnswer.Visibility = Visibility.Visible;
            rdBtnAnswer1.Visibility = Visibility.Visible;
            rdBtnAnswer2.Visibility = Visibility.Visible;
            rdBtnAnswer3.Visibility = Visibility.Visible;
            rdBtnAnswer4.Visibility = Visibility.Visible;
        }

        private void btnCheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            string userAnswer = "",
                   actualAnswer = "",
                   info;

            if (rdBtnAnswer1.IsChecked == true)
            {
                userAnswer = "A";
            }
            else if (rdBtnAnswer2.IsChecked == true)
            {
                userAnswer = "B";
            }
            else if (rdBtnAnswer3.IsChecked == true)
            {
                userAnswer = "C";
            }
            else if (rdBtnAnswer4.IsChecked == true)
            {
                userAnswer = "D";
            }

            switch (correctAnswer)
            {
                case "A":
                    rdBtnAnswer1.Content = actualAnswer;
                    break;
                case "B":
                    rdBtnAnswer2.Content = actualAnswer;
                    break;
                case "C":
                    rdBtnAnswer3.Content = actualAnswer;
                    break;
                case "D":
                    rdBtnAnswer4.Content = actualAnswer;
                    break;
            }

            lblQuestionNum.Visibility = Visibility.Hidden;
            lblQuestionBox.Content = "";
            info = quest.GetInfo(index + 1);

            if (userAnswer == actualAnswer)
            {
                correctTotal++;
                if (MessageBox.Show("Correct Answer!!! Congradulations\n\n" + info, "Result", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
                {
                    btnStart_Click(0, e);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                if (MessageBox.Show("Incorrect Answer!!! FAILURE!\n\n" + info, "Result", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
                {
                    btnStart_Click(0, e);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        public void EndGame()
        {
            string results;

            ButtonClear(false);

            results = "You got " + correctTotal.ToString() + " correct out of " + qCount.ToString();

            MessageBox.Show("Thanks for Playing!");

            Reset();
        }

        public void Reset()
        {
            ButtonClear(false);

            qCount = 0;
            index = 0;
            correctTotal = 0;

            imgStart.Visibility = Visibility.Visible;
            btnStart.Visibility = Visibility.Visible;
            btnExit1.Visibility = Visibility.Visible;

            btnCheckAnswer.Visibility = Visibility.Hidden;
            rdBtnAnswer1.Visibility = Visibility.Hidden;
            rdBtnAnswer2.Visibility = Visibility.Hidden;
            rdBtnAnswer3.Visibility = Visibility.Hidden;
            rdBtnAnswer4.Visibility = Visibility.Hidden;
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                openFile.ShowDialog();
                StreamReader fileQNA = new StreamReader(openFile.FileName);
                qCount = quest.ReadQuestions(fileQNA);
            }
            catch (IOException exc)
            {
                lblQuestionBox.Content = "";
                lblQuestionBox.Visibility = Visibility.Visible;
                lblQuestionBox.Content = "File Error:           " + exc.Message;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello and Welcome to the Trivia Game!!!" + "\n\nElijah Hurst \nProf: Mike Hunsicker \nITDEV - 115 Intermediate OOP \nAssignment 8" + "\n" + System.DateTime.Today.ToShortDateString());
        }
    }
}
