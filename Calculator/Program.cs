
using Calculator;
using System;

namespace Assignment1
{
    class Program1
    {
       
       

        static void Main(string[] args)
        {
           
            
           

            bool finished = false;

            do
            {
                Console.WriteLine("Calculator menu enter a number to choose a function.\n");
             
                Console.WriteLine("1 --> addition.");
                Console.WriteLine("2 --> subtraction.");
                Console.WriteLine("3 --> multiplication.");
                Console.WriteLine("4 --> division.");


                Console.Write("----------------------------------------------------------------------\n");

                Console.Write("Choose : 1 to 4  \n");


                int selection = int.Parse(Console.ReadLine());
                cal c = new cal();

                Console.Write("----------------------------------------------------------------------\n");

                switch (selection)
                {
                    case 1:
                       



                        Console.WriteLine("Enter 2 nums with comma (',') overload method");
                        
                        int[] add = inputRead();
                        if (add.Length == 2)

                           print(c.Addition(add[0], add[1]));
                        
                        else
                            print(c.Addition(add));
                        
                        break;
                        case 2:
                        Console.WriteLine("Enter 2 nums with comma (',') overload method");
                        int[] sub = inputRead();
                        if (sub.Length == 2)

                            print(c.Subtraction(sub[0], sub[1]));
                        else
                            print(c.Subtraction(sub));
                        break;

                        case 3:
                        Console.WriteLine("Enter 2 nums with comma (',') overload method");
                        int[] mul = inputRead();
                        if (mul.Length == 2)
                            print(c.Multiplication(mul[0], mul[1]));
                        else
                            print(c.Multiplication(mul));
                       
                        break;
                    case 4:
                        double first = Convert.ToDouble(Console.ReadLine());
                        double sec = Convert.ToDouble(Console.ReadLine());
                         Console.WriteLine(c.Division(first,sec));
                        break;
                    default:
                        Console.WriteLine("No valid selection please choose (1-4)");
                        break;
                        

                }


                Console.WriteLine("\nWill you like to choose another option? press Y to continue or Q to quit");
                char b = char.Parse(Console.ReadLine());

                if (b == 'y')
                {
                    finished = false;
                }
                else if (b == 'q')
                {

                    finished = true;

                }else
                {
                    break;
                }

                Console.Clear();
            } while (!finished);


        }

        private static int[] inputRead()
        {
            string str = Console.ReadLine();
          

            string[] stringArray = str.Split(',');
            //  Console.ReadLine().Replace(" ", "").Split(',').Select(str => int.Parse(str)).ToArray();
            int[] convertedInt = Array.ConvertAll(stringArray, s => int.Parse(s));

            return convertedInt;

        }



        private static void print(int display)
        {
            Console.WriteLine(display.ToString());
        }
        
    }
   

}



