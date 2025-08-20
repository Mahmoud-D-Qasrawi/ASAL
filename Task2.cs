using System;
namespace task2 
{
    class program2
    {
        static void Main(string[] args) 
        {
            long x = 0;
            long y = 0;
            long g = 0;
            string input = "";
            long a = ReadInt("Please enter the numerator of the first fraction");
            long b = ReadInt("Please enter the denominator of the first fraction");
            while (b == 0)
            {
                Console.WriteLine("Invalid input the denominator can't be zero please try again");
                b = ReadInt("");
            }

            Console.WriteLine("Please enter the opreation");
            input = Console.ReadLine();
            char o=char.Parse(input);

            long c = ReadInt("Please enter the numerator of the second fraction");
            long d = ReadInt("Please enter the denominator of the second fraction");
            while (d == 0)
            {
                Console.WriteLine("Invalid input the denominator can't be zero please try again");
                d = ReadInt("");
            }


            switch (o)
            {
                case '+':
                    x = (a * d + b * c);
                    y = (b * d);
                    g = GCF(x, y);
                    Console.WriteLine($"The result is {x/g}/{y/g}");
                    break;
                case '-':
                    x = (a * d - b * c);
                    y = (b * d);
                    g = GCF(x, y);
                    Console.WriteLine($"The result is {x / g}/{y / g}");
                    break;
                case '*':
                    x = (a * c);
                    y = (b * d);
                    g = GCF(x, y);
                    Console.WriteLine($"The result is {x / g}/{y / g}");
                    break;
                case '/':
                    if (c == 0)
                    {
                        Console.WriteLine("Invalid input (division by zero)!");
                        break;
                    }
                    x = (a * d);
                    y = (b * c);
                    g = GCF(x, y);
                    if (g == 0)
                    {
                        Console.WriteLine("Math error: cannot simplify (GCF = 0).");
                        break;
                    }
                    else {
                        Console.WriteLine($"The result is {x / g}/{y / g}"); }
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;

            }
        }
        static long GCF(long x, long y)
        {
            long r = 1;
            long b;
            long s;
            if (x < 0) x = x * -1;
            if (y < 0) y = y * -1;
            if (x > y)
            {
                b = x;
                s = y;
            }
            else
            if (y > x)
            {
                b = y;
                s = x;
            }
            else
            {
                return x;
            }
            while (r != 0)
            {
                r = b % s;
                b = s;
                s = r;
            }
            return b;
        }

        static int ReadInt(string message)
        {
            int value;
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid input! Please enter a number:");
            }
            return value;
        }

    }
}