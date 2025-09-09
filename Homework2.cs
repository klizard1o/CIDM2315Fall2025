namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //code for Q1

        Console.Write("Please input a letter grade: ");
        string gradeInput = Console.ReadLine().ToUpper();

        switch (gradeInput)
        {
            case "A":
                Console.WriteLine("GPA point: 4");
                break;
            case "B":
                Console.WriteLine("GPA point: 3");
                break;
            case "C":
                Console.WriteLine("GPA point: 2");
                break;
            case "D":
                Console.WriteLine("GPA point: 1");
                break;
            case "F":
                Console.WriteLine("GPA point: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;

        }

        //code for Q2
        Console.Write("Please input the first num:");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Please input the second num:");
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Please input the third num:");
        int num3 = Convert.ToInt16(Console.ReadLine());
        Console.Write("The smallest value is: ");
        Console.WriteLine(Math.Min(num1, Math.Min(num2, num3)));


        //code for Bonus
        Console.Write("Please input a year : ");
        int year = Convert.ToInt16(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a Leap Year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a Leap Year.");
        }

    }
}
