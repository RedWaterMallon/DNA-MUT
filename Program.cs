using System.Reflection;
using System.Transactions;

namespace Come_ON_C_Sharp
{
    internal class Program
    {
        static void main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string sequence = "";
            Console.Write("Enter your sequence: ");
            Console.ForegroundColor = ConsoleColor.Blue;

            sequence = Console.ReadLine() ?? string.Empty;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Complementary sequence is : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == 'A')
                {
                    Console.Write("T");
                }

                if (sequence[i] == 'T')
                {
                    Console.Write("A");
                }

                if (sequence[i] == 'G')
                {
                    Console.Write("C");
                }

                if (sequence[i] == 'C')
                {
                    Console.Write("G");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nThe total number of nucleotides is = ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(sequence.Length + " nucleotides");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            
        }


    }
}