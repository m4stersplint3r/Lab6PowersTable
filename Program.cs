using System;

namespace Day3_Lab6_PowersTables
{
    class Program
    {
        public static int squareNumber(int x)
        {
            return x * x;
        }
        public static int cubeNumber(int x)
        {
            return x * x * x;
        }
        static void Main(string[] args)
        {
            int userInput = 0;
            bool runProgram = true;
            string responseYN;

            while(runProgram)
            {
                do
                {
                    Console.Write("Hello, please enter an integer: ");
                } while (!int.TryParse(Console.ReadLine(), out userInput));                

                //Console.WriteLine($"{Environment.NewLine}Number\tSquared\tCubed");
                //Console.WriteLine($"======\t======\t=====");
                Console.WriteLine(Environment.NewLine + "{0,-10} {1,-10} {2,-10}", "Number", "Squared", "Cubed");
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", "======", "======", "======");

                for (int i = 1; i <= userInput; i++)
                {
                    //Console.WriteLine($"{i}\t{squareNumber(i)}\t{cubeNumber(i)}");
                    Console.WriteLine("{0,-10} {1,-10} {2,-10}", i, squareNumber(i), cubeNumber(i));
                }

                Console.Write($"{Environment.NewLine}Would you like to continue? (y/n): ");
                responseYN = Console.ReadLine();
                if(!(responseYN.ToLower().Trim() == "y"))
                {
                    runProgram = false;
                }
                Console.WriteLine();
            }
            Console.WriteLine("See ya!");
        }
    }
}
