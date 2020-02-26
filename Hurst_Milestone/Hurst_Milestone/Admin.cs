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

namespace Hurst_Milestone
{
    class Admin
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        SoundPlayer player = new SoundPlayer();
        Random rand = new Random();
        public void ConsoleSetup() //Sets up console colors and intro, as well as music
        {
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Depth Charge Intro.wav";
            player.Play();
            Thread.Sleep(4700);
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\crazy.wav";
            player.Play();
            Console.Title = "The Dragon's Lair";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
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
            Console.WriteLine("|\tIT-DEV 110 Intro to OOP C#\t|");
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("|\tMilestone Project\t\t|");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("|\tProf: Larry Domine\t\t|");
            Console.SetCursorPosition(40, 17);
            Console.WriteLine("|\t\t\t\t\t|");
            Console.SetCursorPosition(40, 18);
            Console.WriteLine("|\t\t\t\t\t|");
            Console.SetCursorPosition(40, 19);
            Console.WriteLine("└---------------------------------------┘");
            Thread.Sleep(1000);
            Console.SetCursorPosition(13, 15);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Eli Hurst");
            Thread.Sleep(1000);
            Console.SetCursorPosition(57, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The");
            Thread.Sleep(1000);
            Console.SetCursorPosition(57, 25);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dragon's");
            Thread.Sleep(1000);
            Console.SetCursorPosition(97, 15);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lair!");
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void Title()
        {
            string high = "░";
            string low = "▒";
            int colorCycle = 0;

            do
            {
                Console.SetCursorPosition(43, 18);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("          ^      ^              ");
                Console.SetCursorPosition(43, 19);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("         ^^^^  ^^^^             ");
                Console.SetCursorPosition(43, 20);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("        ^^^^^ ^^^^^^            ");
                Console.SetCursorPosition(43, 21);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("        ^^^^^^ ^^^^^^           ");
                Console.SetCursorPosition(43, 22);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("       ^^^^^^^^^^^^^^^^         ");
                Console.SetCursorPosition(43, 23);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("     ^^^^^^^^^^^^^^^^^^^^       ");
                Console.SetCursorPosition(43, 24);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("    ^^^^^^^^^^^^^^^^^^^^^^      ");
                Console.SetCursorPosition(43, 25);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("    ^^^^^^^^^^^^^^^^^^^^^^^     ");
                Console.SetCursorPosition(43, 26);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("   ^^^^^^^^^^^^^^^^^^^^^^^^^^   ");
                Console.SetCursorPosition(43, 27);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ ");
                Console.SetCursorPosition(rand.Next(56, 58), 20);
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(10);
                Console.WriteLine(high);
                Console.SetCursorPosition(rand.Next(56, 58), 19);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(10);
                Console.WriteLine(low);
                Console.SetCursorPosition(rand.Next(56, 58), 18);
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(10);
                Console.WriteLine(high);
                Console.SetCursorPosition(rand.Next(55, 59), 17);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(10);
                Console.WriteLine(low);
                Console.SetCursorPosition(rand.Next(54, 60), 16);
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(10);
                Console.WriteLine(high);
                Console.SetCursorPosition(rand.Next(53, 61), 15);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(10);
                Console.WriteLine(low);
                Console.SetCursorPosition(rand.Next(52, 62), 14);
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(10);
                Console.WriteLine(high);
                Console.SetCursorPosition(rand.Next(51, 63), 13);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(10);
                Console.WriteLine(low);
                Console.SetCursorPosition(rand.Next(50, 64), 12);
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(10);
                Console.WriteLine(high);
                Console.SetCursorPosition(rand.Next(49, 65), 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(10);
                Console.WriteLine(low);
                Console.SetCursorPosition(rand.Next(48, 66), 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(10);
                Console.WriteLine(high);
                Console.SetCursorPosition(rand.Next(47, 67), 9);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(10);
                Console.WriteLine(low);
                Console.SetCursorPosition(rand.Next(46, 68), 8);
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(10);
                Console.WriteLine(high);
                Console.SetCursorPosition(rand.Next(45, 69), 7);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(10);
                Console.WriteLine(low);
                Console.SetCursorPosition(rand.Next(44, 70), 6);
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(10);
                Console.WriteLine(high);
                Console.SetCursorPosition(rand.Next(43, 71), 5);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(10);
                Console.WriteLine(low);
                //Console.Clear();
                colorCycle++;
            }
            while (colorCycle < 12);
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(50, 15);
                Console.WriteLine("Hello and Welcome!");
                Console.SetCursorPosition(93, 30);
                Console.WriteLine("Milestone Proj.");
                Console.SetCursorPosition(93, 31);
                Console.WriteLine("Code 4 Projects");
                Console.SetCursorPosition(93, 32);
                Console.WriteLine("\u00A9 2017");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        public void ConsoleSetupNoMoreLives()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
        }
        public void Intro()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep(200, 1000);
            Console.WriteLine("±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±");
            Console.WriteLine("\nWelcome to... THE DRAGONS LAIR!!!!");
            Console.WriteLine("\n\t\tThis is an adventure game where you are the hero named Dash");
            Console.WriteLine("\t\tBe captivated by the epic story that will unfold before you");
            Console.WriteLine("\t\tSee if you can fight your way to the end and reach....");
            Console.WriteLine("\t\t\t\tTHE DRAGONS LAIR!!!");
            Console.WriteLine("\nPress any key to continue...");
            Console.WriteLine("\n±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±±");
            Console.ReadKey();
            Console.Clear();
        }

        public void Goodbye()
        {

            player.Stop();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("This game is leet sauce dawg!");
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Shutdown.wav";
            player.Play();
            Console.WriteLine("Thanks for using this app! Goodbye!");
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadKey();
        }
    }
}