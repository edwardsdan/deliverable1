using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable1
{
    class Program
    {
        /* I should've stayed at GC last night. I haven't been able to get this to work
           I'll continue to work on this after submission, but this is what I have so far */
        public static (string, string) Prompt()
        {
            string firstNumber, secondNumber;

            Console.WriteLine("Please enter an integer");
            firstNumber = Console.ReadLine();

            Console.WriteLine("Please enter another integer with the same number of digits");
            secondNumber = Console.ReadLine();

            return (firstNumber, secondNumber);
        }

        public static string Test(int x, int y)
        {
            string stringX = x.ToString();
            string stringY = y.ToString();
            int[] NumbersX = new int[stringX.ToString().Length];
            int[] NumbersY = new int[stringY.ToString().Length];
            int[] Adding = { 0 };
            string TorF = "";

#pragma warning disable CS0162 // Unreachable code detected
            for (int i = -1; i < NumbersX.Length; i++) // I don't quite understand what's making code unreachable. Will figure it out
#pragma warning restore CS0162 // Unreachable code detected
            {
                NumbersX[i+1] = Convert.ToInt32(stringX[i+1]); 
                NumbersY[i+1] = Convert.ToInt32(stringX[i+1]);
                Adding[i+1] += NumbersX[i+1] + NumbersY[i+1];
                if (Adding[i+1] != Adding[i])
                {
                    TorF = "false";
                    return TorF;
                }
                else
                {
                    TorF = "true";
                    return TorF;
                }

            }
            return TorF;

        }

        static void Main(string[] args)
        {
            string firstNumber, secondNumber;
            firstNumber = "";
            secondNumber = "";
            Prompt();

            while(firstNumber.Length != secondNumber.Length)
            {
                Console.WriteLine("Sorry! Try again!");
                Prompt();
            }
            if (int.TryParse(firstNumber, out int number1) && int.TryParse(secondNumber, out int number2))
            {
                number1 = Convert.ToInt32(firstNumber);
                number2 = Convert.ToInt32(secondNumber);
                Console.WriteLine(Test(number1, number2));
            }
        }
    }
}