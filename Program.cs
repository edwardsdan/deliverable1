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
       
           
 // Prompt in 2 methods for two separate strings. Compare length with 3rd method?

        static void Main(string[] args)
        {
            string firstInt = Prompt1();
            string secondInt = Prompt2();

            if (firstInt.Length == secondInt.Length)
            {
                char[] One = firstInt.ToCharArray();
                char[] Two = secondInt.ToCharArray();

                int[] A = One.Select(a => a - '0').ToArray(); // figure out what 'a' represents ***************
                int[] B = Two.Select(a => a - '0').ToArray(); // pretty sure this uses Linq, learn more
                int[] C = new int[A.Length];
                
                for (int i = 0; i < C.Length; i++)
                {
                    C[i] = A[i] + B[i];
                    if (C[i] == C[0])
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry! Try again!");
                Main(args);
                // recursive call method to compare string.length
            }
        }
    }
}