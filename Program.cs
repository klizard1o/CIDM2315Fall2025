namespace Homework5;

class Program
{
    public static void Main(string[] args){
        //call Q1_method()
        Console.WriteLine("Please input 2 integers: ");
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());

        int larger = maxOfTwo(a, b);

        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {larger}");

        //call Q2_method()
        Console.WriteLine("Please input 4 numbers: ");
        int c = Convert.ToInt16(Console.ReadLine());
        int d = Convert.ToInt16(Console.ReadLine());
        int e = Convert.ToInt16(Console.ReadLine());
        int f = Convert.ToInt16(Console.ReadLine());

        int max1 = maxOf2(c, d);
        int max2 = maxOf2(e, f);
        int largest = maxOf2(max1, max2);


        Console.WriteLine($"The larger number is: {largest}");
        
        //call Q3_method()
        static bool checkAge(int birth_year)
        {
            int current_year = 2025;
            int age = current_year - birth_year;

            if(age >= 18){
                return true;
            }
            else{
                return false;
            }
        }

    }
    //Q1 method
    public static int maxOfTwo(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    public static int maxOf2(int max1, int max2){
    //Q2_method
        if (max1 > max2)
        {
            return max1;
        }
        else
        {
            return max2;
        }
    }

    //Q3_method
    static void createAccount()
    {

        Console.Write("Enter Your Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Your Password: ");
        string password = Console.ReadLine();

        Console.Write("Enter Your Password Again");
        string confirmPassword = Console.ReadLine();

        Console.Write("Enter Your Birthyear: ");
        int birth_year = Convert.ToInt32(Console.ReadLine());
    
    if (checkAge(birth_year))
        {
            if(password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        {
            Console.WriteLine("Could not create an account");
        }
        
    } 
}
