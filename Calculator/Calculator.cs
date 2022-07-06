using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class cal
    {
        public int Addition(int v1, int v2)
        {
            return v1 + v2;
        }


        public int Addition(int[] arr)
        {

            int x = 0;


            foreach (int i in arr)
            {
                x += i;
            }
            return x;

        }

        public int Subtraction(int v1, int v2)
        {
            return v1 - v2;
        }


        public int Subtraction(int[] arr)
        {

            int x = 0;


            foreach (int i in arr)
            {
                x -= i;
            }
            return x;
        }
        public int Multiplication(int v1, int v2)
        {
            return v1 * v2;
        }
        public int Multiplication(int[] arr)
        {
            int x = 1;

            foreach (int i in arr)
            {
                x *= i;

            }

            return x;

        }

        public double Division(double v1, double v2)
        {

             if(v1 < v2 && v2 < v1)
            {
                Console.WriteLine("Cannot divide by 0");
                return 0;
            }
            return v1 / v2;
        }
    }
}

      

            

