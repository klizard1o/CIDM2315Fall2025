using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Security.Cryptography;

namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        //Q1 and Q2
        Customer c1 = new Customer(110, "Alice", 28);
        Customer c2 = new Customer(111, "Bob", 30);

        c1.PrintCusInfo();
        c2.PrintCusInfo();

        c1.ChangeID(220);
        c2.ChangeID(221);

        c1.PrintCusInfo();
        c2.PrintCusInfo();

        c1.CompareAge(c2);
    }
}
class Customer
{
    //code for customer class
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int id, string name, int age)
    {
        cus_id = id;
        cus_name = name;
        cus_age = age;
    }
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }
    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
        else
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }
}
