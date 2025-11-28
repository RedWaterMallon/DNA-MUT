using System.Formats.Asn1;
using System.Xml;

namespace Come_ON_C_Sharp
{
    internal class DNA_Mutation
    {
        private static void Main(string[] args)
        {
            // Take input from the user
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter Your Sampled Sequence: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string Mutated_Sequence = Console.ReadLine() ?? string.Empty;

            // Take input from the user
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter Your Normal Sequence: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string Main_Sequence = Console.ReadLine() ?? string.Empty;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Do you want to check similarity or difference Between the 2 sequences? [1 for difference ]  [2 for similarity ]");
            
            int sim_counter_int = 0;
            int dif_counter_int = 0;
            string opr = Console.ReadLine();
            int opr_int = int.Parse(opr);
            Console.ForegroundColor = ConsoleColor.Green;

            if (opr_int  == 1)
            {
                // check if the if input is not equal in length
                if (Main_Sequence.Length != Mutated_Sequence.Length || Main_Sequence.Length < Mutated_Sequence.Length || Main_Sequence.Length > Mutated_Sequence.Length)
                {
                    Console.WriteLine("The length  of the Main-Sequence is already not equal to the length of Sampled-Sequence");
                }
                // Print and highlight the changed bases
                else if (Main_Sequence.Length == Mutated_Sequence.Length)
                {
                    Console.WriteLine("\nOverview\n");

                    Console.WriteLine($"Length: {Main_Sequence.Length}\n");

                    for (int i = 0; i < Main_Sequence.Length; i++)
                    {
                        if (Main_Sequence[i] == Mutated_Sequence[i])
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{Main_Sequence[i]}");
                        }
                        else if (Main_Sequence[i] != Mutated_Sequence[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{Mutated_Sequence[i]}");
                            dif_counter_int++;
                        }

                    }
                    Console.Write("\n\n");
                    
                    Console.Write($"Degree of difference = {(double)(dif_counter_int*100/ Main_Sequence.Length)}%");

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n");

                Console.Write("\nIndex\tNormal\tMutation\n");

                for (int i = 0; i < Main_Sequence.Length; i++)
                {

                    if (Main_Sequence[i] != Mutated_Sequence[i])
                    {
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\t{Main_Sequence[i]}");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"\t{Mutated_Sequence[i]}\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }

                Console.ForegroundColor = ConsoleColor.White;

            }

            else if (opr_int  == 2)
            {

                // check if the if input is not equal in length
                if (Main_Sequence.Length != Mutated_Sequence.Length || Main_Sequence.Length < Mutated_Sequence.Length || Main_Sequence.Length > Mutated_Sequence.Length)
                {
                    Console.WriteLine("The length  of the Main-Sequence is already not equal to the length of Sampled-Sequence");
                }
                // Print and highlight the changed bases
                else if (Main_Sequence.Length == Mutated_Sequence.Length)
                {
                    Console.WriteLine("\nOverview\n");

                    Console.WriteLine($"Length: {Main_Sequence.Length}\n");

                    for (int i = 0; i < Main_Sequence.Length; i++)
                    {
                        if (Main_Sequence[i] != Mutated_Sequence[i])
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{Main_Sequence[i]}");
                        }
                        else if (Main_Sequence[i] == Mutated_Sequence[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{Mutated_Sequence[i]}");
                            sim_counter_int++;
                        }

                    }

                }
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n");
                Console.Write($"Degree of similarity = {(double)(sim_counter_int*100/ Main_Sequence.Length)}%");   

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n");

                Console.Write("\nIndex\tNormal\n");

                for (int i = 0; i < Main_Sequence.Length; i++)
                {

                    if (Main_Sequence[i] == Mutated_Sequence[i])
                    {
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\t{Main_Sequence[i]}\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }

                Console.ForegroundColor = ConsoleColor.White;

            }

        }




    }
}
