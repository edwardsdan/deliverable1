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

        public static bool Task(string x, string y)
        {
// converts strings to intarrays
            char[] One = x.ToCharArray();
            char[] Two = y.ToCharArray();

            int[] A = One.Select(a => a - '0').ToArray();
            int[] B = Two.Select(a => a - '0').ToArray();

// compares sums of A and B, writes to console whether all sums are equal
            bool TorF = true;
            int[] C = new int[A.Length];
            int i = 0;

            while (i < C.Length)
            {
                C[i] = x[i] + y[i];
                if (C[0] != C[i])
                {
                    i = C.Length;
                    TorF = false;
                }
                else
                {
                    TorF = true;
                    i++;
                }
            }
            Console.WriteLine(TorF);
            return TorF;
        }

        static void Main(string[] args)
        {
// prompts user for integers
            string firstInt = Prompt1();
            string secondInt = Prompt2();
            int first;
            int second;

// checks if inputs are integers, lengths of inputs, and prompts again if neither are true
            if (Int32.TryParse(firstInt, out first) == true && Int32.TryParse(secondInt, out second) == true)
            {
                if (firstInt.Length == secondInt.Length)
                {
                    Task(firstInt, secondInt);
                }
                else
                {
                    Console.WriteLine("Sorry! Try again!");
                    Main(args);
                }
            }
            else
            {
                Console.WriteLine("Sorry! Try again!");
                Main(args);
            }
            
        }
    }
}