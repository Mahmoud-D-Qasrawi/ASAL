using System;
namespace task3
{
    class program3
    {
        static void Main(string[] args)
        {
            string password = "35";
            int attempts = 3;
            string input = "";
            Console.WriteLine("Pleas enter your password");
            while (attempts >= 0 && input != password)
            {
                input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine("Successful login");
                }
                else
                {
                    if (attempts == 1)
                    {
                        Console.WriteLine("Worng password last attempt left");
                        attempts--;
                    }
                    else
                    if (attempts == 0)
                    {
                        Console.WriteLine("All attempts are done");
                        attempts--;
                    }
                    else
                    {
                        Console.WriteLine($"Worng password {attempts} attempts left");
                        attempts--;
                    }
                }
            }
        }
    }
}
