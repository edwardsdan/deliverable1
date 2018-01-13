using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable1
{
    class Program
    {
        public static string Prompt1()
        {
            Console.WriteLine("Please enter an integer");
            string x = Console.ReadLine();
            return x;
        }

        public static string Prompt2()
        {
            Console.WriteLine("Please enter another integer with the same number of digits");
            string y = Console.ReadLine();
            return y;
        }
       
            /* ignore >>>>>>>>>>>
             * int b = y.Length;

        int a = x.Length;
            if(a == b)
            {
                return (x, y);
            }
            else
            {
                Console.WriteLine("Sorry! Try again!");
                x = "";
                y = "a";
                Prompt(x, y);
                return (x, y);
            }*/
 // Prompt in 2 methods for two separate strings. Compare length with 3rd method?

        static void Main(string[] args)
        {
            string firstInt = Prompt1();
            string secondInt = Prompt2();
            
            if (firstInt.Length == secondInt.Length)
            {
                int[] int1 = new int[firstInt.Length];
                int[] int2 = new int[secondInt.Length];
                for (int c = 0; c <= firstInt.Length; c++)
                {
                    int1[c] = Convert.ToInt32(firstInt[c]);
                    int2[c] = Convert.ToInt32(secondInt[c]);
                }
            }
            else
            {
                Console.WriteLine("Sorry! Try again!");
                /* recursive call method to compare string.length*/
            }
            /*int[] p = new int[firstNumber.Length]; // reminder!
            int[] q = new int[secondNumber.Length];
            for (int i = 0; i < firstNumber.Length; i++)
            {
                p[i] = firstNumber[i] - '0';
                q[i] = secondNumber[i] - '0';
                Console.WriteLine(p[i] + " " + q[i]);
            }*/
        }




        // ignore the rest of this?

            /*if (int.TryParse(firstNumber, out int number1) && int.TryParse(secondNumber, out int number2))
            {
                number1 = Convert.ToInt32(firstNumber);
                number2 = Convert.ToInt32(secondNumber);
                Console.WriteLine(Test(number1, number2));
            }*/


            /*public static string Test(int x, int y)
        {
            string stringX = x.ToString();
            string stringY = y.ToString();
            int[] NumbersX = new int[stringX.Length];
            int[] NumbersY = new int[stringY.Length];
            int[] Adding = { 0 };
            string TorF = "";

            for (int i = -1; i < NumbersX.Length; i++)
            {
                NumbersX[i+1] = Convert.ToInt32(stringX[i+1]); 
                NumbersY[i+1] = Convert.ToInt32(stringX[i+1]);
                Adding[i+1] += NumbersX[i+1] + NumbersY[i+1];
                if (Adding[i+1] != Adding[i])
                {
                    TorF = "false";
                }
                else
                {
                    TorF = "true";
                }

            }
            return TorF;

        }*/
    }
}