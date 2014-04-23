
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
            Print("Hello " + name);
            Thread.Sleep(500);
            Welcome();
        }

        //Welcome Function
        static void Welcome()
        {
            Print("What function do you want to test?");
            Thread.Sleep(500);

            Print("RandomFunction, ListManipulation, Hangman, Lambda, Lambda2, Beep, TextColor, Print, End");

            input = Console.ReadLine().ToLower();
            if (input == "randomfunction")
            {
                Console.Clear();
                RandomFunction();
            }
            else if (input == "listmanipulation")
            {
                Console.Clear();
                ListManipulation();
            }
            else if (input == "hangman")
            {
                Console.Clear();
                Hangman();
            }
            else if (input == "lambda")
            {
                Console.Clear();
                Lambda();
            }
            else if (input == "lambda2")
            {
                Console.Clear();
                Lambda2();
            }
            else if (input == "beep")
            {
                Console.Clear();
                Beep();
            }
            else if (input == "textcolor")
            {
                Console.Clear();
                TextColor();
            }
            else if (input == "print")
            {
                Console.Clear();
                Print("This text should be printing correctly.");
                End();
            }
            else if (input == "end" || input == "")
            {
                Console.Clear();
                End();
            }
            else
            {
                Console.Clear();
                Print("I can't find that function.");
                Console.WriteLine();
                Welcome();

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

            foreach (var s in myStrings)
            {
                display = display + s + ", ";
            }

            foreach (int s in myInts)
            {
                display = display + s + ", ";
            }
            Console.WriteLine(display);
            End();
        }


        /// <summary>
        /// This is my awesome function
        /// </summary>
        /// <param name="args">Arguments for my function</param>
        static void Hangman()
        {
            //this is the word they need to guess
            var theWord = "apples";
            //these are the letters that they've guessed
            var guessed = new List<string>() { "a", "b", "c", "p", "e" };
            //this is the masked word that will be displayed to the user
            var maskedWord = "";
            //Loop over the word they need to guess
            for (var i = 0; i < theWord.Length; i++)
            {
                //this is the current letter of the word they need to guess
                var currentLetter = theWord[i].ToString();
                //this is a boolean flag to determine if they got a letter correct
                var gotOne = false;
                //this loops over the letters they have guessed
                for (var j = 0; j < guessed.Count(); j++)
                {
                    //this is the letter in the list of letters they've guessed
                    var currentGuessed = guessed[j];
                    //checking to see if the current letter of the word they need to guess
                    // is equal to a letter they have guessed
                    if (currentLetter == currentGuessed)
                    {
                        //got a letter!
                        gotOne = true;
                    }
                }
                //they got a letter!
                if (gotOne)
                {
                    //add the letter they got to the masked word
                    maskedWord += currentLetter + " ";
                }
                else
                {
                    //havent guessed it yet, make an underscore.
                    maskedWord += "_ ";
                }
            }

            Console.WriteLine(maskedWord);
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

        //End Function
        static void End()
        {
            Thread.Sleep(500);
            Console.WriteLine();
            Print("Do you want to try another function?");
            input = Console.ReadLine().ToLower();

            if (input == "yes")
            {
                Console.Clear();
                Welcome();
            }
            else if (input == "no" || input == "")
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
