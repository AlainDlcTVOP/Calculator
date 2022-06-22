
using System;

namespace Assignment1
{
    class Program
    {
        static void Addition()
        {
            Console.WriteLine("Enter a number\n");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the secound number\n");
            var secound = Convert.ToInt32(Console.ReadLine());
            var result = first + secound; 
            Console.WriteLine($"{first} + {secound} = {result}");

        }
        static void Subtraction()
        {

            Console.WriteLine("Enter a number\n");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the secound number\n");
            var secound = Convert.ToInt32(Console.ReadLine());
            var result = first - secound;
            Console.WriteLine($"{first} - {secound} = {result}");
        }
        static void Multiplication()
        {

            Console.WriteLine("Enter a number\n");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the secound number\n");
            var secound = Convert.ToInt32(Console.ReadLine());
            var result = first * secound;
            Console.WriteLine($"{first} * {secound} = {result}");
        }
        static void Division()
        {
            Console.WriteLine("Enter a number\n");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the secound number\n");
            double y = Convert.ToInt32(Console.ReadLine());



            try
            {
                Console.WriteLine("{0}/{1}= {2}", x, y, x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by 0");
              
            }

        
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





