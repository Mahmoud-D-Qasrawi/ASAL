using System;
namespace task3
{
    class program3
    {
        static void Main(string[] args)
        {
            const string password = "35";
            int attempts = 3;
            string input = "";
            Console.WriteLine("Pleas enter your password");
            while (attempts > 0 && input != password)
            {
                input = Console.ReadLine().Trim();
                if (input == password)
                {
                    Console.WriteLine("Successful login");
                }
                else
                {
                    attempts--;
                    if (attempts == 1)
                    {
                        Console.WriteLine("Worng password last attempt left");
                        
                    }
                    else
                    if (attempts == 0)
                    {
                        Console.WriteLine("All attempts are done");

                    }
                    else
                    {
                        Console.WriteLine($"Worng password {attempts} attempts left");

                    }
                }
            }
        }
    }
}
