
/*using System;
namespace task1
{
    class program1
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Please enter your statment");
            string statment = Console.ReadLine();

            statment=statment.Trim();
            int w = 0;
            int l = 0;
            bool pw = false;
            for (int i = 0; i <= statment.Length-1; i++) 
            {
                char c = statment[i];
                if (char.IsWhiteSpace(c))
                {
                    if (!pw)
                    {
                        w++;
                        pw = true;
                    }
                }

                else 
                {
                    if (char.IsLetter(c))
                    {
                        l++;
                    }
                    pw = false;
                }

            }
            Console.WriteLine($"words: {w+1}");
            Console.WriteLine($"letters:{l}");
        }
    }
}*/