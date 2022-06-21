
using System;

namespace Assignment1
{
    class Program
    {
        static void Addition()
        {
            Console.WriteLine("addition");
        }
        static void Subtraction()
        {
            Console.WriteLine("subtraction");
        }
        static void Multiplication()
        {
            Console.WriteLine("multiplication");
        }
        static void Division()
        {
            Console.WriteLine("division");
        }
        static void Main(string[] args)
        {
            bool finished = false;

            do
            {
                Console.WriteLine("Calculator menu enter a number to choose a function.\n");
              /*  basic mathematical operations(addition, subtraction, multiplication, division) */
                Console.WriteLine("1 --> addition.");
                Console.WriteLine("2 --> subtraction.");
                Console.WriteLine("3 --> multiplication.");
                Console.WriteLine("4 --> division.");


                Console.Write("----------------------------------------------------------------------\n");

                Console.Write("Choose : 1 to 4  \n");


                int selection = int.Parse(Console.ReadLine());


                Console.Write("----------------------------------------------------------------------\n");

                switch (selection)
                {
                    case 1:
                        Addition();

                        break;
                        case 2:
                        Subtraction();
                        break;
                    case 3:
                        Multiplication();
                        break;
                    case 4:
                        Division();
                        break;
                    default:
                        Console.WriteLine("No valid selection please choose (1-4)");
                        break;


                }




                Console.WriteLine("\nWill you like to choose another option? press Y to continue or Q to quit");
                char c = char.Parse(Console.ReadLine());


                if (c == 'y')
                {
                    finished = false;
                }
                else if (c == 'q')
                {

                    finished = true;

                }else
                {
                    break;
                }

                Console.Clear();
            } while (!finished);




        }


    }
}





/*Your assignment is to create a basic Console-based calculator using C#. It should be able to 
handle basic mathematical operations (addition, subtraction, multiplication, division), and be 
able to present the results in a consistent way.
Required Features:
• The program should be able to perform basic mathematical operations (Math has 
methods for more advanced operations if you include them).
o Addition, Subtraction, Division, Multiplication, etc…
• The program should keep running until the user chooses to end it.
Code Requirements:
• Each mathematical operation should be in its own method.
o Division should inform the user if they try to divide by zero.
• Use a loop and a menu system to keep the program running.
*/