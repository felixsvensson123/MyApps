using System;

namespace Guess_the_number
{
    class Program
    {
        public static void Main(string[] args)
        {

            System.Random random = new System.Random(); //Iniatizilerar slump nummer metod
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------------------------");
                Console.WriteLine("Welcome to Guess the number!");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Choose a number between 0-50"); //printar instruktioner
                Console.WriteLine("----------------------------");
                int rnd = random.Next(1, 50); //regler för metoden lagrad i en variabel
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input > 50)
                    {             
                        Console.WriteLine("You have to use numbers from 0 - 50. Please try again.");
                    }
                    else if (input == rnd)
                    {
                        Console.Clear();
                        Console.WriteLine("You guessed the correct number, congratulations!" + "\n" + "Enter y to start again, n to exit the program.");
                        string startExit = Console.ReadLine();
                        if (startExit == "Yes")
                            continue;
                        if (startExit == "No")
                            break;
                    }                  
                }
                catch (FormatException failure)
                {
                    Console.Clear();
                    Console.WriteLine(failure);
                    Console.WriteLine("\nPress any button to start again . . .");
                    Console.ReadKey();
                }

                
            }
            Console.Clear();
            Console.WriteLine("Thank you for playing! Have a great day!");
        }

    }
}
