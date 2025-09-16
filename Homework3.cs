namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //code for Q1
        Console.WriteLine("Input an integer:");
        string? input = Console.ReadLine();
        int N = Convert.ToInt32(input);

        bool isPrime = true;
        if (N <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{N} is prime");
        }
        else
        {
            Console.WriteLine($"{N} is non-prime");
        }

        Console.WriteLine();

        //code for Q2
        Console.WriteLine("Assign an int value to N:");
        string? input2 = Console.ReadLine();
        N = Convert.ToInt32(input2);

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

            //code for Q3

        Console.WriteLine("Assign an int value to N: ");
        string? input3 = Console.ReadLine();
        N = Convert.ToInt32(input3);

        for (int i = 1; i <= N; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        }
    }
