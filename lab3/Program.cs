using System;

namespace lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello! Welcome to the Lab 3 Number Detective!");

            Console.Write("What is your name?  ");
            string username;
            username = Console.ReadLine();

            Start:

            Console.Write($"{username}, please enter an integer between 1 and 100:  ");
            string userchoice = Console.ReadLine();

            int num;
            bool isvalidnumber = int.TryParse(userchoice, out num);

            if (num >= 1 && num <= 100 && isvalidnumber)
                {
                if (num % 2 != 0 && num > 60)
                {
                    Console.WriteLine($"{num}, Odd.");
                }
                else if (num % 2 != 0)
                {
                    Console.WriteLine($"{num}, Odd.");
                }
                else if (num < 26 && num % 2 == 0)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (num % 2 == 0 && num > 25 && num < 61)
                {
                    Console.WriteLine("Even");
                }
                else if (num % 2 == 0 && num > 60)
                {
                    Console.WriteLine($"{num}, Even");
                }
            
            }
            else
            {
                Console.WriteLine(userchoice + " isn't a valid number between 1 and 100, try again.");
                goto Start;
            }

            Console.Write("\nContinue? (y/n): ");             string response;             response = Console.ReadLine();             if (response == "y")             {                 Console.WriteLine("");                 goto Start;             }             else {
                Console.WriteLine("Bye!");
            }

        }
    }
}
