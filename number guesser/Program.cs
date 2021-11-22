using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            appinfo();
            WelcomeUser();  
            while (true) 
            { 
            Random random = new Random();
            int correctnu = random.Next(1,10);
            int guess = 0;
            Console.WriteLine("guess the correct number");
            while (guess != correctnu)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out guess)) {
                    string nactualnu = "please enter an actual number";
                    printmessage(ConsoleColor.Red,nactualnu);  
                    continue;
                }
                guess=Int32.Parse(input);  
                
                if(guess == correctnu)
                {
                    string Cmessage="correct answer";
                    printmessage(ConsoleColor.Green, Cmessage);

                        break;
                }
                string tryagain="try again";
                    printmessage(ConsoleColor.Red, tryagain);

                }
                Console.WriteLine("play again?[Y],[N]");
                string answer=Console.ReadLine().ToUpper();
                if (answer == "Y") { continue; }

                else { break; } 
                

            }
            string thanks="thanks for playing";

            printmessage(ConsoleColor.Yellow, thanks);


            Console.ReadLine();


        }
        static void appinfo()
        {
            string app = "number guesser";
            string version = "1.0.0";
            string creator = "Fathy Badr";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} is created by {2}", app, version, creator);
            Console.ResetColor();
        }
        static void WelcomeUser()
        {
            Console.WriteLine("what is your name");
            string inputname = Console.ReadLine();
            Console.WriteLine("welcome {0}", inputname);
        }
        static void printmessage (ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
