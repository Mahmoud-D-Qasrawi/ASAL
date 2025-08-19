/*using System;
namespace task2 
{
    class program2
    {
        static void Main(string[] args) 
        {
            int x = 0;
            int y = 0;
            int g = 0;
            string input = "";
            Console.WriteLine("Please enter the numerator of the first fraction");
            input = Console.ReadLine();
            int a = int.Parse(input);
            Console.WriteLine("Please enter the denominator of the first fraction");
            input = Console.ReadLine();
            int b = int.Parse(input);
            while (b == 0)
            {
                Console.WriteLine("Invalid input the denominator can't be zero please try again");
                input = Console.ReadLine();
                b = int.Parse(input);
            }
            Console.WriteLine("Please enter the opreation");
            input = Console.ReadLine();
            char o=char.Parse(input);
            Console.WriteLine("Please enter the numerator of the second fraction");
            input = Console.ReadLine();
            int c = int.Parse(input);
            Console.WriteLine("Please enter the denominator of the second fraction");
            input = Console.ReadLine();
            int d = int.Parse(input);
            while (d == 0)
            {
                Console.WriteLine("Invalid input the denominator can't be zero please try again");
                input = Console.ReadLine();
                d = int.Parse(input);
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
                    Console.WriteLine($"The result is {x / g}/{y / g}");
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;

            }
        }
        static int GCF(int x, int y)
        {
            int r = 1;
            int b;
            int s;
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
    }
}*/