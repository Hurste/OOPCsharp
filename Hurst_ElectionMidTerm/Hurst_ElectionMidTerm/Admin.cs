using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows;
using System.Drawing;
using System.Drawing.Design;
using System.Speech.Synthesis;
using System.Threading;

namespace Hurst_ElectionMidTerm
{
    class Admin
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        SoundPlayer player = new SoundPlayer();
        public void ConsoleSetup() //Sets up console colors and intro, as well as music
        {
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Depth Charge Intro.wav";
            player.Play();
            Thread.Sleep(4700);
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\1812.wav";
            player.Play();
            Console.Title = "Election Time!";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.SetCursorPosition(40, 10);
            Console.WriteLine("┌---------------------------------------┐");
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("|\t\t\t\t\t|");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("|\t\t\t\t\t|");
            Console.SetCursorPosition(40, 13);
            Console.WriteLine("|\tC# Programs Inc.\t\t| ");
            Console.SetCursorPosition(40, 14);
            Console.WriteLine("|\tIT-DEV 115 intermediate C#\t|");
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("|\tMid-Term Election Application\t|");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("|\tProf: Mike Hunsicker\t\t|");
            Console.SetCursorPosition(40, 17);
            Console.WriteLine("|\t\t\t\t\t|");
            Console.SetCursorPosition(40, 18);
            Console.WriteLine("|\t\t\t\t\t|");
            Console.SetCursorPosition(40, 19);
            Console.WriteLine("└---------------------------------------┘");
            Thread.Sleep(1000);
            Console.SetCursorPosition(13, 15);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Eli Hurst");
            Thread.Sleep(1000);
            Console.SetCursorPosition(57, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The");
            Thread.Sleep(1000);
            Console.SetCursorPosition(57, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Election");
            Thread.Sleep(1000);
            Console.SetCursorPosition(97, 15);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("App");
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void Title()
        {
            string high = "VOTE";
            string low = "NOW";
            int colorCycle = 0;
            do
            {

                Console.SetCursorPosition(57, 5);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(50);
                Console.WriteLine(high);
                Console.SetCursorPosition(57, 25);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(50);
                Console.WriteLine(low);
                Console.SetCursorPosition(57, 5);
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(50);
                Console.WriteLine(high);
                Console.SetCursorPosition(57, 25);
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(50);
                Console.WriteLine(low);
                Console.SetCursorPosition(57, 5);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(50);
                Console.WriteLine(high);
                Console.SetCursorPosition(57, 25);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(50);
                Console.WriteLine(low);
                Console.SetCursorPosition(57, 5);
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(50);
                Console.WriteLine(high);
                Console.SetCursorPosition(57, 25);
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(50);
                Console.WriteLine(low);
                colorCycle++;
            }
            while (colorCycle < 7);
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 15);
                Console.WriteLine("Hello and Welcome!");
                Console.SetCursorPosition(93, 30);
                Console.WriteLine("Mid-Term");
                Console.SetCursorPosition(93, 31);
                Console.WriteLine("Code 4 Projects");
                Console.SetCursorPosition(93, 32);
                Console.WriteLine("\u00A9 2018");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        public void Intro()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Beep(200, 1000);
            Console.WriteLine("±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±");
            Console.WriteLine("Hello and welcome to the 2018 Election for whatever political position you want!");
            Console.WriteLine("You get to input whayever candidates are running and how ever many votes you want each person to have!");
            Console.WriteLine("this is supposed to mimic real life elections where you think the popular vote matters but it doesnt!");
            Console.WriteLine("because at the end of the day someone else decides who gets elected anyway.");
            Console.WriteLine("So behold the power of being the electoral college!");
            Console.WriteLine("\nPress any key to continue...");
            Console.WriteLine("\n±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±");
            Console.ReadKey();
            Console.Clear();
        }
        public void Goodbye()
        {
            player.Stop();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("The election is rigged!!!");
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Shutdown.wav";
            player.Play();
            Console.WriteLine("\n\nThanks for using this app! Goodbye!");
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadKey();
        }
    }
}
