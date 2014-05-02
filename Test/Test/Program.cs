using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Test
{
    class Program
    {
        //Public Variables
        static string name = "Chris";
        static string input = "";

        //Main Function
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Print("Hello " + name);
            Console.ResetColor();
            Thread.Sleep(500);
            Welcome();
        }

        //Welcome Function
        static void Welcome()
        {
            Print("What function do you want to test?");
            Thread.Sleep(500);

            Print("RandomFunction, ListManipulation, Hangman, Lambda, Lambda2, Beep, TextColor, Print, ArtText, Mario, WindowSize, Objects, End");

            input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "randomfunction":
                case "random": Console.Clear(); RandomFunction(); break;
                case "listmanipulation":
                case "list": Console.Clear(); ListManipulation(); break;
                case "hangman": Console.Clear(); Hangman(); break;
                case "lambda": Console.Clear(); Lambda(); break;
                case "lambda2": Console.Clear(); Lambda2(); break;
                case "beep": Console.Clear(); Beep(); break;
                case "text":
                case "textcolor": Console.Clear(); TextColor(); break;
                case "print": Console.Clear(); Print("This text should be printing correctly."); End(); break;
                case "arttext":
                case "art": Console.Clear(); ArtText(); break;
                case "mario": Console.Clear(); Mario(); break;
                case "windowsize":
                case "window": Console.Clear(); WindowSize(); break;
                case "end":
                case "": Console.Clear(); End(); break;
                case "objects": Console.Clear(); Objects(); break;
                default: Console.Clear(); Print("I can't find that function."); Console.WriteLine(); Welcome(); break;
            }
        }


        /// <summary>
        /// This script is where I create and test different functions to come back to.
        /// </summary>
        /// <param name="args">Arguments for my function</param>

        //RandomFunction Function
        //Finds a random number from 1 to what you type.
        static void RandomFunction()
        {
            Console.WriteLine("Type the ending number");
            var rawInput = Console.ReadLine();
            var input = Convert.ToInt32(rawInput);
            var randomTemp = new Random();
            var random = randomTemp.Next(1, input);
            Console.WriteLine(random);
            End();
        }

        //ListManipulation function
        static void ListManipulation()
        {
            var myStrings = new List<string>();
            var myInts = new List<int>();
            myInts.Add(1);
            myStrings.Add("a string");
            myStrings.Add("qwerty");
            var display = "";

            foreach (var item in myStrings)
            {
                display = display + item + ", ";
            }

            foreach (string item in myStrings)
            {
                Console.WriteLine(item);
            }
            foreach (int item in myInts)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("myStrings Alphabetically:");
            foreach (var item in myStrings.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Longest to shortest:");
            var reversedProducts = myStrings.OrderByDescending(x => x.Length);
            foreach (var item in reversedProducts)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            Console.WriteLine("Ball Products:");
            //"Ball" || "ball"
            var ballProducts = myStrings.Where(x => x.Contains("a") || x.Contains("A"));
            foreach (var item in ballProducts)
            {
                Console.Write(item);
            }


            Console.WriteLine();
            Console.WriteLine("Display");
            Console.Write(display);
            Console.WriteLine();
            End();
        }


        /// <summary>
        /// This is my awesome function
        /// </summary>
        /// <param name="args">Arguments for my function</param>
        static void Hangman()
        {
            string[] randomArray = { };
            End();
        }

        //Lambda Functions
        static void Lambda()
        {
            var list = new List<string>() { "clifford", "ethan", "bailey" };
            var shortestWord = list.OrderBy(x => x.Length).First();

            Console.WriteLine(shortestWord);


            End();
        }

        //Lambda2
        static void Lambda2()
        {
            var fruit = new List<string>() { "Blackberry", "Strawberry", "Apple", "Blueberry" };

            var berries = fruit.Where(x => x.Contains("berry"));
            var notBerries = fruit.Where(x => !x.Contains("berry"));
            Thread.Sleep(500);
            Console.WriteLine("Do you want to see 'berry'?");
            var input = Console.ReadLine().ToString().ToLower();
            if (input == "yes")
            {
                foreach (var item in berries)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(100);
                }
            }
            else if (input == "no")
            {
                foreach (var item in notBerries)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(100);
                }
            }

            End();
        }

        //Beep Function
        static void Beep()
        {
            //E6
            Console.Beep(1318, 400);
            //B5
            Console.Beep(988, 200);
            //C6
            Console.Beep(1046, 200);
            //D6
            Console.Beep(1175, 400);
            //C6
            Console.Beep(1046, 200);
            //B5
            Console.Beep(988, 200);
            //A5
            Print("Beep");
            Console.Beep(880, 400);
            Console.Beep(880, 200);
            Console.Beep(1046, 200);
            Console.Beep(1318, 400);
            Console.Beep(1175, 200);
            Console.Beep(1046, 200);
            Print("Beep");
            Console.Beep(988, 600);
            Console.Beep(988, 200);
            Console.Beep(1175, 400);
            Console.Beep(1318, 400);
            Console.Beep(1046, 400);
            Console.Beep(880, 400);
            Console.Beep(880, 400);
            Print("Beep");

            Thread.Sleep(600);

            Console.Beep(1175, 600);
            //F6
            Console.Beep(1397, 200);
            //A6
            Console.Beep(1760, 400);
            //G6
            Console.Beep(1568, 200);
            Print("Beep");
            //F6
            Console.Beep(1397, 200);
            Console.Beep(1318, 200);
            Console.Beep(1318, 400);
            Console.Beep(1046, 200);
            Console.Beep(1318, 400);
            Console.Beep(1175, 200);
            Console.Beep(1046, 200);
            Print("Beep");
            Console.Beep(988, 400);
            Console.Beep(988, 200);
            Console.Beep(1046, 200);
            Console.Beep(1175, 400);
            Console.Beep(1318, 400);
            Console.Beep(1046, 400);
            Console.Beep(880, 400);
            Console.Beep(880, 400);

            End();
        }

        //TextColor Function
        static void TextColor()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Print("White on blue.");
            Print("Another Line");
            Console.ResetColor();
            End();
        }

        //Print Function
        static void Print(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                Thread.Sleep(10);
            }
            Console.WriteLine();
        }

        //ArtText Function
        static void ArtText()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                                                                           
         █████╗ ██████╗ ████████╗████████╗███████╗██╗  ██╗████████╗        
        ██╔══██╗██╔══██╗╚══██╔══╝╚══██╔══╝██╔════╝╚██╗██╔╝╚══██╔══╝        
        ███████║██████╔╝   ██║      ██║   █████╗   ╚███╔╝    ██║           
        ██╔══██║██╔══██╗   ██║      ██║   ██╔══╝   ██╔██╗    ██║           
        ██║  ██║██║  ██║   ██║      ██║   ███████╗██╔╝ ██╗   ██║           
        ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝      ╚═╝   ╚══════╝╚═╝  ╚═╝   ╚═╝           
                                                                           
");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
                                                                           
         █████  ██████  ████████ ████████ ███████ ██   ██ ████████         
        ██   ██ ██   ██    ██       ██    ██       ██ ██     ██            
        ███████ ██████     ██       ██    █████     ███      ██            
        ██   ██ ██   ██    ██       ██    ██       ██ ██     ██            
        ██   ██ ██   ██    ██       ██    ███████ ██   ██    ██            
                                                                           
");

            Console.ResetColor();
            End();
        }

        //Mario
        static void Mario()
        {

            Console.WriteLine("                                                ██████████    ██████  ");
            Console.WriteLine("                                              ██████████████████████  ");
            Console.WriteLine("                                              ██████████████  ██████  ");
            Console.WriteLine("                                            ████████████████████████  ");
            Console.WriteLine("                                            ████████████████████████  ");
            Console.WriteLine("                                            ██████████████████████    ");
            Console.WriteLine("                                                ██████████████████    ");
            Console.WriteLine("                                    ████████████████████████████    ██");
            Console.WriteLine("                                    ██████████████████████████    ████");
            Console.WriteLine("                                      ██      ████████████████████████");
            Console.WriteLine("                                                ██████████████████████");
            Console.WriteLine("                                            ██████████████████████████");
            Console.WriteLine("                                          ██████████████████          ");
            Console.WriteLine("                                          ████                        ");
            End();
        }

        //WindowSize
        static void WindowSize()
        {
            var width = "";
            var height = "";
            
            Print("What dimensions do you want Width?");
            Print("(Max is 200)");
            width = Console.ReadLine();
            Console.Clear();
            
            if (width == "default")
            {
                width = "80";
                height = "25";
                Console.SetWindowSize(65, 25);
            }
            else if (Convert.ToInt32(width) > 200)
            {
                width = "65";
                height = "25";
                Console.Clear();
                Print("Enter a number within the the max width");
                Console.WriteLine();
                WindowSize();
            }
            else
            {
            Print("What dimensions do you want Height?");
            Print("(Max is 65)");
            height = Console.ReadLine();
            Console.Clear();
            }
            if (Convert.ToInt32(height) > 65)
            {
                width = "65";
                height = "25";
                Console.Clear();
                Print("Enter a number within the the max height");
                Console.WriteLine();
                WindowSize();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Print(width + "x" + height);
            Console.ResetColor();
            Console.SetWindowSize(Convert.ToInt32(width), Convert.ToInt32(height));


            End();
        }

        //Objects Function
        static void Objects()
        {
            videoGame battlefield = new videoGame("Battlefield", "Code for Video Game here", "First-Person Shooter");
            battlefield.Play();
            //Adding info to properties
            battlefield.Awesomeness = 11;
            battlefield.Rating = "M";
            //Modifying existing property value
            battlefield.Code = "New Video Game Code";
            battlefield.Play();
            End();
        }

        //End Function
        static void End()
        {
            Thread.Sleep(500);
            Console.WriteLine();
            Print("Do you want to try another function?");
            input = Console.ReadLine().ToLower();

            if (input == "yes" || input == "y")
            {
                Console.Clear();
                Welcome();
            }
            else if (input == "no" || input == "n" || input == "")
            {
                Console.WriteLine();
                Print("Press any key to continue");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Print("Please type Yes or No");
                End();
            }
        }
    }
}
